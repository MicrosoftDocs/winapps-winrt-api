---
-api-id: N:Microsoft.UI.Content
-api-type: winrt namespace
---

# Microsoft.UI.Content

## -description

Provides support for defining the structure of interactive content in a Windows app through [ContentSite](contentsite.md) (parent) and [ContentIsland](contentisland.md) (child) objects using composition-based animations, rendering effects, user input and interactions, accessibility representation, and host state changes.

## -remarks

A [ContentIsland](contentisland.md) is a self-contained *child window* (with independent input, output, layout, and accessibility handling) that is confined to the client area of its parent [ContentSite](contentsite.md). The [ContentIsland](contentisland.md) is typically used to divide the [ContentSite](contentsite.md) into separate functional areas (similar to a [WS_CHILD style HWND](https://docs.microsoft.com/en-us/windows/win32/winmsg/window-features#child-windows)) with [Composition](../microsoft.ui.composition/microsoft_ui_composition.md)-based animations, rendering effects and interactive manipulations.

## -see-also

## -examples
