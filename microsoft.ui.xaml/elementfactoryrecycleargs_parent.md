---
-api-id: P:Microsoft.UI.Xaml.ElementFactoryRecycleArgs.Parent
-api-type: winrt property
---

<!-- Property syntax.
public UIElement Parent { get;  set; }
-->

# Microsoft.UI.Xaml.ElementFactoryRecycleArgs.Parent

## -description

Gets or sets a reference to the current parent [UIElement](uielement.md) of the element being recycled.

## -property-value

The parent [UIElement](uielement.md) object or **null**.  By default, it is **null**.

## -remarks

This value is optional. When provided it can enable a performance optimization for implementations of [GetElement](ielementfactory_getelement_445960756.md) that return recycled elements.  For more info, see the remarks for the [DataTemplate.RecycleElement](datatemplate_recycleelement_1220951169.md) method.

## -see-also

[IElementFactory](ielementfactory.md), [DataTemplate.GetElement](datatemplate_getelement_445960756.md), [DataTemplate.RecycleElement](datatemplate_recycleelement_1220951169.md), [DataTemplateSelector.GetElement](../microsoft.ui.xaml.controls/datatemplateselector_getelement_445960756.md), [DataTemplateSelector.RecycleElement](../microsoft.ui.xaml.controls/datatemplateselector_recycleelement_1220951169.md), [ElementFactoryGetArgs](elementfactorygetargs.md), [ElementFactoryRecycleArgs](elementfactoryrecycleargs.md)

## -examples
