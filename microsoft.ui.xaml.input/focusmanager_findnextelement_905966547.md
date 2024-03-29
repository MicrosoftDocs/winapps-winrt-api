---
-api-id: M:Microsoft.UI.Xaml.Input.FocusManager.FindNextElement(Microsoft.UI.Xaml.Input.FocusNavigationDirection,Microsoft.UI.Xaml.Input.FindNextElementOptions)
-api-type: winrt method
---

<!-- Method syntax.
public DependencyObject FocusManager.FindNextElement(FocusNavigationDirection focusNavigationDirection, FindNextElementOptions focusNavigationOptions)
-->

# Microsoft.UI.Xaml.Input.FocusManager.FindNextElement

## -description

Retrieves the element that should receive focus based on the specified navigation direction (cannot be used with tab navigation, see remarks).

## -parameters

### -param focusNavigationDirection

The direction that focus moves from element to element within the app UI.

### -param focusNavigationOptions

The options to help identify the next element to receive focus with keyboard/controller/remote navigation.

## -returns

The next object to receive focus.

## -remarks

We recommend using this method instead of [FindNextFocusableElement(FocusNavigationDirection)](focusmanager_findnextfocusableelement_2063175091.md). `FindNextFocusableElement` retrieves a `UIElement`, which returns `null` if the next focusable element is not a `UIElement` (such as a [Hyperlink](../microsoft.ui.xaml.documents/hyperlink.md) object).

Tab navigation ([FocusNavigationDirection.Previous](focusnavigationdirection.md) and [FocusNavigationDirection.Next](focusnavigationdirection.md)) cannot be used with [FindNextElementOptions](findnextelementoptions.md). Only directional navigation ([FocusNavigationDirection.Up](focusnavigationdirection.md), [FocusNavigationDirection.Down](focusnavigationdirection.md), [FocusNavigationDirection.Left](focusnavigationdirection.md), or [FocusNavigationDirection.Right](focusnavigationdirection.md)) is valid.

## -see-also

[Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)

## -examples
