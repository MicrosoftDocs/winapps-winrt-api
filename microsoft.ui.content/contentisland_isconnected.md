---
-api-id: P:Microsoft.UI.Content.ContentIsland.IsConnected
-api-type: winrt property
---

# Microsoft.UI.Content.ContentIsland.IsConnected

<!--
public bool IsConnected { get; }
-->

## -description

Gets whether this [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content/contentisland) is connected to a [ContentSite](/windows/windows-app-sdk/api/winrt/microsoft.ui.content/contentsite).

## -property-value

True, if this [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content/contentisland) is connected to a [ContentSite](/windows/windows-app-sdk/api/winrt/microsoft.ui.content/contentsite); otherwise, false. The default is true.

## -remarks

A [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content/contentisland) must be connected to a [ContentSite](/windows/windows-app-sdk/api/winrt/microsoft.ui.content/contentsite) to:

- Convert coordinates by calling one of the [ContentCoordinateConverter](/windows/windows-app-sdk/api/winrt/microsoft.ui.content/contentcoordinateconverter) methods.
- Retrieve the automation host provider by calling [GetAutomationHostProvider](/windows/windows-app-sdk/api/winrt/microsoft.ui.content/contentisland_getautomationhostprovider_2108700090).

## -see-also

## -examples
