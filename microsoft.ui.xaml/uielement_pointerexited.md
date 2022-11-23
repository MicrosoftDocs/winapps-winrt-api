---
-api-id: E:Microsoft.UI.Xaml.UIElement.PointerExited
-api-type: winrt event
---

<!-- Event syntax
public event Microsoft.UI.Xaml.Input.PointerEventHandler PointerExited
-->

# Microsoft.UI.Xaml.UIElement.PointerExited

## -description

Occurs when a pointer leaves the hit test area of this element.

## -xaml-syntax

```xaml
<uiElement PointerExited="eventhandler"/>
```

## -remarks

The `PointerExited` event fires in response to a pointer that was initially in the element's bounding area leaving that bounding area. Touch, mouse, and pen/stylus interactions are received, processed, and managed as pointer input in the app. Any of these devices and their interactions can produce a `PointerExited` event. For more info, see [Handle pointer input](/windows/apps/design/input/handle-pointer-input) and the other remarks in this topic.

Use a handler based on [PointerEventHandler](../microsoft.ui.xaml.input/pointereventhandler.md) to handle this event.

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

`PointerExited` supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../microsoft.ui.xaml.input/pointerroutedeventargs_handled.md). See [AddHandler](uielement_addhandler_1350394113.md).

Specific Windows Runtime controls may have class-based handling for the `PointerExited` input event. If so, the control probably has an override for the method [OnPointerExited](../microsoft.ui.xaml.controls/control_onpointerexited_142906122.md). Typically the event is not marked handled by the class handler, so the `PointerExited` event can still be handled by your user code for the control in your UI. For more info on how class-based handling for events works, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

If another element has captured the pointer, `PointerExited` won't fire even if the captured pointer leaves an element's bounds. For more info on pointer capture, see [CapturePointer](uielement_capturepointer_1027273898.md) or [Mouse interactions](/windows/uwp/input-and-devices/mouse-interactions).

### PointerExited for mouse and pen/stylus input

A mouse input device has an onscreen cursor that is visible whenever the mouse moves, even if no mouse button is pressed at the time. Similar behavior is available for pen device input, where the input devices can detect that the stylus is hovering just over the input device surface ([IsInRange](../microsoft.ui.xaml.input/pointer_isinrange.md)) but not touching it. Mouse and pen device input will thus fire `PointerExited` events in slightly different cases than touch events do. For more info, see [Mouse interactions](/windows/uwp/input-and-devices/mouse-interactions). A `PointerExited` event fires after the last [PointerMoved](uielement_pointerentered.md) event for the element fires.

### PointerExited for touch input

A touch point is only detectable if a finger is touching the surface. Whenever a touch action results in a [PointerReleased](uielement_pointerreleased.md) event, that event is immediately followed by a `PointerExited` event, with all the event data being the same information for the two events (same pointer ID, same position, and so on.) In other words the pointer is considered to enter the element at the moment and position that the element is touched by a touch point.

Alternatively, a touch point will generate `PointerExited` if that pointer remains in constant contact with the surface as it moves, was over the element initially, and then exits the hit testing bounds of an element. For these kinds of touch actions it's also possible that the action could be processed as a manipulation, or as a gesture, rather than a pointer event. For more info, see [Handle pointer input](/windows/apps/design/input/handle-pointer-input).

### Routed event behavior for PointerExited

`PointerExited` is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview). You can define multiple `PointerExited` events for elements in a XAML UI, including for elements that are in a parent-child relationship. In a typical UI composition, the child elements are somewhere within a parent element's bounds, so the `PointerExited` event will first occur for the child when the pointer moves out of the child, and then for the parent when the pointer moves completely out of that parent. The `PointerExited` event doesn't typically bubble to the parent when the child element fires it, because it would be confusing for the input system to route the `PointerExited` event occurrence to the parent too. Typically you don't want `PointerExited` events to route anyways, you only want to process them from the sender. You can explicitly prevent event routing by setting [Handled](../microsoft.ui.xaml.input/pointerroutedeventargs_handled.md) to `true` in your handler.

In rare cases it's possible to see a `PointerExited` event bubble to the parent. For example, if you've used a [RenderTransform](uielement_rendertransform.md) to offset a child element outside the bounds of its parent, the event bubbles to the parent when the child element is exited, and gives the event info as reported by how the child element fired the event.

### PointerOver visual states for controls

Controls that have control templates can apply visual states that are active only when a pointer is over the bounds of the control. You don't always need to handle [PointerEntered](uielement_pointerentered.md) or `PointerExited` to get or change this behavior. You may need to re-template the control. If you are deriving from an existing control that already has the low-level input handling that invokes visual states, you should provide a visual state named "PointerOver" in the "CommonStates"  [VisualStateGroup](visualstategroup.md), and the built-in control logic will load that visual state whenever a pointer is over the control. A visual state for pointer-over is often present on controls that can be invoked or selected, like a [Button](../microsoft.ui.xaml.controls/button.md) or [ListViewItem](../microsoft.ui.xaml.controls/listviewitem.md). If you're deriving from a base class like [Control](../microsoft.ui.xaml.controls/control.md) that doesn't have built-in input event handling that invokes visual states, you may need to override [OnPointerEntered](../microsoft.ui.xaml.controls/control_onpointerentered_179110404.md) and [OnPointerExited](../microsoft.ui.xaml.controls/control_onpointerexited_142906122.md) yourself to get this behavior. Use `OnPointerExited` to call [GoToState](visualstatemanager_gotostate_51722231.md) to load a state other than the "PointerOver" state, for example "Normal".

## -examples

## -see-also

[PointerRoutedEventArgs](../microsoft.ui.xaml.input/pointerroutedeventargs.md), [PointerEntered](uielement_pointerentered.md), [PointerReleased](uielement_pointerreleased.md), [Handle pointer input](/windows/apps/design/input/handle-pointer-input), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Relative mouse movement and CoreWindow](/en-us/windows/uwp/gaming/relative-mouse-movement), [XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
