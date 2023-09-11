---
-api-id: M:Microsoft.UI.Input.InputKeyboardSource.GetKeyState(Windows.System.VirtualKey)
-api-type: winrt method
---

# Microsoft.UI.Input.InputKeyboardSource.GetKeyState(Windows.System.VirtualKey)

<!--
public Microsoft.UI.Input.VirtualKeyStates GetKeyState (Windows.System.VirtualKey virtualKey);
-->

## -description

Retrieves the state of the supplied virtual-key at the time of the input message currently being processed (which could be in the past, if the input queue contains unprocessed messages).

## -parameters

### -param virtualKey

The virtual-key for which the state is returned.

## -returns

The flags indicating the state of the supplied virtual-key at the time of the input message currently being processed

> [!NOTE]
> All keys support the `Locked` state (not just the standard **Caps Lock** and **Num Lock** keys).

## -remarks

## -see-also

[InputKeyboardSource.GetKeyStateForCurrentThread(Windows.System.VirtualKey)](inputkeyboardsource_getkeystateforcurrentthread_617675970.md), [InputKeyboardSource.GetCurrentKeyState(Windows.System.VirtualKey)](inputkeyboardsource_getcurrentkeystate_324576627.md)

## -examples
