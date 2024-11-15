---
-api-id: M:Microsoft.Windows.Widgets.Providers.IWidgetResourceProvider.OnResourceRequested(Microsoft.Windows.Widgets.Providers.WidgetResourceRequestedArgs)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Providers.IWidgetResourceProvider.OnResourceRequested(Microsoft.Windows.Widgets.Providers.WidgetResourceRequestedArgs)

<!--
public void OnResourceRequested (Microsoft.Windows.Widgets.Providers.WidgetResourceRequestedArgs args);
-->


## -description

Raised when the widget's content requests a resource that matches the web request filter string for a widget in the *WebRequestFilter* attribute of the **Definition** element in the provider's package manifest file. For more information, see [Widget provider package manifest XML format](/windows/apps/develop/widgets/widget-provider-manifest).

## -parameters

### -param args

A [WidgetResourceRequestedArgs](widgetresourcerequestedargs.md) containing information about the resource request.

## -remarks

If the provider returns the **OnResourceRequested** call without setting a [WidgetResourceResponse](widgetresourceresponse.md) in the [WidgetResourceRequestedArgs](widgetresourcerequestedargs.md), a web fetch will be made. When returning without a **WidgetResourceResponse**, the provider may modify the [Headers](widgetresourceresponse_headers.md) collection which will then be used by the web fetch.

## -see-also

## -examples


