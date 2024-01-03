---
-api-id: P:Microsoft.UI.Input.CharacterReceivedEventArgs.KeyCode
-api-type: winrt property
---

# Microsoft.UI.Input.CharacterReceivedEventArgs.KeyCode

<!--
public uint KeyCode { get; }
-->

## -description

Gets the virtual-key code of the character received by the input queue.

## -property-value

The virtual-key code of the character received by the input queue.

## -remarks

Apps do not receive this event when an [Input Method Editor (IME)](/windows/apps/design/input/input-method-editors) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](characterreceivedeventargs_handled.md) to true.

## -see-also

## -examples
