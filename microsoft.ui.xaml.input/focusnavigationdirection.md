---
-api-id: T:Microsoft.UI.Xaml.Input.FocusNavigationDirection
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Microsoft.UI.Xaml.Input.FocusNavigationDirection : int
-->

# FocusNavigationDirection

## -description

Specifies the direction that you can programmatically move focus from one element to another element within the app UI.

## -enum-fields

### -field Next:0

The next element in the tab order.

### -field Previous:1

The previous element in the tab order.

### -field Up:2

An element above the element with focus.

### -field Down:3

An element below the element with focus.

### -field Left:4

An element to the left of the element with focus.

### -field Right:5

An element to the right of the element with focus.

### -field None:6

No change in focus.

## -remarks

`FocusNavigationDirection.Previous` and `FocusNavigationDirection.Next` cannot be used with [FindNextElementOptions](findnextelementoptions.md). Only `FocusNavigationDirection.Up`, `FocusNavigationDirection.Down`, `FocusNavigationDirection.Left`, or `FocusNavigationDirection.Right` are valid.

## -examples

## -see-also

[FocusManager.TryMoveFocus](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.input.focusmanager.trymovefocus), [Keyboard interactions](/windows/apps/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/apps/design/input/focus-navigation), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic)
