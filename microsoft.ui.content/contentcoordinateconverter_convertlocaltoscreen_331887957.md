---
-api-id: M:Microsoft.UI.Content.ContentCoordinateConverter.ConvertLocalToScreen(Windows.Foundation.Point[],Microsoft.UI.Content.ContentCoordinateRoundingMode)
-api-type: winrt method
---

# Microsoft.UI.Content.ContentCoordinateConverter.ConvertLocalToScreen(Windows.Foundation.Point[],Microsoft.UI.Content.ContentCoordinateRoundingMode)

<!--
public Windows.Graphics.PointInt32[] ConvertLocalToScreen (Windows.Foundation.Point[] localPoints, Microsoft.UI.Content.ContentCoordinateRoundingMode roundingMode);
-->

## -description

Converts the local coordinates of the supplied [point](/uwp/api/windows.foundation.point) collection to screen coordinate space (adjusted for [RasterizationScale](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.xamlroot.rasterizationscale)) using the specified rounding mode.

## -parameters

### -param localPoints

The [point](/uwp/api/windows.foundation.point) collection to convert from local coordinates to screen coordinate space (adjusted for [RasterizationScale](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.xamlroot.rasterizationscale)).

### -param roundingMode

The rounding mode.

## -returns

The converted [point](/uwp/api/windows.graphics.pointint32) collection.

## -remarks

## -see-also

## -examples
