---
-api-id: P:Microsoft.UI.Input.FocusNavigationRequest.HintRect
-api-type: winrt property
---

# Microsoft.UI.Input.FocusNavigationRequest.HintRect

<!--
public System.Nullable<Windows.Foundation.Rect> HintRect { get; }
-->

## -description

Gets the bounding rectangle used to identify the focus candidates most likely to receive navigation focus.

## -property-value

The bounding rectangle used to identify the focus candidates most likely to receive navigation focus.

## -remarks

Coordinates are in the context of where focus is moving from. To convert the HintRect to the coordinate space that focus is moving to, use a coordinate converter ([ContentIsland.CoordinateConverter](../microsoft.ui.content/contentisland_coordinateconverter.md), [ContentSite.CoordinateConverter](../microsoft.ui.content/contentsite_coordinateconverter.md), [ContentSiteView.CoordinateConverter](../microsoft.ui.content/contentsiteview_coordinateconverter.md)).

The caller should create the FocusNavigationRequest with the HintRect in its local space, and have the called context convert the HintRect to its local space. HintRect will be null if the caller does not specify a HintRect.

## -see-also

## -examples
