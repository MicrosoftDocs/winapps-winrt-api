---
-api-id: E:Microsoft.UI.Content.ContentSite.RequestedStateChanged
-api-type: winrt event
---

# Microsoft.UI.Content.ContentSite.RequestedStateChanged

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Content.ContentSite,Microsoft.UI.Content.ContentSiteRequestedStateChangedEventArgs> RequestedStateChanged;
-->

## -description

Occurs when a [**ContentIsland**](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) makes a new request to its associated [**ContentSite**](contentsite.md).

## -remarks

The [**ContentSite**](contentsite.md) owner ([DesktopSiteBridge](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.desktopsitebridge)) can examine local properties (such as [RequestedSize](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsite.requestedsize)), decide policy, and then configure information (such as [ActualSize](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsite.actualsize)) to send to the [**ContentIsland**](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland).

## -see-also

## -examples
