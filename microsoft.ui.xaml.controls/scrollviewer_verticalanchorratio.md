---
-api-id: P:Microsoft.UI.Xaml.Controls.ScrollViewer.VerticalAnchorRatio
-api-type: winrt property
---

<!-- Property syntax.
public double VerticalAnchorRatio { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ScrollViewer.VerticalAnchorRatio

## -description

Determines the vertical position of the ScrollViewer's *anchor point* with respect to the viewport. By default, the ScrollViewer selects an element as its [CurrentAnchor](iscrollanchorprovider_currentanchor.md) by identifying the element in its viewport nearest to the anchor point.

## -property-value

A normalized value (0.0 to 1.0). The default is 0.0.

## -remarks

A value of 0.0 represents the top-most point within the viewport. A value of 1.0 represents the bottom-most point within the viewport. A value of 0.5f represents the center-most point within the viewport.

When the value is 0.0 or 1.0, the ScrollViewer applies special behavior when the scroll position is at the start or end of the scrollable area.

## -see-also

[IScrollAnchorProvider](iscrollanchorprovider.md)

## -examples
