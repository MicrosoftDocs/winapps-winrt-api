---
-api-id: P:Microsoft.UI.Content.ContentIsland.IsConnected
-api-type: winrt property
---

# Microsoft.UI.Content.ContentIsland.IsConnected

<!--
public bool IsConnected { get; }
-->

## -description

Gets whether this [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) is connected to a [ContentSite](contentsite.md).

## -property-value

True, if this [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) is connected to a [ContentSite](contentsite.md); otherwise, false. The default is true.

## -remarks

A [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) must be connected to a [ContentSite](contentsite.md) to:

- Convert coordinates by calling one of the [ContentCoordinateConverter](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentcoordinateconverter) methods.
- Retrieve the automation host provider by calling [GetAutomationHostProvider](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland.getautomationhostprovider).

## -see-also

## -examples
