---
-api-id: M:Microsoft.Windows.Widgets.Feeds.Providers.IFeedProviderMessage.OnMessageReceived(Microsoft.Windows.Widgets.Feeds.Providers.FeedMessageReceivedArgs)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Feeds.Providers.IFeedProviderMessage.OnMessageReceived(Microsoft.Windows.Widgets.Feeds.Providers.FeedMessageReceivedArgs)

<!--
public void OnMessageReceived (Microsoft.Windows.Widgets.Feeds.Providers.FeedMessageReceivedArgs args);
-->


## -description

Raised when the feed's content posts a message using the `window.postMessage` JavaScript method.

## -parameters

### -param args

A [FeedMessageReceivedArgs](xref:Microsoft.Windows.Widgets.Feeds.Providers.FeedMessageReceivedArgs) that provides details about the message that triggered the event.

## -remarks

The calls to `window.postMessage` in the feed content must use a `targetOrigin` that matches the origin of the feed registration, specified in the *ContentUri* attribute of the **Definition** element in the provider's package manifest file. For more information see [Feed provider package manifest XML format](/windows/apps/develop/feeds/feed-provider-manifest).

## -see-also

## -examples


