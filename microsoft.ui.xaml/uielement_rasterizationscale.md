---
-api-id: P:Microsoft.UI.Xaml.UIElement.RasterizationScale
-api-type: winrt property
---

# Microsoft.UI.Xaml.UIElement.RasterizationScale

<!--
public double RasterizationScale { get; set; }
-->

## -description

Gets or sets an extra scale factor to use when rendering the element's content.

## -property-value

A value that represents the additional scale factor to use while rendering. The default is 1.0.

## -remarks

Use this property when you want a specific element to render its shapes, images, text, or media at a higher resolution than its normal layout size.

This property does not report the current display scale for the element. Instead, it is a per-element rendering multiplier that you can set in addition to the scale that XAML already applies for the current display.

For example, you can set a `TextBlock` to render at a 2x rasterization scale before running a scale animation. This helps the text stay crisp at its final animated size.

The default value is `1.0`, which means no extra per-element rasterization scaling is applied. In that case, the element renders using only the scale already determined by the XAML environment.

> [!IMPORTANT]
> To determine the display scale factor for an element, use the [XamlRoot.RasterizationScale](xamlroot_rasterizationscale.md) property instead. `XamlRoot.RasterizationScale` is a read-only value that describes the current view-to-physical-pixel scale for the XAML tree, while `UIElement.RasterizationScale` is an optional extra scale factor that you set on an individual element.


## -see-also

## -examples
