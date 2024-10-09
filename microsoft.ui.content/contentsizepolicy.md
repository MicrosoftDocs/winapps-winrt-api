---
-api-id: T:Microsoft.UI.Content.ContentSizePolicy
-api-type: winrt enum
---

# Microsoft.UI.Content.ContentSizePolicy

<!--
public enum ContentSizePolicy
-->

## -description

Specifies the supported resizing capabilities between a [DesktopChildSiteBridge](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.desktopchildsitebridge) and its parent Win32 HWND.

## -enum-fields

### -field None: 0

No resizing behavior.

### -field ResizeContentToParentWindow: 1

[DesktopChildSiteBridge](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.desktopchildsitebridge) HWND is resized to the parent HWND client area.

### -field ResizeParentWindowToContent: 2

Parent HWND client area is resized to the [DesktopChildSiteBridge](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.desktopchildsitebridge) HWND size. Uses <xref:NF:winuser.AdjustWindowRect> to account for a potential non-client area in the parent HWND.

## -remarks

## -see-also

[DesktopChildSiteBridge.ResizePolicy](desktopchildsitebridge_resizepolicy.md)

## -examples
