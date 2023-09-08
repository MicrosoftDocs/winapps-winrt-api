---
-api-id: T:Microsoft.UI.Content.ContentIsland
-api-type: winrt class
---

# Microsoft.UI.Content.ContentIsland

<!--
public class ContentIsland : Microsoft.UI.Composition.ICompositionSupportsSystemBackdrop, Microsoft.UI.IClosableNotifier, System.IDisposable
-->

## -description

A [**ContentIsland**](contentisland.md) is a self-contained *child window* (with independent input, output, layout, and accessibility handling) that is confined to the client area of its parent [**ContentSite**](contentsite.md).

## -remarks

A [**ContentIsland**](contentisland.md) is typically used to divide the [**ContentSite**](contentsite.md) into separate functional areas (similar to a [WS_CHILD style HWND](https://docs.microsoft.com/en-us/windows/win32/winmsg/window-features#child-windows)) with [Composition](../microsoft.ui.composition/microsoft_ui_composition.md)-based animations, rendering effects and interactive manipulations.

## -see-also

## -examples
