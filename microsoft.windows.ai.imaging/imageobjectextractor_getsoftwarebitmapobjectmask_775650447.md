---
-api-id: M:Microsoft.Windows.AI.Imaging.ImageObjectExtractor.GetSoftwareBitmapObjectMask(Microsoft.Windows.AI.Imaging.ImageObjectExtractorHint)
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.ImageObjectExtractor.GetSoftwareBitmapObjectMask(Microsoft.Windows.AI.Imaging.ImageObjectExtractorHint)

<!--
public Windows.Graphics.Imaging.SoftwareBitmap GetSoftwareBitmapObjectMask (Microsoft.Windows.AI.Imaging.ImageObjectExtractorHint hint);
-->

## -description

Retrieves an uncompressed bitmap as a `Gray8` mask used to extract artifacts from an image.

## -parameters

### -param hint

Helps identify the intended artifact to extract.

## -returns

A `SoftwareBitmap` as a `Gray8` mask used to extract artifacts from an image.

## -remarks

`SoftwareBitmap` supports a fixed set of pixel formats (see [BitmapPixelFormat](/uwp/api/Windows.Graphics.Imaging.BitmapPixelFormat)) that are not optimized for AI Foundry on Windows. Use [GetImageBufferObjectMask](imageobjectextractor_getimagebufferobjectmask_396059515.md) for pixel formats that are optimized for AI Foundry on Windows.

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
