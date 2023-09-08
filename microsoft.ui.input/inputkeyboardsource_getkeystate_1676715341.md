---
-api-id: M:Microsoft.UI.Input.InputKeyboardSource.GetKeyState(Windows.System.VirtualKey)
-api-type: winrt method
---

# Microsoft.UI.Input.InputKeyboardSource.GetKeyState(Windows.System.VirtualKey)

<!--
public Microsoft.UI.Input.VirtualKeyStates GetKeyState (Windows.System.VirtualKey virtualKey);
-->

## -description

Get the state of the supplied virtual-key at the time of the current input message.

## -parameters

### -param virtualKey

The virtual-key for which the state is returned.

## -returns

The flags indicating the current state of the supplied virtual-key at the time of the current input message.

> [!NOTE]
> All keys support the `Locked` state (not just the standard **Caps Lock** and **Num Lock** keys).

## -remarks

## -see-also

[InputKeyboardSource.GetKeyStateForCurrentThread(Windows.System.VirtualKey)](inputkeyboardsource_getkeystateforcurrentthread_617675970.md), [InputKeyboardSource.GetCurrentKeyState(Windows.System.VirtualKey)](inputkeyboardsource_getcurrentkeystate_324576627.md)

## -examples
