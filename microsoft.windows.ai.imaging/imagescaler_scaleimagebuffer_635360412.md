---
-api-id: M:Microsoft.Windows.AI.Imaging.ImageScaler.ScaleImageBuffer(Microsoft.Graphics.Imaging.ImageBuffer,System.Int32,System.Int32)
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.ImageScaler.ScaleImageBuffer(Microsoft.Graphics.Imaging.ImageBuffer,System.Int32,System.Int32)

<!--
public Microsoft.Graphics.Imaging.ImageBuffer ScaleImageBuffer (Microsoft.Graphics.Imaging.ImageBuffer imageBuffer, int width, int height);
-->

## -description

Scales an uncompressed bitmap optimized for AI Foundry on Windows.

## -parameters

### -param imageBuffer

The uncompressed bitmap to scale, optimized for AI Foundry on Windows.

### -param width

The width of the bitmap, in pixels.

### -param height

The height of the bitmap, in pixels.

## -returns

The uncompressed bitmap modified to the specified scale.

## -remarks

Use [ScaleSoftwareBitmap](imagescaler_scalesoftwarebitmap_357867096.md) for pixel formats not supported by [ImageBuffer](../microsoft.graphics.imaging/imagebuffer.md).

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging), [Image scaler walkthrough](/windows/ai/apis/imaging-tutorial)

## -examples
