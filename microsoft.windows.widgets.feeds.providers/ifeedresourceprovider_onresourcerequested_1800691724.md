---
-api-id: M:Microsoft.Windows.Widgets.Feeds.Providers.IFeedResourceProvider.OnResourceRequested(Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Feeds.Providers.IFeedResourceProvider.OnResourceRequested(Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs)

<!--
public void OnResourceRequested (Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs args);
-->


## -description

Raised when the feed's content requests a resource that matches the web request filter string for a feed in the *WebRequestFilter* attribute of the **Definition** element in the provider's package manifest file. For more information, see [Feed provider package manifest XML format](/windows/apps/develop/feeds/feed-provider-manifest).

## -parameters

### -param args

A [FeedResourceRequestedArgs](Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs) containing information about the resource request.

## -remarks

If the provider returns the [OnResourceRequested](xref:Microsoft.Windows.Widgets.Feeds.Providers.IFeedResourceProvider.OnResourceRequested(Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs)) call without setting a [FeedResourceResponse](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.feedresourceresponse) in the [FeedResourceRequestedArgs](Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs), a web fetch will be made. When returning without a **FeedResourceResponse**, the provider may modify the [Headers](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.feedresourceresponse.headers) collection which will then be used by the web fetch.

## -see-also

[Feed provider package manifest XML format](/windows/apps/develop/feeds/feed-provider-manifest)

## -examples


