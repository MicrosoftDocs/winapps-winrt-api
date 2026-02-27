---
-api-id: T:Microsoft.UI.Xaml.Controls.ImageIconSource
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.ImageIconSource

<!--
public class ImageIconSource : Microsoft.UI.Xaml.Controls.IconSource
-->

## -description

Represents an icon source that uses an image type as its content.

## -remarks

ImageIconSource is limited to use with the `IconSource` property of these controls:

- [InfoBadge.IconSource](infobadge_iconsource.md)
- [InfoBar.IconSource](infobar_iconsource.md)
- [SwipeItem.IconSource](swipeitem_iconsource.md)
- [TabViewItem.IconSource](tabviewitem_iconsource.md)
- [TeachingTip.IconSource](teachingtip_iconsource.md)
- [TitleBar.IconSource](titlebar_iconsource.md)

Other usage of ImageIconSource will not result in an error, but the image will not be shown. For example, this use of ImageIconSource with IconSourceElement will not show the image.

```xaml
<!-- INCORRECT CODE - DO NOT USE -->
<AppBarButton >
    <AppBarButton.Icon>
        <IconSourceElement>
            <ImageIconSource ImageSource="ms-appx:///Assets/StoreLogo.png"/>
        </IconSourceElement>
    </AppBarButton.Icon>
</AppBarButton>
<!-- INCORRECT CODE - DO NOT USE -->
```

The supported image types are .bmp, .gif, .jpg, .png, .wdp, and .tiff.

ImageIconSource is similar to [ImageIcon](imageicon.md). However, because it is not a FrameworkElement, it can be shared.

## -examples

> [!IMPORTANT]
> ImageIconSource is limited to use with the `IconSource` property of certain controls. See Remarks for more info.

> [!TIP]
> For more info, design guidance, and code examples, see [Icons for Windows apps](/windows/apps/design/style/icons).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see IconElement in action](winui3gallery://item/IconElement)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://apps.microsoft.com/detail/9p3jfpwwdzrc) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

The following example shows an [InfoBar](infobar.md) with an ImageIconSource. [ImageSource](../microsoft.ui.xaml.media/imagesource.md) specifies an image that's included in the app package.

```xaml
<InfoBar Title="InfoBar Title"
         Message="This is an InfoBar message." 
         IsOpen="True">
    <InfoBar.IconSource>
        <ImageIconSource ImageSource="ms-appx:///Assets/StoreLogo.png"/>
    </InfoBar.IconSource>
</InfoBar>
```

Here we show how to load an ImageIconSource from a bitmap stream.

```csharp
var bitmapSource = new BitmapSource();
await bitmapSource.SetSourceAsync(bitmapStream);
var icon = new ImageIconSource() { ImageSource = bitmapSource };
```

## -see-also

[IconElement](iconelement.md), [Image](image.md), [Icons in Windows apps](/windows/apps/develop/ui/controls/icons)
