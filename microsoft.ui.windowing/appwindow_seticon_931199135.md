---
-api-id: M:Microsoft.UI.Windowing.AppWindow.SetIcon(Microsoft.UI.IconId)
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.SetIcon(Microsoft.UI.IconId)

<!--
public void SetIcon (Microsoft.UI.IconId iconId);
-->


## -description

Sets the icon for the window, using the specified icon ID.

## -parameters

### -param iconId

The ID of the icon.

## -remarks

If you already have a handle to an icon (`HICON`) from one of the [Icon functions](/windows/win32/menurc/icon-functions) like [CreateIcon](/windows/win32/menurc/icon-functions), you can use the [GetIconIdFromIcon](/windows/windows-app-sdk/api/win32/microsoft.ui.interop/nf-microsoft-ui-interop-geticonidfromicon) interop API to get an [IconId](/windows/windows-app-sdk/api/winrt/microsoft.ui.iconid). You can then pass the `IconId` to the `SetIcon(IconId)` method to set your window icon.

## -see-also

## -examples

```
m_AppWindow.SetIcon(iconId));
```
