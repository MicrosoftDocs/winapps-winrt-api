---
-api-id: T:Microsoft.UI.Xaml.Controls.ImageIconSource
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.ImageIconSource

<!--
public class ImageIconSource : Microsoft.UI.Xaml.Controls.IconSource
-->

## -description

Represents an icon source that uses an image type as its content. The image types currently supported are .bmp, .gif, .jpg, .png, .wdp, and .tiff.

## -remarks

ImageIconSource is similar to [ImageIcon](imageicon.md). However, because it is not a FrameworkElement, it can be shared.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Icons for Windows apps](/windows/apps/design/style/icons).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see IconElement in action](winui3gallery:/item/IconElement)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

The following example shows an [AppBarButton](appbarbutton.md) with an ImageIconSource. [ImageSource](../microsoft.ui.xaml.media/imagesource.md) specifies an image that's included in the app package.

```xaml
<!--
xmlns:muxc="using:Microsoft.UI.Xaml.Controls"
-->

<AppBarButton >
    <AppBarButton.Icon>
        <IconSourceElement>
            <muxc:ImageIconSource ImageSource="ms-appx:///Assets/globe.png"/>
        </IconSourceElement>
    </AppBarButton.Icon>
</AppBarButton>
```

Here we show how to load an ImageIconSource from a bitmap stream.

```csharp
// using muxc = Microsoft.UI.Xaml.Controls;

var bitmapSource = new BitmapSource();
await bitmapSource.SetSourceAsync(bitmapStream);
var icon = new muxc.ImageIconSource() { ImageSource = bitmapSource };
```

## -see-also

[IconElement](iconelement.md), [AppBarButton](appbarbutton.md), [Image](image.md), [Icons for UWP apps](/windows/uwp/style/icons)
