---
-api-id: E:Microsoft.UI.Xaml.UIElement.ManipulationInertiaStarting
-api-type: winrt event
---

<!-- Event syntax
public event Microsoft.UI.Xaml.Input.ManipulationInertiaStartingEventHandler ManipulationInertiaStarting
-->

# Microsoft.UI.Xaml.UIElement.ManipulationInertiaStarting

## -description

Occurs when the input device loses contact with the [UIElement](uielement.md) object during a manipulation and inertia begins.

## -xaml-syntax

```xaml
<uiElement ManipulationInertiaStarting="eventhandler"/>
```

## -remarks

For custom controls and interaction experiences, see [GestureRecognizer.ManipulationInertiaStarting](../microsoft.ui.input/gesturerecognizer_manipulationinertiastarting.md).

An element must have a [ManipulationMode](uielement_manipulationmode.md) value other than `None` or `System` to be a manipulation event source. The default value of `ManipulationMode` is `System`, which enables built-in control logic to process manipulations, but doesn't permit app code to handle manipulation events. If you want to handle manipulations, set `ManipulationMode` to `All`, or to specific [ManipulationModes](../microsoft.ui.xaml.input/manipulationmodes.md) values. For more info, see `ManipulationMode`.

`ManipulationInertiaStarting` is a routed event. If the event is permitted to bubble up to parent elements because it goes unhandled, then it is possible to handle the event on parent elements even if [ManipulationMode](uielement_manipulationmode.md) is `None` or `System` on the parent element. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

For touch actions and also for interaction-specific or manipulation events that are consequences of a touch action, an element must be hit-test visible in order to be the event source and fire the event that is associated with the action. [UIElement.Visibility](uielement_visibility.md) must be [Visible](visibility.md). Other properties of derived types also affect hit-test visibility. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

`ManipulationInertiaStarting` supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../microsoft.ui.xaml.input/manipulationinertiastartingroutedeventargs_handled.md). See [AddHandler](uielement_addhandler_1350394113.md).

## -examples

## -see-also

[ManipulationInertiaStartingRoutedEventArgs](../microsoft.ui.xaml.input/manipulationinertiastartingroutedeventargs.md), [OnManipulationInertiaStarting](../microsoft.ui.xaml.controls/control_onmanipulationinertiastarting_881360850.md), [ManipulationStarted](uielement_manipulationstarted.md), [Using manipulation events](/previous-versions/windows/apps/hh465387(v=win.10)), [XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
