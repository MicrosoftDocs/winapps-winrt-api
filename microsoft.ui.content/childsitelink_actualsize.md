---
-api-id: P:Microsoft.UI.Content.ChildSiteLink.ActualSize
-api-type: winrt property
---

# Microsoft.UI.Content.ChildSiteLink.ActualSize

<!--
public System.Numerics.Vector2 ActualSize { get; set; }
-->

## -description

Gets or sets the effective [**Size**](../microsoft.ui.composition/visual_size.md) of the placement [**Visual**](../microsoft.ui.composition/visual.md) relative to the root [**Visual**](../microsoft.ui.composition/visual.md) of the parent [**ContentIsland**](contentisland.md).

## -property-value

The effective [**Size**](../microsoft.ui.composition/visual_size.md) of the placement [**Visual**](../microsoft.ui.composition/visual.md) relative to the root [**Visual**](../microsoft.ui.composition/visual.md) of the parent [**ContentIsland**](contentisland.md).

## -remarks

This property must be kept in sync with the effective [**Size**](../microsoft.ui.composition/visual_size.md) of the placement [**Visual**](../microsoft.ui.composition/visual.md) relative to the root [**Visual**](../microsoft.ui.composition/visual.md) of the parent [**ContentIsland**](contentisland.md), otherwise the conversions performed by the [**ContentCoordinateConverter**](contentcoordinateconverter.md) may not be accurate.

## -see-also

## -examples
