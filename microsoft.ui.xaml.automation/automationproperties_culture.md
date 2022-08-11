---
-api-id: P:Microsoft.UI.Xaml.Automation.AutomationProperties.Culture
-api-type: winrt attachedproperty
---

# Microsoft.UI.Xaml.Automation.AutomationProperties.Culture

<!--
see GetCulture, and SetCulture
-->


## -description

Gets or sets the locale identifier for the automation element (for example, 0x0409 for "en-US" or English (United States)).

## -remarks

Each locale has a unique identifier, a 32-bit value that consists of a language identifier and a sort order identifier. The locale identifier is a standard international numeric abbreviation and has the components necessary to uniquely identify one of the installed operating system-defined locales. For more information, see [Language Identifier Constants and Strings](/windows/desktop/Intl/language-identifier-constants-and-strings).  

This property may exist on a per-control basis, but typically is only available on an application level.

- Type: int
- Identifier field: [CultureProperty](automationproperties_cultureproperty.md)
- Accessor methods: [GetCulture](automationproperties_getculture_1970665174.md), [SetCulture](automationproperties_setculture_1140502938.md)

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples


