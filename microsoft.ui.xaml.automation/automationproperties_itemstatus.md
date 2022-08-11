---
-api-id: P:Microsoft.UI.Xaml.Automation.AutomationProperties.ItemStatus
-api-type: winrt attachedproperty
---

# Microsoft.UI.Xaml.Automation.AutomationProperties.ItemStatus

<!--
see GetItemStatus, and SetItemStatus
-->

## -description

Gets or sets a description of the status of an item in an element.

## -remarks

The `ItemStatus` property lets a client ascertain whether an element is conveying status about an item as well as what the status is. For example, an item associated with a contact in a messaging application might be "Busy" or "Connected".

When `ItemStatus` is supported, the string must match the application UI language or the operating system default UI language.

- Type: string
- Identifier field: [ItemStatusProperty](automationproperties_itemstatusproperty.md)
- Accessor methods: [GetItemStatus](automationproperties_getitemstatus_500275242.md), [SetItemStatus](automationproperties_setitemstatus_1360733706.md)

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples


