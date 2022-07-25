---
-api-id: M:Microsoft.UI.Xaml.Input.GettingFocusEventArgs.TryCancel
-api-type: winrt method
---

<!-- Method syntax.
public bool GettingFocusEventArgs.TryCancel()
-->

# Microsoft.UI.Xaml.Input.GettingFocusEventArgs.TryCancel

## -description
Attempts to cancel the ongoing focus action.

## -returns

`true` if the focus action is canceled; otherwise, `false`.

## -remarks

You should call the [TryCancel](gettingfocuseventargs_trycancel_50138317.md) method instead of setting this property.

The [GotFocus](../microsoft.ui.xaml/uielement_gotfocus.md) routed event is raised on an element after it receives focus, while the [LostFocus](../microsoft.ui.xaml/uielement_lostfocus.md) routed event is raised on an element after it loses focus.

The [GettingFocus](../microsoft.ui.xaml/uielement_gettingfocus.md) and [LosingFocus](../microsoft.ui.xaml/uielement_losingfocus.md) routed events occur before the focus change takes place, which enables your application to modify or cancel the focus change behavior.

[GettingFocus](../microsoft.ui.xaml/uielement_gettingfocus.md) and [LosingFocus](../microsoft.ui.xaml/uielement_losingfocus.md) are raised synchronously, while [GotFocus](../microsoft.ui.xaml/uielement_gotfocus.md) and [LostFocus](../microsoft.ui.xaml/uielement_lostfocus.md) are raised asynchronously. For example, if your app calls the [Focus](../microsoft.ui.xaml/uielement_focus_1914077590.md) method of a control, `GettingFocus` is raised during the call, but `GotFocus` is raised after the call completes.

If focus is moved while these events are still bubbling, an exception is thrown.

## -see-also
[GettingFocusEventArgs.TrySetNewFocusedElement](gettingfocuseventargs_trysetnewfocusedelement_1195990427.md), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)


## -examples

