---
-api-id: P:Microsoft.Windows.Widgets.Providers.WidgetInfo.Rank
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Providers.WidgetInfo.Rank

<!--
public int Rank { get; }
-->


## -description

Gets a value indicating the rank of the widget, relative to other widgets from the same package identity.

## -property-value

An integer specifying the relative rank of the widget. Smaller values are ranked higher than lower values.

## -remarks

The rank value can be used by the widget host to determine the preferred order in which widgets are displayed in the widget selection UI. The rank property does not affect how widgets are ordered compared to widgets from other providers. The rank property also does not affect the chance that a widget will be recommended by the system.

Modify the rank of a widget by setting the [Rank](widgetupdaterequestoptions_rank.md) property of the [WidgetUpdateRequestOptions](widgetupdaterequestoptions.md) object when calling [UpdateWidget](widgetmanager_updatewidget_250598866.md).

## -see-also

## -examples


