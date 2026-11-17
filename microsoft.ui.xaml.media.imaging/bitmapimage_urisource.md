---
-api-id: P:Microsoft.UI.Xaml.Media.Imaging.BitmapImage.UriSource
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri UriSource { get;  set; }
-->

# Microsoft.UI.Xaml.Media.Imaging.BitmapImage.UriSource

## -description
Gets or sets the Uniform Resource Identifier (URI) of the graphics source file that generated this [BitmapImage](bitmapimage.md).

## -xaml-syntax
```xaml
<BitmapImage UriSource="uri" />
```


## -property-value
An object describing the Uniform Resource Identifier (URI) of the graphics source file that generated this [BitmapImage](bitmapimage.md).

## -remarks
The [BaseUri](../microsoft.ui.xaml/frameworkelement_baseuri.md) property might be useful for forming the URI if you're applying an image source file to a particular [Image](../microsoft.ui.xaml.controls/image.md) element.

In low memory situations it is possible for an exception to be raised with the message "The image is unrecognized" and an HRESULT of 0x88982F60. While this exception ordinarily indicates bad data, if your app is close to its memory limit then the cause of the exception is likely to be low memory. In that case, we recommend that you free memory and try again.

When `UriSource` is an `ms-appdata:` URI, the image reads the file through a memory-mapped view and keeps the file open for as long as the **BitmapImage** is alive. Setting [Image.Source](../microsoft.ui.xaml.controls/image_source.md) to `null` does not release it; the file is released when the **BitmapImage** is released or garbage-collected. Until then, you can't overwrite or replace the file, and attempts to do so fail with a sharing violation (`0x80070020`, "the file is being used by another process").

To avoid locking the file, use one of the following. Both keep a private copy of the image bytes in memory for each live image, so they use more memory than an `ms-appdata:` URI.

- Use a `file://` URI to the same file, for example `new Uri(Path.Combine(ApplicationData.Current.LocalFolder.Path, "myImage.png"))`.
- Load the image from a stream by using [SetSourceAsync](bitmapsource_setsourceasync_1118221574.md).

## -examples

## -see-also
[Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes), [XAML images sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20images%20sample)
