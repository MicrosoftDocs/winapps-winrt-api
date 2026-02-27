---
-api-id: M:Microsoft.Windows.AI.Imaging.ImageObjectRemover.RemoveFromImageBuffer(Microsoft.Graphics.Imaging.ImageBuffer,Microsoft.Graphics.Imaging.ImageBuffer)
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.ImageObjectRemover.RemoveFromImageBuffer(Microsoft.Graphics.Imaging.ImageBuffer,Microsoft.Graphics.Imaging.ImageBuffer)

<!--
public Microsoft.Graphics.Imaging.ImageBuffer RemoveFromImageBuffer (Microsoft.Graphics.Imaging.ImageBuffer imageBuffer, Microsoft.Graphics.Imaging.ImageBuffer imageBufferMask);
-->

## -description

Removes artifacts from an uncompressed bitmap optimized for AI Foundry on Windows (based on a mask) and uses surrounding pixels to backfill the masked area.

## -parameters

### -param imageBuffer

The uncompressed bitmap to modify, optimized for AI Foundry on Windows.

### -param imageBufferMask

The gray scale mask.

## -returns

The modified uncompressed bitmap.

## -remarks

Use [MRemoveFromSoftwareBitmap](imageobjectremover_removefromsoftwarebitmap_1744765345.md) for pixel formats not supported by [ImageBuffer](../microsoft.graphics.imaging/imagebuffer.md).

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
