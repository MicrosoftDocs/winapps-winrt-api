---
-api-id: T:Microsoft.UI.Input.FocusNavigationResult
-api-type: winrt enum
---

# Microsoft.UI.Input.FocusNavigationResult

<!--
public enum FocusNavigationResult
-->

## -description

Specifies the possible results of a focus navigation event.

## -enum-fields

### -field NotMoved: 0

Event was not subscribed or the event ran into an error. This is the default value.

### -field Moved: 1

Focus successfully moved to another component

### -field NoFocusableElements: 2

No focusable element was found.

## -remarks

## -see-also

[FocusNavigationRequestEventArgs.Result](focusnavigationrequesteventargs_result.md), [InputFocusController.DepartFocus(Microsoft.UI.Input.FocusNavigationRequest)](inputfocuscontroller_departfocus_29783563.md), [InputFocusNavigationHost.NavigateFocus(Microsoft.UI.Input.FocusNavigationRequest)](inputfocusnavigationhost_navigatefocus_534361705.md)

## -examples
