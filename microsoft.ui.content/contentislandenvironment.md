---
-api-id: T:Microsoft.UI.Content.ContentIslandEnvironment
-api-type: winrt class
---

# Microsoft.UI.Content.ContentIslandEnvironment

<!--
public class ContentIslandEnvironment
-->

## -description

Provides general environment information to a [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland).

## -remarks

Each [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) is associated with a unique [ContentIslandEnvironment](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentislandenvironment) object that is not shared between multiple [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) objects. However, information contained within a [ContentIslandEnvironment](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentislandenvironment), such as [AppWindowId](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsiteenvironment.appwindowid), can have the same value between different [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) objects in the same top level window.

## -see-also

## -examples
