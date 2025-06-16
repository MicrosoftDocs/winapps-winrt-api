---
-api-id: P:Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions.Rank
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions.Rank

<!--
public System.Nullable<int> Rank { get; set; }
-->


## -description

Gets or sets a value specifying the rank of the widget, relative to other widgets from the same package identity.

## -property-value

An integer specifying the relative rank of the widget. Smaller values are ranked higher than lower values. A negative value specifies that the default default order should be used. If the value is null it indicates that no changes are requested for this property.

## -remarks

The rank value can be used by the widget host to determine the preferred order in which widgets are displayed in the widget selection UI. The rank property does not affect how widgets are ordered compared to widgets from other providers. The rank property also does not affect the chance that a widget will be recommended by the system.

## -see-also

## -examples


