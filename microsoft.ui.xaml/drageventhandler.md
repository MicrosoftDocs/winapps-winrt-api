---
-api-id: T:Microsoft.UI.Xaml.DragEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void DragEventHandler(System.Object sender, Microsoft.UI.Xaml.DragEventArgs e)
-->
# Microsoft.UI.Xaml.DragEventHandler

## -description

Represents the method that will handle the [DragEnter](uielement_dragenter.md), [DragLeave](uielement_dragleave.md), [DragOver](uielement_dragover.md), and [Drop](uielement_drop.md) events of a [UIElement](uielement.md).

## -parameters

### -param sender

The object where the event handler is attached.

### -param e

The event data.

## -remarks

`DragEventHandler` is the delegate you implement to handle these events:

+ [UIElement.DragEnter](uielement_drop.md)
+ [UIElement.DragLeave](uielement_dragleave.md)
+ [UIElement.DragOver](uielement_dragover.md)
+ [UIElement.Drop](uielement_drop.md)

These events are routed events. Changing the value of the [Handled](drageventargs_handled.md) property of [DragEventArgs](drageventargs.md) from an event handler can influence how a routed event behaves. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

The [Control](../microsoft.ui.xaml.controls/control.md) class has pre-wired event handlers that [Control](../microsoft.ui.xaml.controls/control.md) derived types can override to provide class-based handling for the drag-drop events,. These methods are:

+ [Control.OnDragEnter](../microsoft.ui.xaml.controls/control_ondragenter_1145537454.md)
+ [Control.OnDragLeave](../microsoft.ui.xaml.controls/control_ondragleave_1870191881.md)
+ [Control.OnDragOver](../microsoft.ui.xaml.controls/control_ondragover_1632752949.md)
+ [Control.OnDrop](../microsoft.ui.xaml.controls/control_ondrop_1937221154.md)

The Windows Runtime implementation of drag-drop concepts permits only certain controls and input actions to initiate a drag-drop action. There is no generalized `DoDragDrop` method that would permit any UI element to initiate a drag-drop action. The main source of a drag-drop action is when you drag the items of a list such as [GridView](../microsoft.ui.xaml.controls/gridview.md).

## -examples

## -see-also

[Drag-and-drop overview](/windows/apps/design/input/drag-and-drop), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [DragEventArgs](drageventargs.md)
