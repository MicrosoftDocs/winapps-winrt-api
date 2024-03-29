---
-api-id: M:Microsoft.UI.Xaml.Input.FocusManager.FindNextFocusableElement(Microsoft.UI.Xaml.Input.FocusNavigationDirection)
-api-type: winrt method
---

<!-- Method syntax
public Microsoft.UI.Xaml.UIElement FindNextFocusableElement(Microsoft.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection)
-->

# Microsoft.UI.Xaml.Input.FocusManager.FindNextFocusableElement

## -description

Retrieves the element that should receive focus based on the specified navigation direction.

## -parameters

### -param focusNavigationDirection

The direction that focus moves from element to element within the application UI.

## -returns

`null` if focus cannot be set in the specified direction.

## -remarks

You can also use either the [FindNextElement(FocusNavigationDirection, FindNextElementOptions)](focusmanager_findnextelement_905966547.md) method or the [FindNextElement(FocusNavigationDirection)](focusmanager_findnextelement_79258569.md) method to programmatically move focus. These methods retrieve the element (as a [DependencyObject](../microsoft.ui.xaml/dependencyobject.md)) that will receive focus based on the specified navigation direction (directional navigation only, cannot be used to emulate tab navigation).

> [!NOTE]
> We recommend using the [FindNextElement](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.input.focusmanager.findnextelement) method instead of `FindNextFocusableElement` because `FindNextFocusableElement` retrieves a `UIElement`, which returns `null` if the next focusable element is not a `UIElement` (such as a [Hyperlink](../microsoft.ui.xaml.documents/hyperlink.md) object).

## -examples

## -see-also

[FindNextFocusableElement(FocusNavigationDirection, Rect)](focusmanager_findnextfocusableelement_1604618823.md), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)
