---
-api-id: T:Microsoft.Windows.Widgets.Feeds.Providers.IFeedProviderMessage
-api-type: winrt interface
---

# Microsoft.Windows.Widgets.Feeds.Providers.IFeedProviderMessage

<!--
public interface IFeedProviderMessage
-->


## -description

This optional interface can be implemented by a feed provider to receive string messages from the feed's content that has been posted using the `window.postMessage` JavaScript method.

## -remarks

The calls to `window.postMessage` in the feed content must use a `targetOrigin` that matches the origin of the feed registration, specified in the *ContentUri* attribute of the **Definition** element in the provider's package manifest file. For more information see [Feed provider package manifest XML format](/windows/apps/develop/feeds/feed-provider-manifest).

## -see-also

## -examples


