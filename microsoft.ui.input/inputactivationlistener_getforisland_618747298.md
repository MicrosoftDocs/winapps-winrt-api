---
-api-id: M:Microsoft.UI.Input.InputActivationListener.GetForIsland(Microsoft.UI.Content.ContentIsland)
-api-type: winrt method
---

# Microsoft.UI.Input.InputActivationListener.GetForIsland(Microsoft.UI.Content.ContentIsland)

<!--
public static Microsoft.UI.Input.InputActivationListener GetForIsland (Microsoft.UI.Content.ContentIsland island);
-->

## -description

Retrieves an [InputActivationListener](/windows/windows-app-sdk/api/winrt/microsoft.ui.input.inputactivationlistener) object for the specified [ContentIsland](../microsoft.ui.content/contentisland.md).

## -parameters

### -param island

The [ContentIsland](../microsoft.ui.content/contentisland.md) that is handling input.

## -returns

The [InputActivationListener](/windows/windows-app-sdk/api/winrt/microsoft.ui.input.inputactivationlistener) object for the specified [ContentIsland](../microsoft.ui.content/contentisland.md), or a new InputActivationListener if one doesn't exist.

If *island* is invalid, or is owned by a different thread than the calling thread, GetForIsland returns null.

## -remarks

GetForIsland only supports content islands on the same thread as the caller.

Calling GetForIsland multiple times will return the same object each time.

In all cases there can only be a single [InputActivationListener](/windows/windows-app-sdk/api/winrt/microsoft.ui.input.inputactivationlistener) associated with a particular content island.

## -see-also

[InputActivationListenerActivationChangedEventArgs](/windows/windows-app-sdk/api/winrt/microsoft.ui.input.inputactivationlisteneractivationchangedeventargs)

## -examples
