---
-api-id: P:Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemTemplate
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.ItemsRepeater.ItemTemplate

<!--
public object ItemTemplate { get; set; }
-->

## -description

Gets or sets the template used to display each item.

## -property-value

The template that specifies the visualization of the data objects. The default is **null**.

## -remarks

Set this property to a factory object used to generate a UIElement for a given data item. This can be a [DataTemplate](../microsoft.ui.xaml/datatemplate.md), a [DataTemplateSelector](datatemplateselector.md), or a custom implementation of [IElementFactory](../microsoft.ui.xaml/ielementfactory.md) [IElementFactory](../microsoft.ui.xaml/ielementfactory.md) that creates UIElements by some other mechanism.

Generated elements might be re-used. For example, an element generated to display the item at index 0 might be reused later to display the item at index 100.

## -see-also

## -examples

