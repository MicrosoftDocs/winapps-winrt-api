---
-api-id: M:Microsoft.UI.Xaml.Media.Imaging.VirtualSurfaceImageSource.#ctor(System.Int32,System.Int32,System.Boolean)
-api-type: winrt constructor
---

<!-- Method syntax
public VirtualSurfaceImageSource(System.Int32 pixelWidth, System.Int32 pixelHeight, System.Boolean isOpaque)
-->

# Microsoft.UI.Xaml.Media.Imaging.VirtualSurfaceImageSource.VirtualSurfaceImageSource

## -description
Initializes a new instance of the [VirtualSurfaceImageSource](virtualsurfaceimagesource.md) class, specifying the size of the drawing area and a preference for whether to render with an alpha transparency.

## -parameters
### -param pixelWidth
Width of the drawing area in pixels.

### -param pixelHeight
Height of the drawing area in pixels.

### -param isOpaque
**true** if the area should render opaque. **false** to render with possible alpha transparency.

## -remarks

Windows validates that *pixelWidth* and *pixelHeight* are under 17 million (17,000,000).

Other factors might impact how much content can be rendered in a single [VirtualSurfaceImageSource](virtualsurfaceimagesource.md). For example, placing a [VirtualSurfaceImageSource](virtualsurfaceimagesource.md) in a [ScrollViewer](../microsoft.ui.xaml.controls/scrollviewer.md) might further reduce the effective size based on the [ScrollViewer](../microsoft.ui.xaml.controls/scrollviewer.md)'s limits.

## -examples

## -see-also
[VirtualSurfaceImageSource(Int32, Int32)](virtualsurfaceimagesource_virtualsurfaceimagesource_452674076.md)
