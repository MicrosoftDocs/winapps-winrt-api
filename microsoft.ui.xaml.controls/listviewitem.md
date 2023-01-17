---
-api-id: T:Microsoft.UI.Xaml.Controls.ListViewItem
-api-type: winrt class
---

<!-- Class syntax.
public class ListViewItem : Windows.UI.Xaml.Controls.Primitives.SelectorItem, Windows.UI.Xaml.Controls.IListViewItem
-->

# Microsoft.UI.Xaml.Controls.ListViewItem

## -description
Represents the container for an item in a [ListView](listview.md) control.

## -xaml-syntax
```xaml
<ListViewItem .../>
-or-
<ListViewItem ...>
  content
</ListViewItem>
```


## -remarks
The ListViewItem class provides the container for items displayed in a [ListView](listview.md) control. You populate the [ListView](listview.md) by adding objects directly to its [Items](itemscontrol_items.md) collection or by binding its [ItemsSource](itemscontrol_itemssource.md) property to a data source. When items are added to the [ListView](listview.md), a ListViewItem container is created automatically for each item in the collection.

You can specify the look of the ListViewItem by setting the [ListView](listview.md)'s [ItemContainerStyle](itemscontrol_itemcontainerstyle.md) property to a [Style](../microsoft.ui.xaml/style.md) with a [TargetType](../microsoft.ui.xaml/style_targettype.md) of ListViewItem.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [ListViewItem_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/ListViewItem_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

> **Windows 8.1**
> To assign a custom value based on the data item to the [AutomationProperties.Name](../microsoft.ui.xaml.automation/automationproperties_name.md) attached property, you must bind to the item container's [Content](contentcontrol_content.md) property. For example, assume you have a `Customer` data item that has a `Name` property and you want to use the `Customer.Name` property as the [AutomationProperties.Name](../microsoft.ui.xaml.automation/automationproperties_name.md) value.

In Windows 8, the data item is set as the [DataContext](../microsoft.ui.xaml/frameworkelement_datacontext.md) of the item container, so you can use a binding like this: `AutomationProperties.Name="{Binding Name}"`.

In Windows 8.1, the item container's [DataContext](../microsoft.ui.xaml/frameworkelement_datacontext.md) is not set. To bind the [AutomationProperties.Name](../microsoft.ui.xaml.automation/automationproperties_name.md) value to the data item's `Name` property, use a binding like this: `AutomationProperties.Name="{Binding Path=Content.Name,RelativeSource={RelativeSource Mode=Self}}"`.

## -examples

## -see-also
[SelectorItem](../microsoft.ui.xaml.controls.primitives/selectoritem.md), [ListView](listview.md), [ItemContainerStyle](itemscontrol_itemcontainerstyle.md), [Item templates for ListView](/windows/uwp/controls-and-patterns/item-templates-listview)
