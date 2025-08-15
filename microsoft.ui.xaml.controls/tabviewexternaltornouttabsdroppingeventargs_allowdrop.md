---
-api-id: P:Microsoft.UI.Xaml.Controls.TabViewExternalTornOutTabsDroppingEventArgs.AllowDrop
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.TabViewExternalTornOutTabsDroppingEventArgs.AllowDrop

<!--
public bool AllowDrop { get; set; }
-->

## -description

Gets or sets a value that indicates whether or not to accept the tabs that are being dropped.

## -property-value

`true` if tabs can be dropped onto this TabView; otherwise, `false`. The default is `false`.

## -remarks

In the handler for the [ExternalTornOutTabsDropping](tabview_externaltornouttabsdropping.md) event, set this property to `true` to allow the drop; otherwise, set it to `false` (the default). If set to `false`, the [ExternalTornOutTabsDropped](tabview_externaltornouttabsdropped.md) event is not raised and the user will continue to be dragging the torn-out tabs.

External tabs are accepted only from other TabView controls in the same process.

## -see-also

## -examples
