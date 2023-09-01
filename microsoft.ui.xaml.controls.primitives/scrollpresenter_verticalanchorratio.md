---
-api-id: P:Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalAnchorRatio
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.Primitives.ScrollPresenter.VerticalAnchorRatio

<!--
public double VerticalAnchorRatio { get; set; }
-->


## -description

Determines the vertical position of the `ScrollPresenter`'s *anchor point* with respect to the viewport. By default, the `ScrollPresenter` selects an element as its [CurrentAnchor](scrollpresenter_currentanchor.md) by identifying the element in its viewport nearest to the anchor point.

## -property-value

A normalized value (0.0 to 1.0). The default is 0.0.

## -remarks

A value of 0.0 represents the top-most point within the viewport. A value of 1.0 represents the bottom-most point within the viewport. A value of 0.5f represents the center-most point within the viewport.

When the value is 0.0 or 1.0, the `ScrollPresenter` applies special behavior when the scroll position is at the start or end of the scrollable area.


## -see-also

## -examples


