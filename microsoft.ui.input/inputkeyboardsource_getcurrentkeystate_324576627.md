---
-api-id: M:Microsoft.UI.Input.InputKeyboardSource.GetCurrentKeyState(Windows.System.VirtualKey)
-api-type: winrt method
---

# Microsoft.UI.Input.InputKeyboardSource.GetCurrentKeyState(Windows.System.VirtualKey)

<!--
public Microsoft.UI.Input.VirtualKeyStates GetCurrentKeyState (Windows.System.VirtualKey virtualKey);
-->

## -description

Retrieves the state of the supplied virtual-key at the current time (which could be after the input message currently being processed, if the input queue contains unprocessed messages).

## -parameters

### -param virtualKey

The virtual-key for which the state is returned.

## -returns

The flags indicating the current state of the supplied virtual-key currently reported by the keyboard device.

## -remarks

When handling a [KeyDown](inputkeyboardsource_keydown.md) event, this method might report that the key state is `None` instead of `Down` if the [KeyUp](inputkeyboardsource_systemkeyup.md) event is already in the message queue.

> [!NOTE]
> All keys support the `Locked` state (not just the standard **Caps Lock** and **Num Lock** keys).

## -see-also

[InputKeyboardSource.GetKeyStateForCurrentThread(Windows.System.VirtualKey)](inputkeyboardsource_getkeystateforcurrentthread_617675970.md), [InputKeyboardSource.GetKeyState(Windows.System.VirtualKey)](inputkeyboardsource_getkeystate_1676715341.md)

## -examples
