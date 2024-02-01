---
-api-id: T:Microsoft.UI.Xaml.Shapes.Path
-api-type: winrt class
---

<!-- Class syntax.
public class Path : Windows.UI.Xaml.Shapes.Shape, Windows.UI.Xaml.Shapes.IPath
-->

# Microsoft.UI.Xaml.Shapes.Path

## -description
Draws a series of connected lines and curves. The line and curve dimensions are declared through the [Data](path_data.md) property, and can be specified either with [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax), or with an object model.

## -xaml-syntax
```xaml
<Path .../>
```

## -remarks

## -examples

This XAML example uses a **Path** with a [GeometryGroup](../microsoft.ui.xaml.media/geometrygroup.md) value as [Data](path_data.md) to draw a superimposed ellipse and rectangle shape.

```xaml
<Canvas> 
  <Path Fill="Gold" Stroke="Black" StrokeThickness="1">
    <Path.Data>
      <GeometryGroup>
        <EllipseGeometry Center="50,50" RadiusX="50" RadiusY="50"/>
        <RectangleGeometry Rect="0,0,100,100" />
      </GeometryGroup>
    </Path.Data>
  </Path> 
</Canvas>
```

> [!TIP]
> For more info, design guidance, and code examples, see [Draw shapes](/windows/apps/design/controls/shapes).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see Shape features in action](winui3gallery://item/Shape)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)

## -see-also

[Shape](shape.md), [Data](path_data.md), [XAML vector-based drawing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample), [Draw shapes](/windows/uwp/graphics/drawing-shapes), [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax), [Windows.UI.Xaml.Media namespace](/uwp/api/windows.ui.xaml.media)
