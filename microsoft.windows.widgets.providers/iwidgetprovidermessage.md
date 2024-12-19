---
-api-id: T:Microsoft.Windows.Widgets.Providers.IWidgetProviderMessage
-api-type: winrt interface
---

# Microsoft.Windows.Widgets.Providers.IWidgetProviderMessage

<!--
public interface IWidgetProviderMessage
-->


## -description

This optional interface can be implemented by a widget provider to receive string messages from the widget's web content that has been posted using the [window.chrome.webview.postMessage](/microsoft-edge/webview2/reference/javascript/webview) JavaScript method.

## -remarks

The calls to [window.chrome.webview.postMessage](/microsoft-edge/webview2/reference/javascript/webview) in the widget's web content must use a `targetOrigin` that matches the origin of the widget registration, which is specified in the *webUrl* field of the adaptive card content.

## -see-also

## -examples


