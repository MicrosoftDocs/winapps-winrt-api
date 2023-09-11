---
-api-id: P:Microsoft.UI.Input.CharacterReceivedEventArgs.Handled
-api-type: winrt property
---

# Microsoft.UI.Input.CharacterReceivedEventArgs.Handled

<!--
public bool Handled { get; set; }
-->

## -description

Gets or sets whether the [InputKeyboardSource.CharacterReceived](inputkeyboardsource_characterreceived.md) event was handled.

## -property-value

True, if the event has been handled by the appropriate delegate. False if it has not been handled.

## -remarks

Apps do not receive this event when an [Input Method Editor (IME)](/windows/apps/design/input/input-method-editors) is enabled. The Input Method Editor (IME) handles all keyboard input and sets [Handled](characterreceivedeventargs_handled.md) to true.

## -see-also

## -examples
