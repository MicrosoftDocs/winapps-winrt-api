---
-api-id: M:Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions.#ctor(System.String)
-api-type: winrt constructor
---

# Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions.#ctor(System.String)

<!--
public WidgetUpdateRequestOptions (string widgetId);
-->


## -description

Initializes a new instance of the **WidgetRequestOptions** class.

## -parameters

### -param widgetId

The widget ID of the widget to be updated. 

## -remarks

Passing a **WidgetRequestOption** to <xref:Microsoft.Windows.Widgets.Providers.WidgetManager.UpdateWidget(Microsoft.Windows.Widgets.Providers.WidgetUpdateRequestOptions)?displayProperty=nameWithType> with an ID of a widget that has been deleted, a widget not associated with your app, or using a widget ID that does not exist will result in the update being ignored.

## -see-also

## -examples


