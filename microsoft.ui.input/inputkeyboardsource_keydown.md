---
-api-id: E:Microsoft.UI.Input.InputKeyboardSource.KeyDown
-api-type: winrt event
---

# Microsoft.UI.Input.InputKeyboardSource.KeyDown

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Input.InputKeyboardSource,Microsoft.UI.Input.KeyEventArgs> KeyDown;
-->

## -description

Occurs when the user presses a key when the ALT key is not also pressed.

## -remarks

Apps do not receive this event when an Input Method Editor (IME) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](/windows/windows-app-sdk/api/winrt/microsoft.ui.input/characterreceivedeventargs_handled) to true.

## -see-also

[InputKeyboardSource.KeyUp](inputkeyboardsource_keyup.md), [InputKeyboardSource.SystemKeyUp](inputkeyboardsource_systemkeyup.md), [InputKeyboardSource.SystemKeyDown](inputkeyboardsource_systemkeydown.md)

## -examples
