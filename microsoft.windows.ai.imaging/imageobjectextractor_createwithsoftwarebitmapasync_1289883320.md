---
-api-id: M:Microsoft.Windows.AI.Imaging.ImageObjectExtractor.CreateWithSoftwareBitmapAsync(Windows.Graphics.Imaging.SoftwareBitmap)
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.ImageObjectExtractor.CreateWithSoftwareBitmapAsync(Windows.Graphics.Imaging.SoftwareBitmap)

<!--
public static Windows.Foundation.IAsyncOperation<Microsoft.Windows.AI.Imaging.ImageObjectExtractor> CreateWithSoftwareBitmapAsync (Windows.Graphics.Imaging.SoftwareBitmap softwareBitmap);
-->

## -description

Asynchronously creates an `ImageObjectExtractor` using an uncompressed bitmap.

## -parameters

### -param softwareBitmap

The uncompressed bitmap image from which to extract artifacts.

## -returns

An asynchronous operation object which, when it completes, contains the `ImageObjectExtractor`.

## -remarks

`SoftwareBitmap` supports a fixed set of pixel formats (see [BitmapPixelFormat](/uwp/api/Windows.Graphics.Imaging.BitmapPixelFormat)) that are not optimized for AI Foundry on Windows. Use [CreateWithImageBufferAsync](imageobjectextractor_createwithimagebufferasync_698545862.md) for pixel formats that are optimized for AI Foundry on Windows.

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
