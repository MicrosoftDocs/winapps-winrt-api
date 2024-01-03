---
-api-id: T:Microsoft.UI.Input.VirtualKeyStates
-api-type: winrt enum
---

# Microsoft.UI.Input.VirtualKeyStates

<!--
public enum VirtualKeyStates
-->

## -description

Specifies the possible states of a virtual-key.

## -enum-fields

### -field None: 0

The key is up or in no specific state.

### -field Down: 1

The key is pressed down.

### -field Locked: 2

The key is in a toggled or modified state (for example, Caps Lock).

> [!NOTE]
> All keys support the Locked state (not just the standard Caps Lock and Num Lock keys).

## -remarks

The keyboard device driver receives *scan codes* from the keyboard and interprets and translates (maps) them into virtual-key codes (device-independent values defined by the system to identify the purpose of a key).

## -see-also

[InputKeyboardSource.GetCurrentKeyState(Windows.System.VirtualKey)](inputkeyboardsource_getcurrentkeystate_324576627.md), [InputKeyboardSource.GetKeyState(Windows.System.VirtualKey)](inputkeyboardsource_getkeystate_1676715341.md), [InputKeyboardSource.GetKeyStateForCurrentThread(Windows.System.VirtualKey)](inputkeyboardsource_getkeystateforcurrentthread_617675970.md), [KeyboardInput.GetKeyStateForCurrentThread(Windows.System.VirtualKey)](keyboardinput_getkeystateforcurrentthread_617675970.md)

## -examples
