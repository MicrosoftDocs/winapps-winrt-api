---
-api-id: T:Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs
-api-type: winrt class
---

# Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs

<!--
public sealed class FeedResourceRequestedArgs
-->


## -description

Provides data for the [FeedResourceRequestedArgs](xref:Microsoft.Windows.Widgets.Feeds.Providers.IFeedResourceProvider.OnResourceRequested(Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs)) event which is raised when the feed's content requests a resource that matches the web request filter string for a feed in the *WebRequestFilter* attribute of the **Definition** element in the provider's package manifest file. For more information, see [Feed provider package manifest XML format](/windows/apps/develop/feeds/feed-provider-manifest).

## -remarks

Feed providers can access the resource request through the [FeedResourceRequestedArgs.Request](Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.Request) property and set the [FeedResourceRequestedArgs.Response](Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.Request) property to a [FeedResourceResponse](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.feedresourceresponse) that contains a stream to the resource and then return. If the evaluation or the resource is not immediately available, the provider should request a deferral by calling [FeedResourceRequestedArgs.GetDeferral](Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.GetDeferral), initiate a background task, and complete the deferral when the resource is available.

If the provider returns the [OnResourceRequested](xref:Microsoft.Windows.Widgets.Feeds.Providers.IFeedResourceProvider.OnResourceRequested(Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs)) call without setting the **FeedResourceRequestedArgs.Response** property, a web fetch will be made. When returning without a **FeedResourceResponse**, the provider may modify the [Headers](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.feedresourceresponse.headers) collection which will then be used by the web fetch.

## -see-also

## -examples


