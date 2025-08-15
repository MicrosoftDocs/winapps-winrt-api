---
-api-id: P:Microsoft.UI.Content.ContentSiteView.IsSiteVisible
-api-type: winrt property
---

# Microsoft.UI.Content.ContentSiteView.IsSiteVisible

<!--
public bool IsSiteVisible { get; }
-->

## -description

Gets the [IsSiteVisible](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsite.issitevisible) state reported by the [**ContentSite**](contentsite.md).

## -property-value

The [IsSiteVisible](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsite.issitevisible) state reported by the [**ContentSite**](contentsite.md).

## -remarks

This value is treated as a "hint" that the [**ContentSite**](contentsite.md) will not be displayed and can safely release GPU resources, such as when it's inside a minimized or hidden window.

## -see-also

[ContentIsland.IsSiteVisible](contentisland_issitevisible.md)

## -examples
