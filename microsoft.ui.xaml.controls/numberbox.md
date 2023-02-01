---
-api-id: T:Microsoft.UI.Xaml.Controls.NumberBox
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.NumberBox

<!--
public class NumberBox : Windows.UI.Xaml.Controls.Control
-->

## -description

Represents a control that can be used to display and edit numbers.

## -remarks

This control supports validation, increment stepping, and computing inline calculations of basic equations such as multiplication, division, addition, and subtraction.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [NumberBox_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/NumberBox/NumberBox_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

## -see-also

[NumberBoxSpinButtonPlacementMode](numberboxspinbuttonplacementmode.md), [NumberBoxValidationMode](numberboxvalidationmode.md), [NumberBoxValueChangedEventArgs](numberboxvaluechangedeventargs.md)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Number box](/windows/apps/design/controls/number-box).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the NumberBox in action](winui3gallery:/item/NumberBox).

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)
