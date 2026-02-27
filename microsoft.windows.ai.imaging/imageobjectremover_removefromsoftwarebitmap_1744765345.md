---
-api-id: M:Microsoft.Windows.AI.Imaging.ImageObjectRemover.RemoveFromSoftwareBitmap(Windows.Graphics.Imaging.SoftwareBitmap,Windows.Graphics.Imaging.SoftwareBitmap)
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.ImageObjectRemover.RemoveFromSoftwareBitmap(Windows.Graphics.Imaging.SoftwareBitmap,Windows.Graphics.Imaging.SoftwareBitmap)

<!--
public Windows.Graphics.Imaging.SoftwareBitmap RemoveFromSoftwareBitmap (Windows.Graphics.Imaging.SoftwareBitmap softwareBitmap, Windows.Graphics.Imaging.SoftwareBitmap softwareBitmapMask);
-->

## -description

Removes artifacts from an uncompressed bitmap (based on a mask) and uses surrounding pixels to backfill the masked area.

## -parameters

### -param softwareBitmap

The uncompressed bitmap to modify.

### -param softwareBitmapMask

The gray scale mask.

## -returns

The modified uncompressed bitmap.

## -remarks

`SoftwareBitmap` supports a fixed set of pixel formats (see [BitmapPixelFormat](/uwp/api/Windows.Graphics.Imaging.BitmapPixelFormat)) that are not optimized for AI Foundry on Windows. Use [RemoveFromImageBuffer](imageobjectremover_removefromimagebuffer_1878721313.md) for pixel formats that are optimized for AI Foundry on Windows.

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
