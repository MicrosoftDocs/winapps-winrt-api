---
-api-id: T:Microsoft.UI.Xaml.Controls.BreadcrumbBar
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.BreadcrumbBar

<!--
public class BreadcrumbBar : Windows.UI.Xaml.Controls.Control
-->


## -description

The `BreadcrumbBar` control provides the direct path of pages or folders to the current location.

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Breadcrumb bar overview](/windows/apps/design/controls/breadcrumbbar).

A [BreadcrumbBar](/windows/winui/api/microsoft.ui.xaml.controls.breadcrumbbar) provides the direct path of pages or folders to the current location. It is often used for situations where the user's navigation trail (in a file system or menu system) needs to be persistently visible and the user may need to go back to a previous location.

If the app is resized so that there is not enough space to show all the nodes, the breadcrumbs collapse and an ellipsis replaces the leftmost nodes. Clicking the ellipsis opens a flyout to show the collapsed nodes.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [BreadcrumbBar_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/Breadcrumb/BreadcrumbBar_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

## -see-also

[Breadcrumb bar overview](/windows/apps/design/controls/breadcrumbbar)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Breadcrumb Bar](/windows/apps/design/controls/breadcrumbbar).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the BreadcrumbBar in action](winui3gallery:/item/BreadcrumbBar).

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)
