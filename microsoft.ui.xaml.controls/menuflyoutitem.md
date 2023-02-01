---
-api-id: T:Microsoft.UI.Xaml.Controls.MenuFlyoutItem
-api-type: winrt class
---

<!-- Class syntax.
public class MenuFlyoutItem : Windows.UI.Xaml.Controls.MenuFlyoutItemBase, Windows.UI.Xaml.Controls.IMenuFlyoutItem
-->

# Microsoft.UI.Xaml.Controls.MenuFlyoutItem

## -description

Represents a command in a [MenuFlyout](menuflyout.md) control.

## -xaml-syntax

```xaml
<MenuFlyoutItem .../>
-or-
<MenuFlyoutItem>string</MenuFlyoutItem>
```

## -remarks

Use a [Flyout](flyout.md) control to display single items and a [MenuFlyout](menuflyout.md) control to show a menu of items.

### **MenuFlyoutItem** derived classes

MenuFlyoutItem is the parent class for [ToggleMenuFlyoutItem](togglemenuflyoutitem.md).

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [MenuFlyout_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/MenuFlyout_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Menus and context menus](/windows/apps/design/controls/menus).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the MenuFlyout in action](winui3gallery:/item/MenuFlyout).

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

## -see-also
[MenuFlyoutItemBase](menuflyoutitembase.md), [MenuFlyout](menuflyout.md)
