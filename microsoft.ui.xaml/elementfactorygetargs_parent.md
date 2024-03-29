---
-api-id: P:Microsoft.UI.Xaml.ElementFactoryGetArgs.Parent
-api-type: winrt property
---

<!-- Property syntax.
public UIElement Parent { get;  set; }
-->

# Microsoft.UI.Xaml.ElementFactoryGetArgs.Parent

## -description

Gets or sets the [UIElement](uielement.md) that is expected to be the parent of the realized element from [GetElement](ielementfactory_getelement_445960756.md).

## -property-value

The [UIElement](uielement.md) object expected to be the parent of the realized [UIElement](uielement.md) or **null**.  By default, it is **null**.

## -remarks

This value is optional. When used it can enable a performance optimization for implementations of [GetElement](ielementfactory_getelement_445960756.md) that return recycled elements. For more info, see the remarks for the [DataTemplate.RecycleElement](datatemplate_recycleelement_1220951169.md) method.

## -see-also

[IElementFactory](ielementfactory.md), [DataTemplate.GetElement](datatemplate_getelement_445960756.md), [DataTemplate.RecycleElement](datatemplate_recycleelement_1220951169.md), [DataTemplateSelector.GetElement](../microsoft.ui.xaml.controls/datatemplateselector_getelement_445960756.md), [DataTemplateSelector.RecycleElement](../microsoft.ui.xaml.controls/datatemplateselector_recycleelement_1220951169.md), [ElementFactoryGetArgs](elementfactorygetargs.md), [ElementFactoryRecycleArgs](elementfactoryrecycleargs.md)

## -examples

