---
-api-id: E:Microsoft.UI.Composition.SystemBackdrops.DesktopAcrylicController.StateChanged
-api-type: winrt event
---

# Microsoft.UI.Composition.SystemBackdrops.DesktopAcrylicController.StateChanged

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Composition.SystemBackdrops.ISystemBackdropControllerWithTargets,object> StateChanged;
-->


## -description

Occurs when the state of the system backdrop has changed.

## -remarks

You can subscribe to this event to be notified when the [SystemBackdropState](systembackdropstate.md) changes between `Active` and `Fallback`/`High Contrast`. For example, you might have other non-system backdrop UI you would like to update based on the system backdrop material state.

## -see-also

[State](desktopacryliccontroller_state.md)

## -examples


