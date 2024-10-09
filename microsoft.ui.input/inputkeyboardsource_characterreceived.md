---
-api-id: E:Microsoft.UI.Input.InputKeyboardSource.CharacterReceived
-api-type: winrt event
---

# Microsoft.UI.Input.InputKeyboardSource.CharacterReceived

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Input.InputKeyboardSource,Microsoft.UI.Input.CharacterReceivedEventArgs> CharacterReceived;
-->

## -description

Occurs when a new character is received by the input queue.

## -remarks

Apps do not receive this event when an Input Method Editor (IME) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](/windows/windows-app-sdk/api/winrt/microsoft.ui.input.characterreceivedeventargs.handled) to true.

## -see-also

[CharacterReceivedEventArgs](/windows/windows-app-sdk/api/winrt/microsoft.ui.input.characterreceivedeventargs)

## -examples
