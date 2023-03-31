---
-api-id: T:Microsoft.UI.Xaml.Shapes.Rectangle
-api-type: winrt class
---

<!-- Class syntax.
public class Rectangle : Windows.UI.Xaml.Shapes.Shape, Windows.UI.Xaml.Shapes.IRectangle
-->

# Microsoft.UI.Xaml.Shapes.Rectangle

## -description
Draws a rectangle with a given [Height](../microsoft.ui.xaml/frameworkelement_height.md) and [Width](../microsoft.ui.xaml/frameworkelement_width.md) specified in device-independent pixel (DIP).

## -xaml-syntax
```xaml
<Rectangle .../>
```

## -remarks

You can set the [Fill](shape_fill.md) property to give the shape a background fill, like a solid color, gradient, or image. You can set the [Stroke](shape_stroke.md) and other related stroke properties to specify the look of the shape's outline.

## -examples

This example shows how to create a Rectangle in XAML and set some of its common properties as attribute values.

```xaml
<Canvas>  
  <Rectangle Width="100" Height="100" Fill="Blue" Stroke="Red" 
   Canvas.Top="20" Canvas.Left="20" StrokeThickness="3" />
</Canvas>
```

> [!TIP]
> For more info, design guidance, and code examples, see [Draw shapes](/windows/apps/design/controls/shapes).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see Shape features in action](winui3gallery:/item/Shape).

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)

## -see-also

[Shape](shape.md), [XAML vector-based drawing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample), [Draw shapes](/windows/uwp/graphics/drawing-shapes)
