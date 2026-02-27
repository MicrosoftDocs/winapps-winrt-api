---
-api-id: M:Microsoft.Windows.AI.Imaging.ImageObjectExtractor.GetImageBufferObjectMask(Microsoft.Windows.AI.Imaging.ImageObjectExtractorHint)
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.ImageObjectExtractor.GetImageBufferObjectMask(Microsoft.Windows.AI.Imaging.ImageObjectExtractorHint)

<!--
public Microsoft.Graphics.Imaging.ImageBuffer GetImageBufferObjectMask (Microsoft.Windows.AI.Imaging.ImageObjectExtractorHint hint);
-->

## -description

Retrieves an uncompressed bitmap, optimized for AI Foundry on Windows, as a `Gray8` mask used to extract artifacts from an image.

## -parameters

### -param hint

Helps identify the intended artifact to extract.

## -returns

A `ImageBuffer` as a `Gray8` mask used to extract artifacts from an image.

## -remarks

Use [GetSoftwareBitmapObjectMask](imageobjectextractor_getsoftwarebitmapobjectmask_775650447.md) for pixel formats not supported by [ImageBuffer](../microsoft.graphics.imaging/imagebuffer.md).

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
