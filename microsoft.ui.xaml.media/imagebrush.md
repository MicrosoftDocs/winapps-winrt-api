---
-api-id: T:Microsoft.UI.Xaml.Media.ImageBrush
-api-type: winrt class
---

<!-- Class syntax.
public class ImageBrush : Windows.UI.Xaml.Media.TileBrush, Windows.UI.Xaml.Media.IImageBrush
-->

# Microsoft.UI.Xaml.Media.ImageBrush

## -description
Paints an area with an image. The image source is typically obtained from file formats such as Joint Photographic Experts Group (JPEG).

## -xaml-syntax
```xaml
<ImageBrush .../>
```

## -remarks
An ImageBrush is a type of [brush](brush.md) that defines its content as an image which can be optionally stretched and aligned. Uses for an ImageBrush include decorative effects for text, or image backgrounds for controls or layout containers.

It's useful to use an ImageBrush instead of an [Image control](/uwp/api/Windows.UI.Xaml.Controls.Image) in two main  scenarios:

1. You want to paint a non-rectangular area such as an ellipse or border with an image
2. You want to use a single ImageBrush to paint multiple areas or UIElements with the same image, which is more efficient than using multiple [Image](/uwp/api/Windows.UI.Xaml.Controls.Image) controls


If you define an ImageBrush using code, use the default constructor, then set [ImageBrush.ImageSource](imagebrush_imagesource.md). This requires a [BitmapImage](../microsoft.ui.xaml.media.imaging/bitmapimage.md) (not a Uniform Resource Identifier (URI)) in code. If your source is a stream, use the [SetSourceAsync](../microsoft.ui.xaml.media.imaging/bitmapsource_setsourceasync_1118221574.md) method to initialize the value. If your source is a Uniform Resource Identifier (URI), which includes content in your app that uses the **ms-appx** or **ms-resource** schemes, use the [BitmapImage](../microsoft.ui.xaml.media.imaging/bitmapimage_bitmapimage_843413386.md) constructor that takes a Uniform Resource Identifier (URI). You might also consider handling the [ImageOpened](imagebrush_imageopened.md) event if there are any timing issues with retrieving or decoding the image source, where you might need alternate content to display until the image source is available. See [XAML images sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20images%20sample) for example code.

> [!NOTE]
> You can use automatic handling for accessing unqualified resources with current scale and culture qualifiers, or you can use [ResourceManager](/uwp/api/windows.applicationmodel.resources.core.resourcemanager) and [ResourceMap](/uwp/api/windows.applicationmodel.resources.core.resourcemap) with qualifiers for culture and scale to obtain the resources directly. For more info see [Resource management system](/previous-versions/windows/apps/jj552947(v=win.10)).

The [Stretch](tilebrush_stretch.md) property is important for how the image is applied when used as a brush. Some images look good when stretched as applied to a particular [Brush](brush.md) property with the **Fill** behavior whereas other images do not stretch or scale well and might require a value of **None** or **Uniform** for [Stretch](tilebrush_stretch.md). Experiment with different values for [Stretch](tilebrush_stretch.md) to see which behavior looks best when applied to the UI.

### Image sources and scaling

You should create your image sources at several recommended sizes, to ensure that your app looks great when Windows 8 scales it. When specifying an [ImageSource](imagebrush_imagesource.md) for an ImageBrush, you can use a naming convention that will automatically reference the correct resource for the current scaling. For specifics of the naming convention and more info, see [Quickstart: Using file or image resources](/previous-versions/windows/apps/hh965325(v=win.10)).

For more info on how to design for scaling, see [UX guidelines for layout and scaling](https://developer.microsoft.com/windows/design).

## -examples
This XAML example shows how to set the [Foreground](../microsoft.ui.xaml.controls/textblock_foreground.md) property of a [TextBlock](../microsoft.ui.xaml.controls/textblock.md) to an ImageBrush, whose image is used as the fill for the [TextBlock](../microsoft.ui.xaml.controls/textblock.md)-rendered text.



[!code-xaml[imaging_ovw_painting_with_an_image](../microsoft.ui.xaml.media/code/imaging_ovw_painting_with_an_image/csharp/Page.xaml#Snippetimaging_ovw_painting_with_an_image)]

<img src="images/shrubbery.gif" alt="An ImageBrush applied to text" />

## -see-also
[TileBrush](tilebrush.md), [Image](../microsoft.ui.xaml.controls/image.md), [Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes), [XAML vector-based drawing sample (see Scenario 2)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample)
