---
-api-id: M:Microsoft.UI.Windowing.AppWindow.MoveInZOrderBelow(Microsoft.UI.WindowId)
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.MoveInZOrderBelow(Microsoft.UI.WindowId)

<!--
public void MoveInZOrderBelow (Microsoft.UI.WindowId windowId);
-->

## -description

Moves the current window to be below the specified window in the Z-order.

## -parameters

### -param windowId

The identifier of the window to place the current window below.

## -remarks

This method lets you set or modify your window's position in the Z-order. You do this by passing in a valid `WindowId` for the window your window will be placed below in z-order. To place your window at the top of the z-order, use [MoveInZOrderAtTop](appwindow_moveinzorderattop_872169634.md). To place it at the bottom, use [MoveInZOrderAtBottom](appwindow_moveinzorderatbottom_357283143.md).

## -see-also

## -examples


