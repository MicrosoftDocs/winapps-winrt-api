---
-api-id: T:Microsoft.UI.Input.PhysicalKeyStatus
-api-type: winrt struct
---

# Microsoft.UI.Input.PhysicalKeyStatus

<!--
public struct PhysicalKeyStatus
-->

## -description

Specifies the possible states of a physical keyboard key.

## -struct-fields

### -field IsExtendedKey

The key is an extended key, such as the right-hand ALT and CTRL keys that appear on an Enhanced 101/102-key keyboard. See [Extended-Key Flag](/windows/win32/inputdev/about-keyboard-input#extended-key-flag) for more info.

### -field IsKeyReleased

The key moved from a pressed to a released state. See [Transition State Flag](/windows/win32/inputdev/about-keyboard-input#transition-state-flag) for more info.

### -field IsMenuKeyDown

The Alt key (represented by the [VirtualKey.Menu](/uwp/api/windows.system.virtualkey) value) is currently pressed down.

### -field RepeatCount

The number of times a key was pressed. See [Repeat Count](/windows/win32/inputdev/about-keyboard-input#repeat-count) for more info.

### -field ScanCode

The scan code for a key that was pressed. See [Scan Code](/windows/win32/inputdev/about-keyboard-input#scan-code) for more info.

### -field WasKeyDown

The key is currently pressed down. See [Previous Key-State Flag](/windows/win32/inputdev/about-keyboard-input#previous-key-state-flag) for more info.

## -remarks

The keyboard device driver receives *scan codes* from the keyboard and interprets and translates (maps) them into virtual-key codes (device-independent values defined by the system to identify the purpose of a key).

## -see-also

[CharacterReceivedEventArgs.KeyStatus](characterreceivedeventargs_keystatus.md), [KeyEventArgs.KeyStatus](keyeventargs_keystatus.md)

## -examples
