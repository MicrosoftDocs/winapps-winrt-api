---
-api-id: P:Microsoft.UI.Xaml.Controls.ScrollView.VerticalAnchorRatio
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.ScrollView.VerticalAnchorRatio

<!--
public double VerticalAnchorRatio { get; set; }
-->

## -description

Determines the vertical position of the `ScrollView`'s *anchor point* with respect to the viewport. By default, the `ScrollView` selects an element as its [CurrentAnchor](iscrollanchorprovider_currentanchor.md) by identifying the element in its viewport nearest to the anchor point.

## -property-value

A normalized value (0.0 to 1.0). The default is 0.0.

## -remarks

A value of 0.0 represents the top-most point within the viewport. A value of 1.0 represents the bottom-most point within the viewport. A value of 0.5f represents the center-most point within the viewport.

When the value is 0.0 or 1.0, the `ScrollView` applies special behavior when the scroll position is at the start or end of the scrollable area.

## -see-also

[IScrollAnchorProvider](iscrollanchorprovider.md)

## -examples
