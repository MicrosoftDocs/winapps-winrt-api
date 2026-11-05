---
-api-id: M:Microsoft.UI.Windowing.AppWindow.SetTaskbarIcon(System.String)
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.SetTaskbarIcon(System.String)

<!--
public void SetTaskbarIcon (string iconPath);
-->

## -description

Sets the icon for the taskbar using the specified icon path.

## -parameters

### -param iconPath

The path of the icon.

## -remarks

For more information about setting the icon, see [SetIcon](appwindow_seticon_348408788.md). This method works the same way, but lets you set the taskbar icon independently of the title bar icon.

Icons from existing shell links and [System.AppUserModel.RelaunchIconResource](/windows/win32/properties/props-system-appusermodel-relaunchiconresource) take precedence. In these cases, this method cannot change the taskbar icon.

## -see-also

[SetIcon](appwindow_seticon_348408788.md), [SetTitleBarIcon](appwindow_settitlebaricon_1410311439.md)

## -examples
