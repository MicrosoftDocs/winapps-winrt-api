---
-api-id: T:Microsoft.UI.Xaml.Controls.PivotItem
-api-type: winrt class
---

<!-- Class syntax.
public class PivotItem : Windows.UI.Xaml.Controls.ContentControl, Windows.UI.Xaml.Controls.IPivotItem
-->

# Microsoft.UI.Xaml.Controls.PivotItem

## -description
Represents the container for an item in a [Pivot](pivot.md) control.

## -xaml-syntax
```xaml
<PivotItem .../>
```


## -remarks
### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [Pivot_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Pivot_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

## -examples

## -see-also
[ContentControl](contentcontrol.md)
