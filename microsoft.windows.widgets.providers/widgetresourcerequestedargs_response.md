---
-api-id: P:Microsoft.Windows.Widgets.Providers.WidgetResourceRequestedArgs.Response
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Providers.WidgetResourceRequestedArgs.Response

<!--
public Microsoft.Windows.Widgets.Providers.WidgetResourceResponse Response { get; set; }
-->


## -description

Gets or sets the [WidgetResourceResponse](widgetresourceresponse.md) representing the response to the widget resource request.

## -property-value

The widget resource response.

## -remarks

Widget providers can access the resource request through the [WidgetResourceRequestedArgs.Request](widgetresourcerequestedargs_request.md) property and set the [WidgetResourceRequestedArgs.Response](widgetresourcerequestedargs_response.md) property to a [WidgetResourceResponse](widgetresourceresponse.md) that contains a stream to the resource and then return. If the evaluation or the resource is not immediately available, the provider should request a deferral by calling [WidgetResourceRequestedArgs.GetDeferral](widgetresourcerequestedargs_getdeferral_254836512.md), initiate a background task, and complete the deferral when the resource is available.

If the provider returns the **OnResourceRequested** call without setting a [WidgetResourceResponse](widgetresourceresponse.md) in the [WidgetResourceRequestedArgs](widgetresourcerequestedargs.md), a web fetch will be made. When returning without a **WidgetResourceResponse**, the provider may modify the [Headers](widgetresourceresponse_headers.md) collection which will then be used by the web fetch.

## -see-also

## -examples


