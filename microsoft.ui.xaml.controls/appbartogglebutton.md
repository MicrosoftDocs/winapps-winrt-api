---
-api-id: T:Microsoft.UI.Xaml.Controls.AppBarToggleButton
-api-type: winrt class
---

<!-- Class syntax.
public class AppBarToggleButton : Windows.UI.Xaml.Controls.Primitives.ToggleButton, Windows.UI.Xaml.Controls.IAppBarToggleButton, Windows.UI.Xaml.Controls.IAppBarToggleButton3, Windows.UI.Xaml.Controls.ICommandBarElement, Windows.UI.Xaml.Controls.ICommandBarElement2
-->

# Microsoft.UI.Xaml.Controls.AppBarToggleButton

## -description

Represents a button control that can switch states and be displayed in an [AppBar](appbar.md).

## -xaml-syntax

```xaml
<AppBarToggleButton .../>
```

## -remarks

An AppBarToggleButton is similar to an [AppBarButton](appbarbutton.md) with an additional toggle state. When used inside a [CommandBar](commandbar.md). the visual appearance changes based on whether the control appears in the primary commands or the overflow menu. Here is an example of a toggled button as both a primary command and secondary command.

<img src="images/AppBarToggleButton_TwoModes.png" alt="App bar button icon examples." />

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar](/windows/uwp/controls-and-patterns/app-bars).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the AppBarToggleButton in action](winui3gallery:/item/AppBarToggleButton)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

## -see-also

[Control](control.md), [AppBar](appbar.md), [AppBarButton](appbarbutton.md), [AppBarSeparator](appbarseparator.md), [CommandBar](commandbar.md), [ToggleButton](../microsoft.ui.xaml.controls.primitives/togglebutton.md), [Controls list](/windows/apps/design/controls/), [Commanding sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlCommanding)
