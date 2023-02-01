---
-api-id: T:Microsoft.UI.Xaml.Controls.PipsPager
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.PipsPager

<!--
public class PipsPager : Windows.UI.Xaml.Controls.Control
-->

## -description

Represents a control that enables navigation within linearly paginated content using a configurable collection of glyphs, each of which represents a single "page" within a limitless range.

## -remarks

The glyphs highlight the current page, and indicate the availability of both preceding and succeeding pages. The control relies on current context and does not support explicit page numbering or a non-linear organization.

See the [PipsPager overview](/windows/apps/design/controls/pipspager) for more details.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [PipsPager_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/PipsPager/PipsPager_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

## -see-also

[PipsPager overview](/windows/apps/design/controls/pipspager)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Pipspager](/windows/apps/design/controls/pipspager).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the Pipspager in action](winui3gallery:/item/Pipspager).

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)

