---
-api-id: M:Microsoft.Graphics.Imaging.ImageBuffer.CreateCopyFromBitmap(Windows.Graphics.Imaging.SoftwareBitmap)
-api-type: winrt method
---

# Microsoft.Graphics.Imaging.ImageBuffer.CreateCopyFromBitmap(Windows.Graphics.Imaging.SoftwareBitmap)

<!--
public static Microsoft.Graphics.Imaging.ImageBuffer CreateCopyFromBitmap (Windows.Graphics.Imaging.SoftwareBitmap softwareBitmap);
-->

## -description

Create a new `ImageBuffer` from an existing [SoftwareBitmap](/uwp/api/windows.graphics.imaging.softwarebitmap) by copying out the underlying bitmap data.

## -parameters

### -param softwareBitmap

The **SotftwareBitmap** to create the `ImageBuffer` from.

## -returns

The `ImageBuffer`, or null if it's an unsupported format.

## -remarks

The **SoftwareBitmap** is locked until the async operation completes and the new `ImageBuffer` is destroyed.

## -see-also

## -examples
