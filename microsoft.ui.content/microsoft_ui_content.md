---
-api-id: N:Microsoft.UI.Content
-api-type: winrt namespace
---

# Microsoft.UI.Content

## -description

Provides support for defining the structure of interactive content in a Windows app through <xref:Microsoft.UI.Content.ContentSite> (parent) and <xref:Microsoft.UI.Content.ContentIsland> (child) objects using composition-based animations, rendering effects, user input and interactions, accessibility representation, and host state changes.

## -remarks

A <xref:Microsoft.UI.Content.ContentIsland> is a self-contained piece of content with independent input, output, layout, and accessibility that is connected to a parent <xref:Microsoft.UI.Content.ContentSite>. The <xref:Microsoft.UI.Content.ContentIsland> supports <xref:Microsoft.UI.Composition>-based animations, rendering effects, and interactive manipulations.

These self-contained pieces of content can be composed into a "scene". Conceptually they are equivalent to [*child windows*](/windows/win32/winmsg/window-features#child-windows) because they allow the scene to be subdivided.

## -see-also

## -examples
