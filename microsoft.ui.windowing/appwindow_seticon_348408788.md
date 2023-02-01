---
-api-id: M:Microsoft.UI.Windowing.AppWindow.SetIcon(System.String)
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.SetIcon(System.String)

<!--
public void SetIcon (string iconPath);
-->


## -description

Sets the icon for the window, using the specified icon path.

## -parameters

### -param iconPath

The path of the icon.

## -remarks

The SetIcon(String) method works only with .ico files. The string you pass to this method is the fully qualified path to the .ico file.

## -see-also

[Title bar customization](/windows/apps/develop/title-bar?tabs=wasdk#icon-and-system-menu)

## -examples

```
m_AppWindow.SetIcon("iconPath/iconName.ico");
```
