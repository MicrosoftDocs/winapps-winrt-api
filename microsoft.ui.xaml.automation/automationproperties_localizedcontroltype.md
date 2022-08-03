---
-api-id: P:Microsoft.UI.Xaml.Automation.AutomationProperties.LocalizedControlType
-api-type: winrt attachedproperty
---

# Microsoft.UI.Xaml.Automation.AutomationProperties.LocalizedControlType

<!--
see GetLocalizedControlType, and SetLocalizedControlType
-->

## -description

Gets or sets a localized text string that describes the type of control that the automation element represents.

## -remarks

The string should contain only lowercase characters:

+ Correct: "button"
+ Incorrect: "Button"

When `LocalizedControlType` is not specified by the element provider, the default localized string is supplied by the framework, according to the control type of the element (for example, "button" for the [Button](../microsoft.ui.xaml.controls/button.md) control type). An automation element with the `Custom` control type must support a localized control type string that represents the role of the element (for example, "color picker" for a custom control that enables users to choose and specify colors).

When a custom value is supplied, the string must match the application UI language or the operating system default UI language.

- Type: string
- Identifier field: [LocalizedControlTypeProperty](automationproperties_localizedcontroltypeproperty.md)
- Accessor methods: [GetLocalizedControlType](automationproperties_getlocalizedcontroltype_568833340.md), [SetLocalizedControlType](automationproperties_setlocalizedcontroltype_832127952.md)

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples
