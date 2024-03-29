---
-api-id: T:Microsoft.UI.Input.DragDrop.DragUIContentMode
-api-type: winrt enum
---

# Microsoft.UI.Input.DragDrop.DragUIContentMode

<!--
public enum DragUIContentMode
-->

## -description

Specifies the ways a UI visual can be provided when dragging an object.

## -enum-fields

### -field Auto: 0

Specifies the UI visual will be provided synchronously.

### -field Deferred: 1

Specifies the UI visual will be provided with an asynchronous task.

## -remarks

Used to specify whether the operation should wait for the UI visual to load before starting, or run in parallel.

## -see-also

[DragOperation.DragUIContentMode](dragoperation_draguicontentmode.md)

## -examples
