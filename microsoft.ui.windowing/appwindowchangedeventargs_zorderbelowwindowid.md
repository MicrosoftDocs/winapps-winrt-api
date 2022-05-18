---
-api-id: P:Microsoft.UI.Windowing.AppWindowChangedEventArgs.ZOrderBelowWindowId
-api-type: winrt property
---

# Microsoft.UI.Windowing.AppWindowChangedEventArgs.ZOrderBelowWindowId

<!--
public Microsoft.UI.WindowId ZOrderBelowWindowId { get; }
-->

## -description

Gets the ID of the window directly above this window in Z-order, if Z-order changed and this window is not the top window.

## -property-value

The ID of the window directly above this window in Z-order, if [DidZOrderChange](appwindowchangedeventargs_didzorderchange.md) is `true` and this window is not the top window; otherwise, 0.

## -remarks

## -see-also

[AppWindow.MoveInZOrderAtBottom](appwindow_moveinzorderatbottom_357283143.md), [AppWindow.MoveInZOrderAtTop](appwindow_moveinzorderattop_872169634.md), [AppWindow.MoveInZOrderBelow](appwindow_moveinzorderbelow_1978145726.md)

## -examples


