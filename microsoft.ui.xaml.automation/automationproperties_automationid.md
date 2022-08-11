---
-api-id: P:Microsoft.UI.Xaml.Automation.AutomationProperties.AutomationId
-api-type: winrt attachedproperty
---

# Microsoft.UI.Xaml.Automation.AutomationProperties.AutomationId

<!--
see GetAutomationId, and SetAutomationId
-->


## -description

Gets or sets the string that uniquely identifies the element to Microsoft UI Automation.

## -remarks

When it is available, the `AutomationId` of an element must be the same in any instance of the application, regardless of the local language. The value should be unique among sibling elements, but not necessarily unique across the entire desktop. For example, multiple instances of an application, or multiple folder views in Windows Explorer, can contain elements with the same `AutomationId` property, such as "SystemMenuBar".

Although support for `AutomationId` is always recommended for better automated testing support, this property is not mandatory. Where it is supported, `AutomationId` is useful for creating a test automation script that runs regardless of the UI language. Clients should make no assumptions regarding the `AutomationId` values exposed by other applications. `AutomationId` is not guaranteed to be stable across different releases or builds of an application.

- Type: string
- Identifier field: [AutomationIdProperty](automationproperties_automationidproperty.md)
- Accessor methods: [GetAutomationId](automationproperties_getautomationid_2072492085.md), [SetAutomationId](automationproperties_setautomationid_881018639.md)

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples


