---
-api-id: M:Microsoft.UI.Xaml.UIElement.StartDragAsync(Microsoft.UI.Input.PointerPoint)
-api-type: winrt method
---

# Microsoft.UI.Xaml.UIElement.StartDragAsync(Microsoft.UI.Input.PointerPoint)

<!--
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.DataTransfer.DataPackageOperation> StartDragAsync (Microsoft.UI.Input.PointerPoint pointerPoint);
-->

## -description

Initiates a drag-and-drop operation.

> [!IMPORTANT]
> Not supported if a user runs the app in elevated mode, as an administrator.

## -parameters

### -param pointerPoint

The coordinates of the pointer where the user interacts with the screen, and where the drag visual is attached.

## -returns

A [Windows.ApplicationModel.DataTransfer.DataPackageOperation](/uwp/api/windows.applicationmodel.datatransfer/datapackageoperation) value that indicates the type of drag-and-drop operation, and whether the operation was successful.

## -remarks

If you implement custom gesture detection to initiate a drag operation, you can call the [Microsoft.UI.Xaml.UIElement.StartDragAsync](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml/uielement_startdragasync_1540288469) method to programmatically initiate a drag operation on any UIElement. Calling this method results in the [Microsoft.UI.Xaml.UIElement.DragStarting](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml/uielement_dragstarting) event being raised. Handle the DragStarting event to specify other properties of the operation, such as the data package and drag visual.

The *pointerPoint* parameter is the point at which the user interacts with the screen using an input device (touch, mouse, or pen). The drag visual that is shown during the drag operation is attached to the pointer indicated in the caller-provided [PointerPoint](/windows/windows-app-sdk/api/winrt/microsoft.ui.input/pointerpoint).

The [Microsoft.UI.Xaml.UIElement.StartDragAsync](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml/uielement_startdragasync_1540288469) returned by this method indicates whether the drag operation is a move, copy, or link; and whether or not it's a success. This is the same value that's provided by the [Microsoft.UI.Xaml.DropCompletedEventArgs.DropResult](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml/dropcompletedeventargs_dropresult) property.

## -see-also

## -examples
