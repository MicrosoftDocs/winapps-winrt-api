---
-api-id: T:Microsoft.UI.Input.InputActivationListener
-api-type: winrt class
---

# Microsoft.UI.Input.InputActivationListener

<!--
public sealed class InputActivationListener : Microsoft.UI.Input.InputObject
-->

## -description

Provides the ability to access and observe changes to the activation state of an object.

## -remarks

If the object associated with an InputActivationListener is destroyed, the InputActivationListener object will be implicitly disposed. See [InputObject](inputobject.md) for more detail.

## -see-also

[Window](../microsoft.ui.xaml/window.md), [ContentIsland](../microsoft.ui.content/contentisland.md)

## -examples

The following Windows App SDK example shows how to respond to activation events for an <xref:Microsoft.UI.Windowing.AppWindow?displayProperty=nameWithType> object:

```csharp
class RespondToAppWindowActivation
{
    InputActivationListener inputActivationListener;

    public RespondToAppWindowActivation(Microsoft.UI.Windowing.AppWindow appWindow)
    {
        inputActivationListener = InputActivationListener.GetForWindowId(appWindow.Id);

        inputActivationListener.InputActivationChanged += OnActivationChanged;
    }

    void OnActivationChanged(
        InputActivationListener sender,
        InputActivationListenerActivationChangedEventArgs args)
    {
        if (sender.State == InputActivationState.Activated)
        {
            System.Diagnostics.Debug.WriteLine("AppWindow was activated.");

            LeaveMyBackgroundMode();
        }
        else
        {
            System.Diagnostics.Debug.WriteLine("AppWindow was deactivated.");

            EnterMyBackgroundMode();
        }
    }
}
```
