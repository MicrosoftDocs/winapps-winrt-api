---
-api-id: P:Microsoft.UI.Xaml.Automation.AutomationProperties.Level
-api-type: winrt attachedproperty
---

# Microsoft.UI.Xaml.Automation.AutomationProperties.Level

<!--
see GetLevel, and SetLevel
-->

## -description

Gets or sets a 1-based integer that describes the location of an element inside hierarchical or broken hierarchical structures.

## -remarks

The `Level` property describes the location of an element inside hierarchical or broken hierarchical structures. For example, a bulleted or numbered list, headings, or other structured data items can have various parent/child relationships. `Level` describes where in the structure the item is located.

Use the [CustomNavigation Control Pattern](/windows/desktop/WinAuto/uiauto-implementingcustomnavigation) in tandem with `Level`.

- Type: int
- Identifier field: [LevelProperty](automationproperties_levelproperty.md)
- Accessor methods: [GetLevel](automationproperties_getlevel_373452950.md), [SetLevel](automationproperties_setlevel_550339650.md)

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples
