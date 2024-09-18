---
-api-id: M:Microsoft.Windows.Widgets.Feeds.Providers.IFeedProviderMessage.OnMessageReceived(Microsoft.Windows.Widgets.Feeds.Providers.FeedMessageReceivedArgs)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Feeds.Providers.IFeedProviderMessage.OnMessageReceived(Microsoft.Windows.Widgets.Feeds.Providers.FeedMessageReceivedArgs)

<!--
public void OnMessageReceived (Microsoft.Windows.Widgets.Feeds.Providers.FeedMessageReceivedArgs args);
-->


## -description

Raised when the feed's content posts a message using the [window.chrome.webview.postMessage](/microsoft-edge/webview2/reference/javascript/webview) JavaScript method.

## -parameters

### -param args

A [FeedMessageReceivedArgs](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers/feedmessagereceivedargs) that provides details about the message that triggered the event.

## -remarks

The calls to [window.chrome.webview.postMessage](/microsoft-edge/webview2/reference/javascript/webview) in the feed content must use a `targetOrigin` that matches the origin of the feed registration, specified in the *ContentUri* attribute of the **Definition** element in the provider's package manifest file. For more information see [Feed provider package manifest XML format](/windows/apps/develop/feeds/feed-provider-manifest).

## -see-also

## -examples


