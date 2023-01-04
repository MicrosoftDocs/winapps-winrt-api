---
-api-id: T:Microsoft.UI.Xaml.Controls.MenuFlyoutSubItem
-api-type: winrt class
---

<!-- Class syntax.
public class MenuFlyoutSubItem : Windows.UI.Xaml.Controls.MenuFlyoutItemBase, Windows.UI.Xaml.Controls.IMenuFlyoutSubItem
-->

# Microsoft.UI.Xaml.Controls.MenuFlyoutSubItem

## -description

Represents a menu item that displays a sub-menu in a [MenuFlyout](menuflyout.md) control.

## -xaml-syntax

```xaml
<MenuFlyoutSubItem>
  oneOrMoreItems
</MenuFlyoutSubItem>
```

## -remarks

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [MenuFlyout_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/MenuFlyout_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

## -examples

## -see-also

[MenuFlyoutItemBase](menuflyoutitembase.md), [Context menu (XAML) sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlContextMenu)
