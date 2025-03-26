---
-api-id: M:Microsoft.UI.Content.ChildSiteLink.Create(Microsoft.UI.Content.ContentIsland,Microsoft.UI.Composition.ContainerVisual)
-api-type: winrt method
---

# Microsoft.UI.Content.ChildSiteLink.Create(Microsoft.UI.Content.ContentIsland,Microsoft.UI.Composition.ContainerVisual)

<!--
public static Microsoft.UI.Content.ChildSiteLink Create (Microsoft.UI.Content.ContentIsland parent, Microsoft.UI.Composition.ContainerVisual placementVisual);
-->

## -description

Creates a new [**ChildSiteLink**](childsitelink.md) instance (in a disconnected and empty state).

## -parameters

### -param parent

The parent [**ContentIsland**](contentisland.md) the [**ChildSiteLink**](childsitelink.md) is associated with.

### -param placementVisual

The specified placement [**Visual**](../microsoft.ui.composition/visual.md) positions and sets the size of the instance relative to the root [**Visual**](../microsoft.ui.composition/visual.md) of the parent [**ContentIsland**](contentisland.md).

## -returns

Returns the created [**ChildSiteLink**](childsitelink.md).

## -remarks

The *parent* must be connected and created on the current thread.

The *placementVisual* must be a descendant of the root `Visual` of the parent `ContentIsland`.

## -see-also

## -examples
