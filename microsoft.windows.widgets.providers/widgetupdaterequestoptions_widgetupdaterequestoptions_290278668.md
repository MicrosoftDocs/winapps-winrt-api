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

Passing a **WidgetRequestOption** to [Microsoft.Windows.Widgets.Providers.WidgetManager.UpdateWidget](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.providers/widgetmanager_updatewidget_250598866) with an ID of a widget that has been deleted, a widget not associated with your app, or using a widget ID that does not exist will result in the update being ignored.

## -see-also

## -examples


