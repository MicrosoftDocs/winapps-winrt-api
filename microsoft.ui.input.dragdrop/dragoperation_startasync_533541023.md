---
-api-id: M:Microsoft.UI.Input.DragDrop.DragOperation.StartAsync(Microsoft.UI.Input.DragDrop.DragDropManager,Microsoft.UI.Input.PointerPoint)
-api-type: winrt method
---

# Microsoft.UI.Input.DragDrop.DragOperation.StartAsync(Microsoft.UI.Input.DragDrop.DragDropManager,Microsoft.UI.Input.PointerPoint)

<!--
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.DataTransfer.DataPackageOperation> StartAsync (Microsoft.UI.Input.DragDrop.DragDropManager initialTarget, Microsoft.UI.Input.PointerPoint initialPointerPoint);
-->

## -description

Starts the drag and drop operation for the specified [DragDropManager](/windows/windows-app-sdk/api/winrt/microsoft.ui.input.dragdrop.dragdropmanager) using the specified input pointer.

## -parameters

### -param initialTarget

The target of the drag and drop operation.

### -param initialPointerPoint

The input pointer associated with the drag and drop operation.

## -returns

An asynchronous operation object from which, on successful completion, you can retrieve a [DataPackageOperation](/uwp/api/windows.applicationmodel.datatransfer.datapackageoperation) object that specifies the action(s) being performed.

## -remarks

## -see-also

## -examples
