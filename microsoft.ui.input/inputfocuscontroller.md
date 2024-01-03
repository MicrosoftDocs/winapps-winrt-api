---
-api-id: T:Microsoft.UI.Input.InputFocusController
-api-type: winrt class
---

# Microsoft.UI.Input.InputFocusController

<!--
public sealed class InputFocusController : Microsoft.UI.Input.InputObject
-->

## -description

Represents an object that supports the handling and management of focus events on a [ContentIsland](../microsoft.ui.content/contentisland.md).

## -remarks

A ContentIsland has an underlying [HWND](/windows/win32/winmsg/about-windows) that can interact with [Win32 APIs](/windows/win32/) and receive Win32 messages (such as various input messages).

A [ContentIsland](../microsoft.ui.content/contentisland.md) *has focus* if its underlying HWND has *Win32* focus.

When A [ContentIsland](../microsoft.ui.content/contentisland.md) has focus, it will receive keyboard input messages from the system. Keyboard input events can be handled by an [InputKeyboardSource](inputkeyboardsource.md) object, which is retrieved through the [InputKeyboardSource.GetForIsland(Microsoft.UI.Content.ContentIsland)](inputkeyboardsource_getforisland_618747298.md) method.

> [!NOTE]
> For more details about Win32 focus and keyboard input see the [Keyboard Focus and Activation](/windows/win32/inputdev/about-keyboard-input#keyboard-focus-and-activation) section of the [Keyboard Input Overview](/windows/win32/inputdev/about-keyboard-input).

### Behavior when disposed

An InputFocusController is associated with a specific [ContentIsland](../microsoft.ui.content/contentisland.md). If the InputFocusController is disposed then it loses that association and all event handlers are unregistered.

If the associated [ContentIsland](../microsoft.ui.content/contentisland.md) is disposed, then the associated InputFocusController is also disposed.

For more details, see [Microsoft.UI.Input.InputObject](inputobject.md).

### Threading model

An InputFocusController can only be from the thread where it was created. Any property access or function call on a different thread will return RPC_E_WRONG_THREAD (or the equivalent projected error type).

For more details, see [Microsoft.UI.Input.InputObject](inputobject.md).

## -see-also

[FocusChangedEventArgs](focuschangedeventargs.md), [Windows (Windows and Messages)](/windows/win32/winmsg/windows)

## -examples
