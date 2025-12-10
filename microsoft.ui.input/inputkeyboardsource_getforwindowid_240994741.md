---
-api-id: M:Microsoft.UI.Input.InputKeyboardSource.GetForWindowId(Microsoft.UI.WindowId)
-api-type: winrt method
---

# Microsoft.UI.Input.InputKeyboardSource.GetForWindowId(Microsoft.UI.WindowId)

<!--
public static Microsoft.UI.Input.InputKeyboardSource GetForWindowId (Microsoft.UI.WindowId windowId);
-->

## -description

Retrieves an [InputKeyboardSource](inputkeyboardsource.md) object for the specified top-level window.

## -parameters

### -param windowId

The window identifier.

## -returns

An [InputKeyboardSource](inputkeyboardsource.md) object for the specified top-level window, or a new [InputKeyboardSource](inputkeyboardsource.md) if one doesn't exist.

If *windowId* is invalid, is owned by a different thread than the calling thread, or is a child window, **GetForWindowId** returns null.

## -remarks

**GetForWindowId** only supports top-level windows on the same thread as the caller.

Calling **GetForWindowId** multiple times will return the same object each time.

In all cases there can only be a single [InputKeyboardSource](inputkeyboardsource.md) associated with a particular Window ID.

## -see-also

## -examples
