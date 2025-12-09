---
-api-id: M:Microsoft.Windows.AI.Imaging.ImageScaler.ScaleSoftwareBitmap(Windows.Graphics.Imaging.SoftwareBitmap,System.Int32,System.Int32)
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.ImageScaler.ScaleSoftwareBitmap(Windows.Graphics.Imaging.SoftwareBitmap,System.Int32,System.Int32)

<!--
public Windows.Graphics.Imaging.SoftwareBitmap ScaleSoftwareBitmap (Windows.Graphics.Imaging.SoftwareBitmap softwareBitmap, int width, int height);
-->

## -description

Scales an uncompressed bitmap.

## -parameters

### -param softwareBitmap

The uncompressed bitmap to scale.

### -param width

The width of the bitmap, in pixels.

### -param height

The height of the bitmap, in pixels.

## -returns

The uncompressed bitmap modified to the specified scale.

## -remarks

`SoftwareBitmap` supports a fixed set of pixel formats (see [BitmapPixelFormat](/uwp/api/Windows.Graphics.Imaging.BitmapPixelFormat)) that are not optimized for AI Foundry on Windows. Use [ScaleImageBuffer](imagescaler_scaleimagebuffer_635360412.md) for pixel formats that are optimized for AI Foundry on Windows.

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging), [Image scaler walkthrough](/windows/ai/apis/imaging-tutorial)

## -examples
