---
-api-id: P:Microsoft.UI.Input.EnteringMoveSizeEventArgs.MoveSizeWindowId
-api-type: winrt property
---

# Microsoft.UI.Input.EnteringMoveSizeEventArgs.MoveSizeWindowId

<!--
public Microsoft.UI.WindowId MoveSizeWindowId { get; set; }
-->

## -description

Gets or sets the ID of the window for which to enter the move-size loop.

## -property-value

The ID of the window for which to enter the move-size loop.

The default is the ID of the window that received the pointer message that initiated the move-size loop.

## -remarks

The application can create a new window and set this value to its ID if it wants to supply an alternative target window for the move-size loop.

The new window, if created, must be on the same thread as the window that received the pointer message that initiated the move-size loop.

## -see-also

## -examples
