---
-api-id: T:Microsoft.UI.Xaml.Controls.RefreshContainer
-api-type: winrt class
---
<!-- Class syntax.
public class RefreshContainer : ContentControl, ContentControl
-->

# Microsoft.UI.Xaml.Controls.RefreshContainer

## -description

Represents a container control that provides a [RefreshVisualizer](refreshvisualizer.md) and pull-to-refresh functionality for scrollable content.

## -remarks

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [RefreshContainer_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/PullToRefresh/RefreshContainer/RefreshContainer_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

## -see-also

[RefreshVisualizer](refreshvisualizer.md), [Pull to refresh](/windows/apps/design/controls/pull-to-refresh)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Pull to refresh](/windows/apps/design/controls/pull-to-refresh).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see Pull-To-Refresh in action](winui3gallery:/item/PullToRefresh).

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).
