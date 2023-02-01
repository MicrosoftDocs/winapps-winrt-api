---
-api-id: T:Microsoft.UI.Xaml.Controls.ComboBoxItem
-api-type: winrt class
---

<!-- Class syntax.
public class ComboBoxItem : Windows.UI.Xaml.Controls.Primitives.SelectorItem, Windows.UI.Xaml.Controls.IComboBoxItem
-->

# Microsoft.UI.Xaml.Controls.ComboBoxItem

## -description
Represents the container for an item in a [ComboBox](combobox.md) control.

## -xaml-syntax
```xaml
<ComboBoxItem .../>
-or-
<ComboBoxItem ...>
  content
</ComboBoxItem>
```


## -remarks
The ComboBoxItem class provides the container for items displayed in a [ComboBox](combobox.md) control. You populate the [ComboBox](combobox.md) by adding objects directly to its [Items](itemscontrol_items.md) collection or by binding its [ItemsSource](itemscontrol_itemssource.md) property to a data source. When items are added to the [ComboBox](combobox.md), a ComboBoxItem container is created automatically for each item in the collection.

You can specify the look of the ComboBoxItem by setting the [ComboBox](combobox.md)'s [ItemContainerStyle](itemscontrol_itemcontainerstyle.md) property to a [Style](../microsoft.ui.xaml/style.md) with a [TargetType](../microsoft.ui.xaml/style_targettype.md) of ComboBoxItem.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [ComboBox_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/ComboBox/ComboBox_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Combo box](/windows/apps/design/controls/combo-box).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the ComboBox in action](winui3gallery:/item/ComboBox).

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

## -see-also

[SelectorItem](../microsoft.ui.xaml.controls.primitives/selectoritem.md), [ComboBox](combobox.md), [ItemContainerStyle](itemscontrol_itemcontainerstyle.md)
