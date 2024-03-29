---
-api-id: M:Microsoft.UI.Xaml.VisualStateManager.RaiseCurrentStateChanged(Microsoft.UI.Xaml.VisualStateGroup,Microsoft.UI.Xaml.VisualState,Microsoft.UI.Xaml.VisualState,Microsoft.UI.Xaml.Controls.Control)
-api-type: winrt method
---

<!-- Method syntax
protected void RaiseCurrentStateChanged(Microsoft.UI.Xaml.VisualStateGroup stateGroup, Microsoft.UI.Xaml.VisualState oldState, Microsoft.UI.Xaml.VisualState newState, Microsoft.UI.Xaml.Controls.Control control)
-->

# Microsoft.UI.Xaml.VisualStateManager.RaiseCurrentStateChanged

## -description

When overridden in a derived class, fires the [CurrentStateChanged](visualstategroup_currentstatechanged.md) event on the specified [VisualStateGroup](visualstategroup.md).

## -parameters

### -param stateGroup

The object on which the [CurrentStateChanging](visualstategroup_currentstatechanging.md) event occurred.

### -param oldState

The state that the control transitions from.

### -param newState

The state that the control transitions to.

### -param control

The control that transitioned states.

## -remarks

This API is part of the scenario of defining a custom [VisualStateManager](visualstatemanager.md) behavior. The most important method to override in this scenario is [GoToStateCore](visualstatemanager_gotostatecore_2010136904.md), because it's that method that changes the state behavior in your custom class behavior. Overriding the behavior of `RaiseCurrentStateChanged` and [RaiseCurrentStateChanging](visualstatemanager_raisecurrentstatechanging_901595439.md) is optional: how and when the events are raised by the default implementation might be adequate for your custom class.

## -examples

## -see-also
