---
-api-id: E:Microsoft.UI.Input.InputKeyboardSource.KeyUp
-api-type: winrt event
---

# Microsoft.UI.Input.InputKeyboardSource.KeyUp

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Input.InputKeyboardSource,Microsoft.UI.Input.KeyEventArgs> KeyUp;
-->

## -description

Occurs when the user releases a key that was pressed when the ALT key was not also pressed.

## -remarks

Apps do not receive this event when an Input Method Editor (IME) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](xref:Microsoft.UI.Input.CharacterReceivedEventArgs.Handled) to true.

## -see-also

[InputKeyboardSource.KeyDown](inputkeyboardsource_keydown.md), [InputKeyboardSource.SystemKeyUp](inputkeyboardsource_systemkeyup.md), [InputKeyboardSource.SystemKeyDown](inputkeyboardsource_systemkeydown.md)

## -examples
