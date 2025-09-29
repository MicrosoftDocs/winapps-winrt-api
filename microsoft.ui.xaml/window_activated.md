---
-api-id: E:Microsoft.UI.Xaml.Window.Activated
-api-type: winrt event
---

<!-- Event syntax
public event Microsoft.UI.Xaml.WindowActivatedEventHandler Activated
-->

# Microsoft.UI.Xaml.Window.Activated

## -description

Occurs when the window has been successfully activated or deactivated.

## -remarks

This event occurs when a [Window](window.md) has been activated or deactivated. You can determine the status of the `Window` activation by checking the [WindowActivationState](windowactivatedeventargs_windowactivationstate.md) property.

If any other part of the system takes focus away from the window, this event will occur. A `Window` can be visible on screen but not be active.

Window activation can happen as a result of user interaction or code, and the `WindowActivationState` will indicate which action has taken place.

## -examples

The following code example demonstrates a typical usage pattern for this event.

```csharp
void Window_Activated(object sender, WindowActivatedEventArgs e)
{
    if (e.WindowActivationState == WindowActivationState.Deactivated)
    {
        // Show the "paused" UI. 
        VisualStateManager.GoToState(this, "PauseUI", false);
    }
    else if (e.WindowActivationState == WindowActivationState.PointerActivated 
    || e.WindowActivationState == WindowActivationState.CodeActivated)
    {
        // Show the "active" UI. 
        VisualStateManager.GoToState(this, "ActivateUI", false);
    }
}
```

## -see-also

[WindowActivatedEventArgs](windowactivatedeventargs.md), [Windowing overview for WinUI and Windows App SDK](/windows/apps/develop/ui-input/windowing-overview)
