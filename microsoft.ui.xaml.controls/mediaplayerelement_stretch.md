---
-api-id: P:Microsoft.UI.Xaml.Controls.MediaPlayerElement.Stretch
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.MediaPlayerElement.Stretch

<!--
public Microsoft.UI.Xaml.Media.Stretch Stretch { get; set; }
-->


## -description
Gets or sets a value that describes how an [MediaPlayerElement](mediaplayerelement.md) should be stretched to fill the destination rectangle.


## -xaml-syntax
```xaml
<MediaPlayerElement Stretch="stretchMemberName" />
```


## -xaml-values
<dl><dt>stretchMemberName</dt><dd>stretchMemberNameA named constant of the Stretch enumeration, such as Fill.</dd>
</dl>
## -property-value
A value of the [Stretch](/uwp/api/windows.ui.xaml.media.stretch) enumeration that specifies how the source visual media is rendered. The default value is **Uniform**.

## -remarks
Here's what the [Stretch](/uwp/api/windows.ui.xaml.media.stretch) values represent for [MediaPlayerElement](mediaplayerelement.md) content:
+ **None**: The original size of the content is preserved.
+ **Fill**: The content is resized to fill the destination dimensions. The aspect ratio of the video is not preserved.
+ **UniformToFill**: Uniformly stretches the [MediaPlayerElement](mediaplayerelement.md) to fill the available layout space while preserving the aspect ratio of the content. If the aspect ratio of the destination rectangle differs from the source, the source content is clipped to fit the destination dimensions.
+ **Uniform**: Uniformly stretches the [MediaPlayerElement](mediaplayerelement.md) to fill the layout space while preserve the aspect ratio of the image. This will ensure that the entire image is displayed, undistorted and not cropped. This may result in letterboxing or pillarboxing on the top or sides of the image, depending on the aspect ratio of the content.

## -see-also

## -examples


