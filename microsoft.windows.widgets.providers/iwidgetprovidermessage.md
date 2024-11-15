---
-api-id: T:Microsoft.Windows.Widgets.Providers.IWidgetProviderMessage
-api-type: winrt interface
---

# Microsoft.Windows.Widgets.Providers.IWidgetProviderMessage

<!--
public interface IWidgetProviderMessage
-->


## -description

This optional interface can be implemented by a widget provider to receive string messages from the widget's content that has been posted using the [window.chrome.webview.postMessage](/microsoft-edge/webview2/reference/javascript/webview) JavaScript method.

## -remarks

The calls to [window.chrome.webview.postMessage](/microsoft-edge/webview2/reference/javascript/webview) in the widget content must use a `targetOrigin` that matches the origin of the widget registration, specified in the *ContentUri* attribute of the **Definition** element in the provider's package manifest file. For more information see [Widget provider package manifest XML format](/windows/apps/develop/widgets/widget-provider-manifest).

## -see-also

## -examples


