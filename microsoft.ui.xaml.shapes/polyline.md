---
-api-id: T:Microsoft.UI.Xaml.Shapes.Polyline
-api-type: winrt class
---

<!-- Class syntax.
public class Polyline : Windows.UI.Xaml.Shapes.Shape, Windows.UI.Xaml.Shapes.IPolyline
-->

# Microsoft.UI.Xaml.Shapes.Polyline

## -description
Draws a series of connected straight lines.

## -xaml-syntax
```xaml
<Polyline .../>
```

## -remarks

## -examples

This example shows how to use a Polyline to create a closed triangle.

```xaml
<Canvas>  
  <Polyline Points="50,25 0,100 100,100 50,25"
    Stroke="Blue" StrokeThickness="10"
    Canvas.Left="75" Canvas.Top="50" />
</Canvas>
```

> [!TIP]
> For more info, design guidance, and code examples, see [Draw shapes](/windows/apps/design/controls/shapes).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see Shape features in action](winui3gallery://item/Shape)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)

## -see-also

[Shape](shape.md), [XAML vector-based drawing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample), [Draw shapes](/windows/uwp/graphics/drawing-shapes)
