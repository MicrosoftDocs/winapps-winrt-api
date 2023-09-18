---
-api-id: T:Microsoft.UI.Content.ContentIsland
-api-type: winrt class
---

# Microsoft.UI.Content.ContentIsland

<!--
public class ContentIsland : Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop, Microsoft.UI.IClosableNotifier, System.IDisposable
-->

## -description

A <xref:Microsoft.UI.Content.ContentIsland> is a self-contained *child window* (with independent input, output, layout, and accessibility handling) that is confined to the client area of its parent <xref:Microsoft.UI.Content.ContentSite>.

## -remarks

A <xref:Microsoft.UI.Content.ContentIsland> is typically used to divide the <xref:Microsoft.UI.Content.ContentSite> into separate functional areas (similar to a [WS_CHILD style HWND](https://docs.microsoft.com/en-us/windows/win32/winmsg/window-features#child-windows)) with <xref:Microsoft.UI.Composition>-based animations, rendering effects and interactive manipulations.

## -see-also

## -examples
