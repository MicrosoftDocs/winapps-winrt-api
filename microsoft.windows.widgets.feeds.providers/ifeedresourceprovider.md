---
-api-id: T:Microsoft.Windows.Widgets.Feeds.Providers.IFeedResourceProvider
-api-type: winrt interface
---

# Microsoft.Windows.Widgets.Feeds.Providers.IFeedResourceProvider

<!--
public interface IFeedResourceProvider
-->


## -description

This optional interface can be implemented by a feed provider to monitor, provide, or alter resources that are requested by the feed web content.

## -remarks

Feed providers can specify a web request filter string for a feed in the *WebRequestFilter* attribute of the **Definition** element in the provider's package manifest file. Whenever the feed content requests a resource by URI that matches the filter, the request will be intercepted and redirected to the feed provider's implementation of [IFeedResourceProvider.OnResourceRequested](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.ifeedresourceprovider.onresourcerequested)).

The filter pattern is expressed using the format described in [Match Patterns](https://developer.mozilla.org/en-US/docs/Mozilla/Add-ons/WebExtensions/Match_patterns). The filter string in the registration must use [Punycode](https://en.wikipedia.org/wiki/Punycode) where necessary. All content types will be redirected when matched so the filter should only resolve to content intended to be obtained through the **IFeedResourceProvider** in the application.

Every GET, PUT or UPDATE request made by a feed web app that matches its registered filter must also match the the origin of the feed registration, specified in the *ContentUri* attribute of the **Definition** element in the provider's package manifest file. If the resource does not match in origin, the request will be ignored.

If the provider returns the [OnResourceRequested](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.ifeedresourceprovider.onresourcerequested)) call without setting a [FeedResourceResponse](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.feedresourceresponse) in the [FeedResourceRequestedArgs](Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs), a web fetch will be made. When returning without a **FeedResourceResponse**, the provider may modify the [Headers](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.feedresourceresponse.headers) collection which will then be used by the web fetch.


## -see-also

[Feed provider package manifest XML format](/windows/apps/develop/feeds/feed-provider-manifest)

## -examples


