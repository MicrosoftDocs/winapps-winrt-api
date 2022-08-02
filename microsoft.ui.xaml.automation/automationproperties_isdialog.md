---
-api-id: P:Microsoft.UI.Xaml.Automation.AutomationProperties.IsDialog
-api-type: winrt attachedproperty
---

# Microsoft.UI.Xaml.Automation.AutomationProperties.IsDialog

<!--
see GetIsDialog, and SetIsDialog
-->

## -description

Gets or sets a value that indicates whether the automation element is a dialog window.

## -remarks

In many cases, assistive technology (AT) treats a dialog window differently than other types of windows. A screen reader, for example, typically speaks the title of the dialog, the focused control in the dialog, and then the content of the dialog up to the focused control (for example, "Do you want to save your changes before closing"). For standard windows, a screen reader typically speaks the window title followed by the focused control.

When `AutomationProperties.IsDialog` is `true`, a client application should treat the element as a dialog window.

[Flyout](../microsoft.ui.xaml.controls/flyout.md) and [ContentDialog](../microsoft.ui.xaml.controls/contentdialog.md) elements default to `true` for `AutomationProperties.IsDialog`.

*   Type: Boolean
*   Identifier field: [IsDialogProperty](automationproperties_isdialogproperty.md)
*   Accessor methods: [GetIsDialog](automationproperties_getisdialog_2032328110.md), [SetIsDialog](automationproperties_setisdialog_1690101398.md)

## -see-also

[XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview)

## -examples


