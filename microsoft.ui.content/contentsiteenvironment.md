---
-api-id: T:Microsoft.UI.Content.ContentSiteEnvironment
-api-type: winrt class
---

# Microsoft.UI.Content.ContentSiteEnvironment

<!--
public class ContentSiteEnvironment
-->

## -description

Provides information about the [ContentSite](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsite) environment to an associated [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland).

## -remarks

The [ContentIslandEnvironment](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentislandenvironment) is configured by the settings specified in a [ContentSiteEnvironment](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsiteenvironment).

Each [ContentSite](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsite) has a [ContentSiteEnvironment](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsiteenvironment) that manages the [ContentIslandEnvironment](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentislandenvironment) settings. An [IContentSiteBridge](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.icontentsitebridge) implementation is responsible for deciding when to propagate information from the [ContentSiteEnvironment](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsiteenvironment) to the [ContentIslandEnvironment](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentislandenvironment). This enables the [IContentSiteBridge](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.icontentsitebridge) to determine policy how the environment is represented to the [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland).

## -see-also

## -examples
