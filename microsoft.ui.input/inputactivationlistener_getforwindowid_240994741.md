---
-api-id: M:Microsoft.UI.Input.InputActivationListener.GetForWindowId(Microsoft.UI.WindowId)
-api-type: winrt method
---

# Microsoft.UI.Input.InputActivationListener.GetForWindowId(Microsoft.UI.WindowId)

<!--
public static Microsoft.UI.Input.InputActivationListener GetForWindowId (Microsoft.UI.WindowId windowId);
-->

## -description

Retrieves a [InputActivationListener](/windows/windows-app-sdk/api/winrt/microsoft.ui.input.inputactivationlistener) object for the specified top-level window.

## -parameters

### -param windowId

The window identifier.

## -returns

A [InputActivationListener](/windows/windows-app-sdk/api/winrt/microsoft.ui.input.inputactivationlistener) object for the specified top-level window, or a new InputActivationListener if one doesn't exist.

If *windowId* is invalid, is owned by a different thread than the calling thread, or is a child window, GetForWindowId returns null.

## -remarks

**GetForWindowId** only supports top-level windows on the same thread as the caller.

Calling GetForWindowId multiple times will return the same object each time.

In all cases there can only be a single [InputActivationListener](/windows/windows-app-sdk/api/winrt/microsoft.ui.input.inputactivationlistener) associated with a particular Window ID.

## -see-also

[InputActivationListenerActivationChangedEventArgs](inputactivationlisteneractivationchangedeventargs.md)

## -examples
