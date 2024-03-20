---
-api-id: P:Microsoft.UI.Xaml.DragStartingEventArgs.AllowedOperations
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DataPackageOperation AllowedOperations { get;  set; }
-->

# Microsoft.UI.Xaml.DragStartingEventArgs.AllowedOperations

## -description

Gets or sets a value that specifies which operations (none, move, copy, and/or link) are allowed by the source of the drag event.

## -property-value

A value or bitwise combination of values that specifies which operations are allowed by the source of the drag event.

## -remarks

This value is set in the [UIElement.DragStarting](uielement_dragstarting.md) event handler. It can then be read from the [DragEventArgs.AllowedOperations](drageventargs_allowedoperations.md) property in the [DragEnter](../microsoft.ui.xaml/uielement_dragenter.md) and [DragOver](../microsoft.ui.xaml/uielement_dragover.md) events of the `UIElement` that is a potential drop target of the drag and drop operation. It notifies the target which data package operations (none, move, copy, and/or link) are allowed by the source.

For more info about the allowed data operations, see the [DataPackageOperation](/uwp/api/windows.applicationmodel.datatransfer.datapackageoperation) enumeration.

## -examples

## -see-also

[Drag-and-drop overview](/windows/apps/design/input/drag-and-drop), [DragEventArgs.AllowedOperations](drageventargs_allowedoperations.md), [DragOperation.AllowedOperations](../microsoft.ui.input.dragdrop/dragoperation_allowedoperations.md)
