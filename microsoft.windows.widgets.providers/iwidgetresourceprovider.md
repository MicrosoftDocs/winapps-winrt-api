---
-api-id: T:Microsoft.Windows.Widgets.Providers.IWidgetResourceProvider
-api-type: winrt interface
---

# Microsoft.Windows.Widgets.Providers.IWidgetResourceProvider

<!--
public interface IWidgetResourceProvider
-->


## -description

This optional interface can be implemented by a widget provider to monitor, provide, or alter resources that are requested by the widget web content.

## -remarks

Widget providers can specify a web request filter string for a widget in the *WebRequestFilter* attribute of the **Definition** element in the provider's package manifest file. Whenever the widget content requests a resource by URI that matches the filter, the request will be intercepted and redirected to the widget provider's implementation of [IWidgetResourceProvider.OnResourceRequested](iwidgetresourceprovider_onresourcerequested_841047505.md).

The filter pattern is expressed using the format described in [Match Patterns](https://developer.mozilla.org/en-US/docs/Mozilla/Add-ons/WebExtensions/Match_patterns). The filter string in the registration must use [Punycode](https://en.wikipedia.org/wiki/Punycode) where necessary. All content types will be redirected when matched so the filter should only resolve to content intended to be obtained through the **IWidgetResourceProvider** in the application.

Every GET, PUT or UPDATE request made by a widget web app that matches its registered filter must also match the the origin of the widget registration, specified in the *ContentUri* attribute of the **Definition** element in the provider's package manifest file. If the resource does not match in origin, the request will be ignored.

If the provider returns the **OnResourceRequested** call without setting a [WidgetResourceResponse](widgetresourceresponse.md) in the [WidgetResourceRequestedArgs](widgetresourcerequestedargs.md), a web fetch will be made. When returning without a **WidgetResourceResponse**, the provider may modify the [Headers](widgetresourceresponse_headers.md) collection which will then be used by the web fetch.

## -see-also

[Widget provider package manifest XML format](/windows/apps/develop/widgets/widget-provider-manifest)

## -examples


