---
-api-id: M:Microsoft.UI.Xaml.Controls.Control.OnPointerWheelChanged(Microsoft.UI.Xaml.Input.PointerRoutedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnPointerWheelChanged(Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
-->

# Microsoft.UI.Xaml.Controls.Control.OnPointerWheelChanged

## -description

Called before the [PointerWheelChanged](../microsoft.ui.xaml/uielement_pointerwheelchanged.md) event occurs.

## -parameters

### -param e

Event data for the event.

## -remarks

Touchpad input and gestures do not trigger [PointerWheelChanged](../microsoft.ui.xaml/uielement_pointerwheelchanged.md) events on a [ScrollViewer](scrollviewer.md) control. These gestures are handled internally by the [ScrollViewer](scrollviewer.md) control.

## -examples

## -see-also
[PointerRoutedEventArgs](../microsoft.ui.xaml.input/pointerroutedeventargs.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Custom user interactions](/windows/apps/design/layout/index), [Handle pointer input](/windows/uwp/input-and-devices/handle-pointer-input)
