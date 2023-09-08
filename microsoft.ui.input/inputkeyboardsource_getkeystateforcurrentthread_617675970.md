---
-api-id: M:Microsoft.UI.Input.InputKeyboardSource.GetKeyStateForCurrentThread(Windows.System.VirtualKey)
-api-type: winrt method
---

# Microsoft.UI.Input.InputKeyboardSource.GetKeyStateForCurrentThread(Windows.System.VirtualKey)

<!--
public static Windows.UI.Core.CoreVirtualKeyStates GetKeyStateForCurrentThread (Windows.System.VirtualKey virtualKey);
-->

## -description

Retrieves the state of the supplied virtual-key at the time of the current input message (on the current thread).

## -parameters

The virtual-key for which the state is returned.

### -param virtualKey

## -returns

The flags indicating the current state of the supplied virtual-key at the time of the current input message (on the current thread).

> [!NOTE]
> All keys support the `Locked` state (not just the standard **Caps Lock** and **Num Lock** keys).

## -remarks

## -see-also

[InputKeyboardSource.GetKeyState(Windows.System.VirtualKey)](inputkeyboardsource_getkeystate_1676715341.md), [InputKeyboardSource.GetCurrentKeyState(Windows.System.VirtualKey)](inputkeyboardsource_getcurrentkeystate_324576627.md)

## -examples
