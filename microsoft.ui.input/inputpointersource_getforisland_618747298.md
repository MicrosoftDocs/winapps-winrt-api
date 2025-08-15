---
-api-id: M:Microsoft.UI.Input.InputPointerSource.GetForIsland(Microsoft.UI.Content.ContentIsland)
-api-type: winrt method
---

# Microsoft.UI.Input.InputPointerSource.GetForIsland(Microsoft.UI.Content.ContentIsland)

<!--
public static Microsoft.UI.Input.InputPointerSource GetForIsland (Microsoft.UI.Content.ContentIsland island);
-->

## -description

Retrieves an [InputPointerSource](/windows/windows-app-sdk/api/winrt/microsoft.ui.input.inputpointersource) object for the specified [ContentIsland](../microsoft.ui.content/contentisland.md).

## -parameters

### -param island

The [ContentIsland](../microsoft.ui.content/contentisland.md) that is handling input.

## -returns

The [InputPointerSource](/windows/windows-app-sdk/api/winrt/microsoft.ui.input.inputpointersource) object for the specified [ContentIsland](../microsoft.ui.content/contentisland.md), or a new InputPointerSource if one doesn't exist.

If *island* is invalid, or is owned by a different thread than the calling thread, GetForIsland returns null.

## -remarks

GetForIsland only supports content islands on the same thread as the caller.

Calling GetForIsland multiple times will return the same object each time.

In all cases there can only be a single [InputPointerSource](/windows/windows-app-sdk/api/winrt/microsoft.ui.input.inputpointersource) associated with a particular content island.

## -see-also

## -examples
