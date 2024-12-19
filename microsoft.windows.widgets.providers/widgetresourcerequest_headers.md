---
-api-id: P:Microsoft.Windows.Widgets.Providers.WidgetResourceRequest.Headers
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Providers.WidgetResourceRequest.Headers

<!--
public System.Collections.Generic.IDictionary<string,string> Headers { get; }
-->


## -description

Gets or sets a dictionary of header values that can be used to in a widget resource request.

## -property-value

A dictionary of header values.

## -remarks

 If the provider returns from [IWidgetResourceProvider.OnResourceRequested](iwidgetresourceprovider_onresourcerequested_841047505.md) setting the [WidgetResourceRequestedArgs.Response](widgetresourcerequestedargs_response.md) property, the header collection may be modified and will be used to fetch the resource from the web.

## -see-also

## -examples


