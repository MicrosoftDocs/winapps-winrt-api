---
-api-id: M:Microsoft.UI.Content.ContentSite.GetIslandStateChangeDeferral
-api-type: winrt method
---

# Microsoft.UI.Content.ContentSite.GetIslandStateChangeDeferral

<!--
public Microsoft.UI.Content.ContentDeferral GetIslandStateChangeDeferral ();
-->

## -description

Retrieves a new [ContentDeferral](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentdeferral) for this [ContentSite](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsite).

## -returns

A new [ContentDeferral](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentdeferral) if the [ContentSite](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsite) is connected to a [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland). Otherwise, it returns null and does not create a deferral.

## -remarks

## -see-also

## -examples
