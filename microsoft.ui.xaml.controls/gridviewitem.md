---
-api-id: T:Microsoft.UI.Xaml.Controls.GridViewItem
-api-type: winrt class
---

<!-- Class syntax.
public class GridViewItem : Windows.UI.Xaml.Controls.Primitives.SelectorItem, Windows.UI.Xaml.Controls.IGridViewItem
-->

# Microsoft.UI.Xaml.Controls.GridViewItem

## -description
Represents the container for an item in a [GridView](gridview.md) control.

## -xaml-syntax
```xaml
<GridViewItem .../>
-or-
<GridViewItem ...>
  content
</GridViewItem>
```


## -remarks
The GridViewItem class provides the container for items displayed in a [GridView](gridview.md) control. You populate the [GridView](gridview.md) by adding objects directly to its [Items](itemscontrol_items.md) collection or by binding its [ItemsSource](itemscontrol_itemssource.md) property to a data source. When items are added to the [GridView](gridview.md), a GridViewItem container is created automatically for each item in the collection.

You can specify the look of the GridViewItem by setting the [GridView](gridview.md)'s [ItemContainerStyle](itemscontrol_itemcontainerstyle.md) property to a [Style](../microsoft.ui.xaml/style.md) with a [TargetType](../microsoft.ui.xaml/style_targettype.md) of GridViewItem.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

> **Windows 8.1**
> To assign a custom value based on the data item to the [AutomationProperties.Name](../microsoft.ui.xaml.automation/automationproperties_name.md) attached property, you must bind to the item container's [Content](contentcontrol_content.md) property. For example, assume you have a `Customer` data item that has a `Name` property and you want to use the `Customer.Name` property as the [AutomationProperties.Name](../microsoft.ui.xaml.automation/automationproperties_name.md) value.

In Windows 8, the data item is set as the [DataContext](../microsoft.ui.xaml/frameworkelement_datacontext.md) of the item container, so you can use a binding like this: `AutomationProperties.Name="{Binding Name}"`.

In Windows 8.1, the item container's [DataContext](../microsoft.ui.xaml/frameworkelement_datacontext.md) is not set. To bind the [AutomationProperties.Name](../microsoft.ui.xaml.automation/automationproperties_name.md) value to the data item's `Name` property, use a binding like this: `AutomationProperties.Name="{Binding Path=Content.Name,RelativeSource={RelativeSource Mode=Self}}"`.

## -examples

## -see-also
[SelectorItem](../microsoft.ui.xaml.controls.primitives/selectoritem.md), [GridView](gridview.md), [ItemContainerStyle](itemscontrol_itemcontainerstyle.md), [Item templates for GridView](/windows/uwp/controls-and-patterns/item-templates-gridview)
