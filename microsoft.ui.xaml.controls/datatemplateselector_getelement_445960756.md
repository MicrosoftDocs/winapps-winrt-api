---
-api-id: M:Microsoft.UI.Xaml.Controls.DataTemplateSelector.GetElement(Microsoft.UI.Xaml.ElementFactoryGetArgs)
-api-type: winrt method
---

<!-- Method syntax.
public UIElement DataTemplateSelector.GetElement(ElementFactoryGetArgs args)
-->

# Microsoft.UI.Xaml.Controls.DataTemplateSelector.GetElement

## -description

Creates or retrieves an existing instance of the [UIElement](../microsoft.ui.xaml/uielement.md) object declared in the [DataTemplate](../microsoft.ui.xaml/datatemplate.md) returned by [SelectTemplate](datatemplateselector_selecttemplate_737484049.md).

## -parameters

### -param args

An instance of [ElementFactoryGetArgs](../microsoft.ui.xaml/elementfactorygetargs.md).

## -returns

An instance of the root [UIElement](../microsoft.ui.xaml/uielement.md) declared in the selected [DataTemplate](../microsoft.ui.xaml/datatemplate.md) or, **null** if the root of the selected [DataTemplate](../microsoft.ui.xaml/datatemplate.md) is not a [UIElement](../microsoft.ui.xaml/uielement.md).

## -remarks

For more info, see the remarks for the [DataTemplate.GetElement](../microsoft.ui.xaml/datatemplate_getelement_445960756.md) method.

## -see-also

[IElementFactory](../microsoft.ui.xaml/ielementfactory.md), [DataTemplate.GetElement](../microsoft.ui.xaml/datatemplate_getelement_445960756.md), [DataTemplate.RecycleElement](../microsoft.ui.xaml/datatemplate_recycleelement_1220951169.md), [DataTemplateSelector.RecycleElement](datatemplateselector_recycleelement_1220951169.md)

## -examples
