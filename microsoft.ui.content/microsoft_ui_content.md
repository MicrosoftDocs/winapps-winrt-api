---
-api-id: N:Microsoft.UI.Content
-api-type: winrt namespace
---

# Microsoft.UI.Content

## -description

Provides support for defining the structure of interactive content in a Windows app through [ContentSite](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsite) (parent) and [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) (child) objects using composition-based animations, rendering effects, user input and interactions, accessibility representation, and host state changes.

## -remarks

A [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) is a self-contained piece of content with independent input, output, layout, and accessibility that is connected to a parent [ContentSite](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentsite). The [ContentIsland](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentisland) supports [Composition](/windows/windows-app-sdk/api/winrt/microsoft.ui.composition)-based animations, rendering effects, and interactive manipulations.

These self-contained pieces of content can be composed into a "scene". Conceptually they are equivalent to [*child windows*](/windows/win32/winmsg/window-features#child-windows) because they allow the scene to be subdivided.

## -see-also

## -examples
