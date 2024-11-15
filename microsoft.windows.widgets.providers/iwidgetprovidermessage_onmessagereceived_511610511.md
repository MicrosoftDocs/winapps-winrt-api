---
-api-id: M:Microsoft.Windows.Widgets.Providers.IWidgetProviderMessage.OnMessageReceived(Microsoft.Windows.Widgets.Providers.WidgetMessageReceivedArgs)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Providers.IWidgetProviderMessage.OnMessageReceived(Microsoft.Windows.Widgets.Providers.WidgetMessageReceivedArgs)

<!--
public void OnMessageReceived (Microsoft.Windows.Widgets.Providers.WidgetMessageReceivedArgs args);
-->


## -description

Raised when the widget's content posts a message using the [window.chrome.webview.postMessage](/microsoft-edge/webview2/reference/javascript/webview) JavaScript method.

## -parameters

### -param args

A [WidgetMessageReceivedArgs](widgetmessagereceivedargs.md) that provides details about the message that triggered the event.

## -remarks

The calls to [window.chrome.webview.postMessage](/microsoft-edge/webview2/reference/javascript/webview) in the widget content must use a `targetOrigin` that matches the origin of the widget registration, specified in the *ContentUri* attribute of the **Definition** element in the provider's package manifest file. For more information see [Widget provider package manifest XML format](/windows/apps/develop/widgets/widget-provider-manifest).

## -see-also

## -examples


