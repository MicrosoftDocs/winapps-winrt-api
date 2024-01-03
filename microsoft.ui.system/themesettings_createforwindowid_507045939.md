---
-api-id: M:Microsoft.UI.System.ThemeSettings.CreateForWindowId(Microsoft.UI.WindowId)
-api-type: winrt method
---

# Microsoft.UI.System.ThemeSettings.CreateForWindowId(Microsoft.UI.WindowId)

<!--
public static Microsoft.UI.System.ThemeSettings CreateForWindowId (Microsoft.UI.WindowId windowId);
-->

## -description

Creates a [ThemeSettings](themesettings.md) object that will provide theme information for the given *WindowId*.

## -parameters

### -param windowId

The [WindowId](../microsoft.ui/windowid.md) to use when getting theme information.

## -returns

A [ThemeSettings](themesettings.md) object that will provide the theme information.

## -remarks

The given *WindowId* must represent a window that:

* Is a top-level window
* **AND** is on the same process and thread as the caller

For example, you can get a *WindowId* from the [ContentIslandEnvironment.AppWindowId](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentislandenvironment.appwindowid) property. You can get a [ContentIslandEnvironment](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentislandenvironment) object from a [XamlRoot](../microsoft.ui.xaml/xamlroot.md) object.

## -see-also

[ThemeSettings](themesettings.md), [WindowId](../microsoft.ui/windowid.md), [XamlRoot](../microsoft.ui.xaml/xamlroot.md), [ContentIslandEnvironment](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentislandenvironment), [ContentIslandEnvironment.AppWindowId](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentislandenvironment.appwindowid)

## -examples
