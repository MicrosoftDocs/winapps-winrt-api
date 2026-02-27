---
-api-id: M:Microsoft.Windows.AI.Imaging.ImageObjectExtractor.CreateWithImageBufferAsync(Microsoft.Graphics.Imaging.ImageBuffer)
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.ImageObjectExtractor.CreateWithImageBufferAsync(Microsoft.Graphics.Imaging.ImageBuffer)

<!--
public static Windows.Foundation.IAsyncOperation<Microsoft.Windows.AI.Imaging.ImageObjectExtractor> CreateWithImageBufferAsync (Microsoft.Graphics.Imaging.ImageBuffer imageBuffer);
-->

## -description

Asynchronously creates an `ImageObjectExtractor` using an uncompressed bitmap, optimized for AI Foundry on Windows.

## -parameters

### -param softwareBitmap

The uncompressed bitmap image, optimized for AI Foundry on Windows, from which to extract artifacts.

## -returns

An asynchronous operation object which, when it completes, contains the `ImageObjectExtractor`.

## -remarks

Use [CreateWithSoftwareBitmapAsync](imageobjectextractor_createwithsoftwarebitmapasync_1289883320.md) for pixel formats not supported by [ImageBuffer](../microsoft.graphics.imaging/imagebuffer.md).

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
