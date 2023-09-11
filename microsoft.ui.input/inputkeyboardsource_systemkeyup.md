---
-api-id: E:Microsoft.UI.Input.InputKeyboardSource.SystemKeyUp
-api-type: winrt event
---

# Microsoft.UI.Input.InputKeyboardSource.SystemKeyUp

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Input.InputKeyboardSource,Microsoft.UI.Input.KeyEventArgs> SystemKeyUp;
-->

## -description

Occurs when the user releases a key that was pressed when the ALT key was also pressed.

## -remarks

Apps do not receive this event when an Input Method Editor (IME) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](xref:Microsoft.UI.Input.CharacterReceivedEventArgs.Handled) to true.

## -see-also

[InputKeyboardSource.SystemKeyDown](inputkeyboardsource_systemkeydown.md), [InputKeyboardSource.KeyUp](inputkeyboardsource_keyup.md), [InputKeyboardSource.SystemKeyDown](inputkeyboardsource_systemkeydown.md)

## -examples
