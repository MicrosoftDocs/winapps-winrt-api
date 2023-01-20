---
-api-id: T:Microsoft.UI.Xaml.Controls.RatingControl
-api-type: winrt class
---
<!-- Class syntax.
public class RatingControl : Control, Control
-->

# Microsoft.UI.Xaml.Controls.RatingControl

## -description

Represents a control that lets a user enter a star rating.

## -remarks

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [RatingControl_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/RatingControl/RatingControl_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

## -see-also

[Rating control](/windows/uwp/controls-and-patterns/rating)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Rating control](/windows/apps/design/controls/rating).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the RatingControl in action](winui3gallery:/item/RatingControl).

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

## -xaml-syntax

```xaml
<RatingControl/>
```
