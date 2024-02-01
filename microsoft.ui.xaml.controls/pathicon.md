---
-api-id: T:Microsoft.UI.Xaml.Controls.PathIcon
-api-type: winrt class
---

<!-- Class syntax.
public class PathIcon : Windows.UI.Xaml.Controls.IconElement, Windows.UI.Xaml.Controls.IPathIcon
-->

# Microsoft.UI.Xaml.Controls.PathIcon

## -description

Represents an icon that uses a vector path as its content.

## -xaml-syntax

```xaml
<PathIcon .../>
```

## -remarks

> [!NOTE]
> You can set the **Foreground** property on the [AppBarButton](appbarbutton.md) or on the PathIcon. If you set the [Foreground](control_foreground.md) on the [AppBarButton](appbarbutton.md), it's applied only to the default visual state. It's not applied to the other visual states defined in the [AppBarButton](appbarbutton.md) template, like `MouseOver`. If you set the [Foreground](iconelement_foreground.md) on the PathIcon, the color is applied to all visual states.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar](/windows/uwp/controls-and-patterns/app-bars).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the AppBarButton in action](winui3gallery:/item/AppBarButton)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

This example shows an [AppBarButton](appbarbutton.md) with a PathIcon.

```xaml
<!-- App bar button with path icon. -->
<AppBarButton Label="PathIcon" Click="AppBarButton_Click">
    <AppBarButton.Icon>
        <PathIcon Data="F1 M 16,12 20,2L 20,16 1,16" HorizontalAlignment="Center"/>
    </AppBarButton.Icon>
</AppBarButton>
```

## -see-also

[IconElement](iconelement.md), [AppBarButton](appbarbutton.md), [Path](../microsoft.ui.xaml.shapes/path.md), [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax), [Icons for UWP apps](/windows/uwp/style/icons) 
