---
-api-id: P:Microsoft.UI.Content.ContentSiteView.IsSiteVisible
-api-type: winrt property
---

# Microsoft.UI.Content.ContentSiteView.IsSiteVisible

<!--
public bool IsSiteVisible { get; }
-->

## -description

Gets the [IsSiteVisible](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsite.issitevisible) state reported by the [ContentSite](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsite).

## -property-value

The [IsSiteVisible](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsite.issitevisible) state reported by the [ContentSite](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsite).

## -remarks

This value is treated as a "hint" that the [ContentSite](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsite) will not be displayed and can safely release GPU resources, such as when it's inside a minimized or hidden window.

## -see-also

[ContentIsland.IsSiteVisible](contentisland_issitevisible.md)

## -examples
