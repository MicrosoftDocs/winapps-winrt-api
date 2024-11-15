---
-api-id: P:Microsoft.Windows.Widgets.Providers.WidgetMessageReceivedArgs.Message
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Providers.WidgetMessageReceivedArgs.Message

<!--
public string Message { get; }
-->


## -description

Gets a string containing the contents of the message that was posted from the widget's content using the [window.chrome.webview.postMessage](/microsoft-edge/webview2/reference/javascript/webview) JavaScript method.

## -property-value

A string containing the contents of the message.

## -remarks

The string may be simple text or a serialized form of an object that is interpreted by the provider. For information on using the value of this property, see [TryGetWebMessageAsString](/dotnet/api/microsoft.web.webview2.core.corewebview2webmessagereceivedeventargs.trygetwebmessageasstring).

## -see-also

## -examples


