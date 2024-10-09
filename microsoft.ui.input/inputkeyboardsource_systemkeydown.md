---
-api-id: E:Microsoft.UI.Input.InputKeyboardSource.SystemKeyDown
-api-type: winrt event
---

# Microsoft.UI.Input.InputKeyboardSource.SystemKeyDown

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Input.InputKeyboardSource,Microsoft.UI.Input.KeyEventArgs> SystemKeyDown;
-->

## -description

Occurs when the user presses a key when the ALT key is also pressed.

## -remarks

Apps do not receive this event when an Input Method Editor (IME) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](xref:Microsoft.UI.Input.CharacterReceivedEventArgs.Handled) to true.

## -see-also

[InputKeyboardSource.SystemKeyUp](inputkeyboardsource_systemkeyup.md), [InputKeyboardSource.KeyUp](inputkeyboardsource_keyup.md), [InputKeyboardSource.SystemKeyDown](inputkeyboardsource_systemkeydown.md)

## -examples
