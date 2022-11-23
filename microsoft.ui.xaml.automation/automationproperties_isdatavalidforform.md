---
-api-id: P:Microsoft.UI.Xaml.Automation.AutomationProperties.IsDataValidForForm
-api-type: winrt attachedproperty
---

# Microsoft.UI.Xaml.Automation.AutomationProperties.IsDataValidForForm

<!--
see GetIsDataValidForForm, and SetIsDataValidForForm
-->

## -description

Gets or sets a value that indicates whether the data is valid for the form.

## -remarks

The `IsDataValidForForm` property indicates whether the entered or selected value is valid for the form rule associated with the automation element. For example, if the user entered "425-555-5555" for a zip code field that requires 5 or 9 digits, the `IsDataValidForForm` property can be set to `false` to indicate that the data is not valid.

- Type: Boolean
- Identifier field: [IsDataValidForFormProperty](automationproperties_isdatavalidforformproperty.md)
- Accessor methods: [GetIsDataValidForForm](automationproperties_getisdatavalidforform_1261071178.md), [SetIsDataValidForForm](automationproperties_setisdatavalidforform_868778882.md)

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples
