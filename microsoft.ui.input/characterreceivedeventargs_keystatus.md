---
-api-id: P:Microsoft.UI.Input.CharacterReceivedEventArgs.KeyStatus
-api-type: winrt property
---

# Microsoft.UI.Input.CharacterReceivedEventArgs.KeyStatus

<!--
public Microsoft.UI.Input.PhysicalKeyStatus KeyStatus { get; }
-->

## -description

Gets the status of the physical key press that raised the character-received event.

## -property-value

The status of the physical key press that raised the character-received event.

## -remarks

Apps do not receive this event when an [Input Method Editor (IME)](/windows/apps/design/input/input-method-editors) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](characterreceivedeventargs_handled.md) to true.

## -see-also

## -examples
