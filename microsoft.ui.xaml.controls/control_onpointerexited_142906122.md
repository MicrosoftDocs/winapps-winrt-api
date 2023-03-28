---
-api-id: M:Microsoft.UI.Xaml.Controls.Control.OnPointerExited(Microsoft.UI.Xaml.Input.PointerRoutedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnPointerExited(Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
-->

# Microsoft.UI.Xaml.Controls.Control.OnPointerExited

## -description

Called before the [PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md) event occurs.

## -parameters

### -param e

Event data for the event.

## -remarks

Typically, [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) and [PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md) events are fired if the pointer is physically moved by the user. However, there are circumstances where these events can also fire if the pointer is not physically moved by the user.

- A [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) event is fired if the object with a [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) handler is programmatically moved underneath the pointer, the object [Visibility](../microsoft.ui.xaml/uielement_visibility.md) is changed from **Collapsed** to **Visible** while it's underneath the pointer, or the cursor is over an element such as a popup or flyout that disappears, causing the cursor to now appear over the object.
- If a [PointerEntered](../microsoft.ui.xaml/uielement_pointerentered.md) event has fired on an object, a corresponding [PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md) event is fired when a UI state change occurs that causes the pointer to no longer be over that object. For example, the object position is programmatically moved to no longer be underneath the pointer, the object [Visibility](../microsoft.ui.xaml/uielement_visibility.md) is set to **Collapsed**, or the pointer is over transient UI such as a popup or flyout that is programmatically dismissed or a display timeout occurs.

## -examples

## -see-also

[UIElement.PointerExited](../microsoft.ui.xaml/uielement_pointerexited.md), [PointerRoutedEventArgs](../microsoft.ui.xaml.input/pointerroutedeventargs.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Custom user interactions](/windows/apps/design/layout/index), [Handle pointer input](/windows/uwp/input-and-devices/handle-pointer-input)
