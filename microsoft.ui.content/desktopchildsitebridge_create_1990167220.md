---
-api-id: M:Microsoft.UI.Content.DesktopChildSiteBridge.Create(Microsoft.UI.Composition.Compositor,Microsoft.UI.WindowId)
-api-type: winrt method
---

# Microsoft.UI.Content.DesktopChildSiteBridge.Create(Microsoft.UI.Composition.Compositor,Microsoft.UI.WindowId)

<!--
public static Microsoft.UI.Content.DesktopChildSiteBridge Create (Microsoft.UI.Composition.Compositor compositor, Microsoft.UI.WindowId parentWindowId);
-->

## -description

Creates a new <xref:Microsoft.UI.Content.DesktopChildSiteBridge> as a child of the specified parent Win32 HWND.

## -parameters

### -param compositor

The compositor used to manage the session between the <xref:Microsoft.UI.Content.DesktopChildSiteBridge> and the <xref:Microsoft.UI.Content.ContentSite>. This must be associated with the current thread.

### -param parentWindowId

The window identifier. This window must be of type WS_OVERLAPPED, WS_POPUP or WS_CHILD, which can have any number of children.

## -returns

A new <xref:Microsoft.UI.Content.DesktopChildSiteBridge>.

## -remarks

## -see-also

## -examples
