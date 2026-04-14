---
-api-id: P:Microsoft.UI.Xaml.UIElement.RasterizationScale
-api-type: winrt property
---

# Microsoft.UI.Xaml.UIElement.RasterizationScale

<!--
public double RasterizationScale { get; set; }
-->

## -description

Gets a value that represents an extra scale factor to be used when rendering shapes, images, text, or media, usually to render at a higher resolution than normal.

## -property-value

A value that represents the additional scale factor to use while rendering. The default is 1.0.

## -remarks

The value of this property is an extra scale factor to be used when rendering shapes, images, text, or media. It is usually applied to render at a higher resolution than normal. 

For example, it can be used to have a `TextBlock` render at a 2x scale before running a scale animation. This ensures the text is rendered crisply at its final scale value during the animation.

> [!IMPORTANT]
> To determine the display scale factor for an element, use the [XamlRoot.RasterizationScale](xamlroot_rasterizationscale.md) property instead.


## -see-also

## -examples
