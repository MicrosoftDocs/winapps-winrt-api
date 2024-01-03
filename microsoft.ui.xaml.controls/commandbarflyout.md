---
-api-id: T:Microsoft.UI.Xaml.Controls.CommandBarFlyout
-api-type: winrt class
---
<!-- Class syntax.
public class CommandBarFlyout : FlyoutBase, FlyoutBase
-->

# Microsoft.UI.Xaml.Controls.CommandBarFlyout

## -description

Represents a specialized flyout that provides layout for [AppBarButton](/uwp/api/windows.ui.xaml.controls.appbarbutton), [AppBarToggleButton](/uwp/api/Windows.UI.Xaml.Controls.AppBarToggleButton), and [AppBarSeparator](/uwp/api/Windows.UI.Xaml.Controls.AppBarSeparator) controls.

## -remarks

You can add other controls to a CommandBarFlyout by wrapping them in an [AppBarElementContainer](/uwp/api/windows.ui.xaml.controls.appbarelementcontainer?view=winrt-19041). This includes controls such as [DropDownButton](dropdownbutton.md) or [SplitButton](splitbutton.md), or containers like [StackPanel](/uwp/api/windows.ui.xaml.controls.stackpanel?view=winrt-19041) for more complex UI.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -see-also

[Command bar flyout](/windows/apps/design/controls/command-bar-flyout)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Command bar flyout](/windows/apps/design/controls/command-bar-flyout).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the CommandBarFlyout in action](winui3gallery:/item/CommandBarFlyout).

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)

## -xaml-syntax

```xaml
<CommandBarFlyout .../>
-or-
<CommandBarFlyout>
  commandBarElements
</CommandBarFlyout>
```
