---
-api-id: T:Microsoft.Windows.Widgets.Providers.WidgetResourceRequestedArgs
-api-type: winrt class
---

# Microsoft.Windows.Widgets.Providers.WidgetResourceRequestedArgs

<!--
public sealed class WidgetResourceRequestedArgs
-->


## -description

Provides data for the [IWidgetResourceProvider.OnResourceRequested](iwidgetresourceprovider_onresourcerequested_841047505.md) event which is raised when the widget's content requests a resource that matches the web request filter string for a widget in the *WebRequestFilter* attribute of the **Definition** element in the provider's package manifest file. For more information, see [Widget provider package manifest XML format](/windows/apps/develop/widgets/widget-provider-manifest).

## -remarks

Widget providers can access the resource request through the [WidgetResourceRequestedArgs.Request](widgetresourcerequestedargs_request.md) property and set the [WidgetResourceRequestedArgs.Response](widgetresourcerequestedargs_response.md) property to a [WidgetResourceResponse](widgetresourceresponse.md) that contains a stream to the resource and then return. If the evaluation or the resource is not immediately available, the provider should request a deferral by calling [WidgetResourceRequestedArgs.GetDeferral](widgetresourcerequestedargs_getdeferral_254836512.md), initiate a background task, and complete the deferral when the resource is available.

If the provider returns the **OnResourceRequested** call without setting a [WidgetResourceResponse](widgetresourceresponse.md) in the [WidgetResourceRequestedArgs](widgetresourcerequestedargs.md), a web fetch will be made. When returning without a **WidgetResourceResponse**, the provider may modify the [Headers](widgetresourceresponse_headers.md) collection which will then be used by the web fetch.

## -see-also

## -examples


