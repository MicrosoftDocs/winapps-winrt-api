---
-api-id: E:Microsoft.UI.Xaml.UIElement.GotFocus
-api-type: winrt event
---

<!-- Event syntax
public event Microsoft.UI.Xaml.RoutedEventHandler GotFocus
-->

# Microsoft.UI.Xaml.UIElement.GotFocus

## -description

Occurs when a [UIElement](uielement.md) receives focus. This event is raised asynchronously, so focus can move again before bubbling is complete.

## -xaml-syntax

```xaml
<uiElement GotFocus="eventhandler"/>
```

## -remarks

We recommend using the [UIElement](../microsoft.ui.xaml/uielement.md) focus routed events instead of [FocusManager](../microsoft.ui.xaml.input/focusmanager.md) events whenever possible.

Only a single UI element at a time can have focus.

A control can get focus when another control loses focus, the application view changes, the user switches applications, or the user interacts with the system such that the application is no longer in the foreground.

[LostFocus](uielement_lostfocus.md) is raised before `GotFocus`.

If you are using control compositing or UI compositing and handling `GotFocus` on a container such as a [Panel](../microsoft.ui.xaml.controls/panel.md) or [GridView](../microsoft.ui.xaml.controls/gridview.md), determine which element in the composition received the focus by checking the [OriginalSource](routedeventargs_originalsource.md) on the event data.

As the `GotFocus` event doesn't have any specialized event data, you can check the [UIElement.FocusState](uielement_focusstate.md) property to determine whether it was user or app code that caused an element to gain focus.

```csharp
private void panel_GotFocus(object sender, RoutedEventArgs e)
{
    UIElement uie = e.OriginalSource as UIElement;
    FocusState fc = uie.FocusState;
}
```

Keyboard focus is particularly relevant for keyboard event handling, because only the currently keyboard-focused [UIElement](uielement.md) can be the source of the [KeyUp](uielement_keyup.md) and [KeyDown](uielement_keydown.md) key events. Applications might call [UIElement.Focus(Microsoft.UI.Xaml.FocusState)](uielement_focus_1914077590.md) as an initialization action so that the key events in the app as a whole can be used to detect access or accelerator keys. For more info, see [Keyboard interactions](/windows/uwp/input-and-devices/keyboard-interactions).

`GotFocus` is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

Specific Windows Runtime controls may have class-based handling for the `GotFocus` event. If so, the control probably has an override for the method [OnGotFocus](../microsoft.ui.xaml.controls/control_ongotfocus_2110871543.md). Typically the event is marked handled by the class handler, and the GotFocus event is not raised for handling by any user code handlers on that control. Controls might handle the event in order to load a visual state property that displays a focus rectangle.

A control's focus rectangle is an important visual component that aids accessibility by identifying the current focused element and indicating where the user is within the tab sequence of the application UI. In some cases, the [FocusState](focusstate.md) of the focus action is relevant for whether a visible focus indicator should display.

For more info on how class-based handling for events works, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview). For more info on tab sequences and accessibility, see [Keyboard accessibility](/windows/uwp/accessibility/keyboard-accessibility).

## -examples

## -see-also

[RoutedEventArgs](routedeventargs.md), [GettingFocus](uielement_gettingfocus.md), [GettingFocusEvent](uielement_gettingfocusevent.md), [LostFocus](uielement_lostfocus.md), [LosingFocusEvent](uielement_losingfocusevent.md), [LosingFocus](uielement_losingfocus.md), [UIElement.Focus(Microsoft.UI.Xaml.FocusState)](uielement_focus_1914077590.md), [AddHandler](uielement_addhandler_1350394113.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)
