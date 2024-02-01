---
-api-id: T:Microsoft.UI.Xaml.Controls.AppBarSeparator
-api-type: winrt class
---

<!-- Class syntax.
public class AppBarSeparator : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IAppBarSeparator, Windows.UI.Xaml.Controls.ICommandBarElement, Windows.UI.Xaml.Controls.ICommandBarElement2
-->

# Microsoft.UI.Xaml.Controls.AppBarSeparator

## -description

Represents a line that separates items in an [AppBar](appbar.md) or [CommandBar](commandbar.md).

## -xaml-syntax

```xaml
<AppBarSeparator .../>
```

## -remarks

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar](/windows/uwp/controls-and-patterns/app-bars).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the AppBarSeparator in action](winui3gallery:/item/AppBarSeparator)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

## -see-also

[Control](control.md), [AppBar](appbar.md), [AppBarButton](appbarbutton.md), [AppBarToggleButton](appbartogglebutton.md), [CommandBar](commandbar.md), [Controls list](/windows/apps/design/controls/), [Commanding sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlCommanding)
