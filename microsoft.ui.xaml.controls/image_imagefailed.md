---
-api-id: E:Microsoft.UI.Xaml.Controls.Image.ImageFailed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.ExceptionRoutedEventHandler ImageFailed
-->

# Microsoft.UI.Xaml.Controls.Image.ImageFailed

## -description
Occurs when there is an error associated with image retrieval or format.

## -xaml-syntax
```xaml
<Image ImageFailed="eventhandler"/>
```


## -remarks
Conditions in which this event can occur include:


+ File not found
+ Invalid (unrecognized or unsupported) file format
+ Unknown file format decoding error after upload
+ Qualified resource reload by the system
You might be able to use the [ErrorMessage](../microsoft.ui.xaml/exceptionroutedeventargs_errormessage.md) in event data to determine the nature of the failure.

ImageFailed and [ImageOpened](image_imageopened.md) are mutually exclusive. One event or the other will always fire whenever an [Image](image.md) has a [Source](image_source.md) value set or reset.

One scenario for handling ImageFailed is to set the [UriSource](../microsoft.ui.xaml.media.imaging/bitmapimage_urisource.md) of the underlying [BitmapImage](../microsoft.ui.xaml.media.imaging/bitmapimage.md) source to a different local image file. This can serve as a fallback value to display instead of empty space. For example, if you are trying to display an external image where it's possible that the source is no longer there, or for when the user has no Internet connection, you could set the [UriSource](../microsoft.ui.xaml.media.imaging/bitmapimage_urisource.md) to reference a local fallback or placeholder image that's part of your app package and is always guaranteed to be available.

When the Image element isn’t in the live visual tree, the Image element will not fire [ImageOpened](image_imageopened.md) or ImageFailed events.  If you need to receive these events while the element isn’t in the live tree, use the BitmapImage.[ImageOpened](../microsoft.ui.xaml.media.imaging/bitmapimage_imageopened.md)/[ImageFailed](../microsoft.ui.xaml.media.imaging/bitmapimage_imagefailed.md) events.


```csharp
private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e) {
    Image img = sender as Image;
    BitmapImage fallbackImage = new BitmapImage(new Uri("ms-appx:///Images/fallback.png"));
    img.Width = 100; //set to known width of this source's natural size
     //might instead want image to stretch to fill, depends on scenario
    img.Source = fallbackImage;
}
```

### Image resources

Resources can use a resource qualifier pattern to load different resources depending on device-specific scaling. Any resource that was originally retrieved for your app is automatically re-evaluated if the scaling factor changes while the app is running. In addition, when that resource is the image source for an [Image](image.md) object, then one of the source-load events ([ImageOpened](image_imageopened.md) or ImageFailed) is fired as a result of the system's action of requesting the new resource and then applying it to the [Image](image.md). The scenario where a run-time scale change might happen is if the user moves your app to a different monitor when more than one is available. As a result, [ImageOpened](image_imageopened.md) or ImageFailed events can happen at run-time when the scale change is handled, even in cases where the [Source](image_source.md) is set in XAML.

## -examples

## -see-also
