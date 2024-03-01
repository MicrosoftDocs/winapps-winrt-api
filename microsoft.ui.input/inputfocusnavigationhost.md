---
-api-id: T:Microsoft.UI.Input.InputFocusNavigationHost
-api-type: winrt class
---

# Microsoft.UI.Input.InputFocusNavigationHost

<!--
public sealed class InputFocusNavigationHost : Microsoft.UI.Input.InputObject
-->

## -description

Enables an application that hosts a [Content.ContentIsland](../microsoft.ui.content/contentisland.md) to create and respond to requests for focus movement between the hosting application and the ContentIsland.

## -remarks

An InputFocusNavigationHost can only be called on the thread that it was created on. Attempting to use it from a different thread will cause RPC_E_WRONG_THREAD to be thrown.

An InputFocusNavigationHost is associated with a specific [ContentSiteBridge](../microsoft.ui.content/icontentsitebridge.md). If the InputFocusNavigationHost is disposed then it loses that association and all event handlers are unregistered.

If the associated ContentSiteBridge is disposed, then the InputFocusNavigationHost associated with it is also implicitly disposed.

## -see-also

## -examples
