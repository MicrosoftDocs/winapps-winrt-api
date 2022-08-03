---
-api-id: P:Microsoft.UI.Xaml.Automation.AutomationProperties.LandmarkType
-api-type: winrt attachedproperty
---

# Microsoft.UI.Xaml.Automation.AutomationProperties.LandmarkType

<!--
see GetLandmarkType, and SetLandmarkType
-->

## -description

Gets or sets a [Landmark Type Identifier](/windows/desktop/WinAuto/landmark-type-identifiers) associated with an element.

## -remarks

The `LandmarkType` property describes a *landmark*, an element that represents a meaningful group of elements. For example, a search landmark could represent a set of controls related to searching. Landmarks have many similarities with headings; for more information about how to use landmarks and headings, see [Landmarks and Headings](/windows/apps/design/accessibility/landmarks-and-headings).

If `CustomLandmarkType` is used then [LocalizedLandmarkType](automationproperties_localizedlandmarktype.md) is required to describe the custom landmark.

- Type: [AutomationLandmarkType](../microsoft.ui.xaml.automation.peers/automationlandmarktype.md)
- Identifier field: [LandmarkTypeProperty](automationproperties_landmarktypeproperty.md)
- Accessor methods: [GetLandmarkType](automationproperties_getlandmarktype_1023268773.md), [SetLandmarkType](automationproperties_setlandmarktype_1381639993.md)

## -see-also

[Landmark Type Identifier](/windows/desktop/WinAuto/landmark-type-identifiers), [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples
