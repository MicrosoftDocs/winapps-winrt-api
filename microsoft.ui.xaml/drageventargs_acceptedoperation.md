---
-api-id: P:Microsoft.UI.Xaml.DragEventArgs.AcceptedOperation
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DataPackageOperation AcceptedOperation { get;  set; }
-->

# Microsoft.UI.Xaml.DragEventArgs.AcceptedOperation

## -description

Gets or sets a value that specifies which operations (none, move, copy, and/or link) can be accepted by the target of the drag event.

## -property-value

A value or bitwise combination of values that specifies which operations can be accepted by the target of the drag event.

## -remarks

This value is set in the [DragEnter](uielement_dragenter.md) or [DragOver](uielement_dragover.md) event of the `UIElement` that is a potential drop target of the drag and drop operation. It notifies the drag source of what operations it can accept, if any, for the [DataPackage](/uwp/api/windows.applicationmodel.datatransfer.datapackage) that is being dragged.

For more info about data operations, see the [DataPackageOperation](/uwp/api/windows.applicationmodel.datatransfer.datapackageoperation) enumeration.

## -examples

In this example, a `ListView` accepts only text content. In the `DragOver` event handler, the `AcceptedOperation` is set to `Copy` if the `DataPackage` contains text; otherwise, `AcceptedOperation` is set to `None`.

```csharp
private void TargetListView_DragOver(object sender, DragEventArgs e)
{
    // The list accepts only text.
    e.AcceptedOperation = 
       (e.DataView.Contains(StandardDataFormats.Text)) 
           ? DataPackageOperation.Copy : DataPackageOperation.None;
}
```

## -see-also

[Drag-and-drop overview](/windows/apps/design/input/drag-and-drop)
