---
-api-id: P:Microsoft.UI.Xaml.Automation.AutomationProperties.LocalizedLandmarkType
-api-type: winrt attachedproperty
---

# Microsoft.UI.Xaml.Automation.AutomationProperties.LocalizedLandmarkType

<!--
see GetLocalizedLandmarkType, and SetLocalizedLandmarkType
-->

## -description

Gets or sets a localized text string that describes the type of landmark that the automation element represents.

## -remarks

This should be used in tandem with [UIA_CustomLandmarkTypeId](/windows/desktop/WinAuto/landmark-type-identifiers) however, `LocalizedLandmarkType` should always take precedence over [LandmarkType](automationproperties_landmarktype.md) and be used to describe the landmark before `LandmarkType`.

The string must match the application UI language or the operating system default UI language.

- Type: string
- Identifier field: [LocalizedLandmarkTypeProperty](automationproperties_localizedlandmarktypeproperty.md)
- Accessor methods: [GetLocalizedLandmarkType](automationproperties_getlocalizedlandmarktype_532521774.md), [SetLocalizedLandmarkType](automationproperties_setlocalizedlandmarktype_1590817650.md)

## -see-also

[LandmarkType](automationproperties_landmarktype.md), [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples


