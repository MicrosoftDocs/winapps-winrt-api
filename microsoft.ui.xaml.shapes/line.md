---
-api-id: T:Microsoft.UI.Xaml.Shapes.Line
-api-type: winrt class
---

<!-- Class syntax.
public class Line : Windows.UI.Xaml.Shapes.Shape, Windows.UI.Xaml.Shapes.ILine
-->

# Microsoft.UI.Xaml.Shapes.Line

## -description
Draws a straight line between two points.

## -xaml-syntax
```xaml
<Line .../>
```

## -remarks

Set the [Stroke](shape_stroke.md) to specify the color of the line. Set the [StrokeThickness](shape_strokethickness.md) property to specify the thickness of the line.

## -examples

This example shows how to use the Line class to create three lines.

```xaml
<Canvas Height="300" Width="300">
  <!- - Draws a diagonal line from (10,10) to (50,50). - ->
  <Line
    X1="10" Y1="10"
    X2="50" Y2="50"
    Stroke="Black"
    StrokeThickness="4" />

  <!- - Draws a diagonal line from (10,10) to (50,50)
       and moves it 100 pixels to the right. - ->
  <Line
    X1="10" Y1="10"
    X2="50" Y2="50"
    Stroke="Blue"
    StrokeThickness="4"
    Canvas.Left="100"/>

  <!- - Draws a horizontal line from (10,60) to (150,60). - ->
  <Line
     X1="10" Y1="60"
     X2="150" Y2="60"
     Stroke="Black"
     StrokeThickness="4"/>

</Canvas>
```

> [!TIP]
> For more info, design guidance, and code examples, see [Draw shapes](/windows/apps/design/controls/shapes).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see Shape features in action](winui3gallery://item/Shape)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)

## -see-also

[Shape](shape.md), [XAML vector-based drawing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample), [Draw shapes](/windows/uwp/graphics/drawing-shapes)
