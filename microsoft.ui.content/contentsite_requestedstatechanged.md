---
-api-id: E:Microsoft.UI.Content.ContentSite.RequestedStateChanged
-api-type: winrt event
---

# Microsoft.UI.Content.ContentSite.RequestedStateChanged

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Content.ContentSite,Microsoft.UI.Content.ContentSiteRequestedStateChangedEventArgs> RequestedStateChanged;
-->

## -description

Occurs when a <xref:Microsoft.UI.Content.ContentIsland> makes a new request to its associated <xref:Microsoft.UI.Content.ContentSite>.

## -remarks

The ContentSite owner (<xref:Microsoft.UI.Content.DesktopSiteBridge>) can examine local properties (such as <xref:Microsoft.UI.Content.ContentSite.RequestedSize>), decide policy, and then configure information (such as ActualSize) to send to the ContentIsland.

## -see-also

## -examples
