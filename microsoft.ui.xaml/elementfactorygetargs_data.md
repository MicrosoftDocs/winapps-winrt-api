---
-api-id: P:Microsoft.UI.Xaml.ElementFactoryGetArgs.Data
-api-type: winrt property
---

<!-- Property syntax.
public object Data { get;  set; }
-->

# Microsoft.UI.Xaml.ElementFactoryGetArgs.Data

## -description

Gets or sets the data item for which an appropriate element tree should be realized when calling [GetElement](ielementfactory_getelement_445960756.md).

## -property-value

A reference to the data item for which a [UIElement](uielement.md) should be realized.

## -remarks

The implementation on [DataTemplate](datatemplate.md) for [GetElement](ielementfactory_getelement_445960756.md) does not use the Data value.

However, [DataTemplateSelector](../microsoft.ui.xaml.controls/datatemplateselector.md)'s implementation does use the Data value as the *item* argument when it invokes the [SelectTemplate](../microsoft.ui.xaml.controls/datatemplateselector_selecttemplate_737484049.md) method.

## -see-also

[IElementFactory](ielementfactory.md), [DataTemplate.GetElement](datatemplate_getelement_445960756.md), [DataTemplate.RecycleElement](datatemplate_recycleelement_1220951169.md), [DataTemplateSelector.GetElement](../microsoft.ui.xaml.controls/datatemplateselector_getelement_445960756.md), [DataTemplateSelector.RecycleElement](../microsoft.ui.xaml.controls/datatemplateselector_recycleelement_1220951169.md), [ElementFactoryGetArgs](elementfactorygetargs.md), [ElementFactoryRecycleArgs](elementfactoryrecycleargs.md)

## -examples
