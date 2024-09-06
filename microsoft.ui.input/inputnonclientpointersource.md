---
-api-id: T:Microsoft.UI.Input.InputNonClientPointerSource
-api-type: winrt class
---

# Microsoft.UI.Input.InputNonClientPointerSource

<!--
public sealed class InputNonClientPointerSource
-->

## -description

Processes pointer input and window messages in the non-client area of a window.

## -remarks

The non-client area of a window includes elements such as the title bar, menu bar, or window frame.

These APIs can also be used by custom controls and in scenarios that depend on the completion of a move or resize (such as regenerating resources).

## -see-also

## -examples

The following example shows how a non-XAML application can use **InputNonClientPointerSource** APIs to implement a custom tab control.

```csharp
public class ApplicationWindow
{
    public AppWindow AppWindow { get; }
    public static List<ApplicationWindow> Windows { get; } = new();

    public void ApplicationWindow()
    {
        this.AppWindow = CreateAppWindow();

        // We'll keep each window in a list to keep them alive until the user closes them.
        Windows.Add(this);

        this.AppWindow.Destroying += (AppWindow sender, object args) =>
        {
            Windows.Remove(this);
        };

        InputNonClientPointerSource nonClientPointerSource = 
            InputNonClientPointerSource.GetForWindowId(this.AppWindow.Id);

        nonClientPointerSource.SetRegionRects(NonClientRegionKind.Caption, GetTabRegion());

        // EnteringMoveSize doesn't correspond to a move-size window message.
        // It's raisedon WM_NCLBUTTONDOWN when we're about to enter the move-size loop.
        nonClientPointerSource.EnteringMoveSize += OnEnteringMoveSize;
        nonClientPointerSource.EnteredMoveSize += OnEnteredMoveSize;
        nonClientPointerSource.WindowRectChanging += OnWindowRectChanging;
        nonClientPointerSource.ExitedMoveSize += OnExitedMoveSize;

        // Note that InputNonClientPointerSource also has a WindowRectChanged event that 
        // corresponds to WM_WINDOWPOSCHANGED, but we don't need to handle it for the 
        // purposes of smooth tab tear-out.
    }

    private void OnEnteringMoveSize(InputNonClientPointerSource sender, EnteringMoveSizeEventArgs args)
    {
        if (this.SelectedTabs.Count == this.Tabs.Count)
        {
            // If all tabs are selected, then we aren't tearing out any tab, 
            // so we'll just allow the window to be dragged normally instead of 
            // creating a new window to host torn-out tabs.
            return;
        }

        // Create a new initially hidden window to host the torn-out tab.
        ApplicationWindow tornOutWindow = new();
        tornOutWindow.AppWindow.IsVisible = false;
        args.MoveSizeWindowId(tornOutWindow.AppWindow.Id);
    }

    private void OnEnteredMoveSize(InputNonClientPointerSource sender, EnteredMoveSizeEventArgs args)
    {
        // Initialize the tab tear-out state machine. 
        // This is necessary even if we didn't create a new window in OnEnteringMoveSize,
        // because we still need to handle the case where the user drags the tabs on top of 
        // another tab control to merge them into that other tab control.
    }

    private void OnWindowRectChanging(InputNonClientPointerSource sender, WindowRectChangingEventArgs args)
    {
        //
        // Update the tab tear-out state machine:
        //
        //    1. If the user has dragged the selected tabs out of the tab control's bounds, 
        //       show the new window created to host them and move the selected tabs 
        //       to the new window's tab control.
        //    2. If the user is dragging on a tab control in a window where all the tabs are selected, 
        //       allow the window to be dragged as normal.
        //    3. If the user has dragged a tab control window on top of another window's tab control, 
        //       hide the window being dragged and move the tabs being dragged to the other 
        //       window's tab control.
        //
    }

    private void OnExitedMoveSize(InputNonClientPointerSource sender, ExitedMoveSizeEventArgs args)
    {
        // Finalize the tab tear-out state machine.  Destroy any hidden windows.
    }

    private AppWindow CreateAppWindow()
    {
        // Create an AppWindow and set up its content.
    }
}
