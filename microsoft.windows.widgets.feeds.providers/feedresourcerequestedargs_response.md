---
-api-id: P:Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.Response
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.Response

<!--
public Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceResponse Response { get; set; }
-->


## -description

Gets or sets the [FeedResourceResponse](xref:Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceResponse) representing the response to the feed resource request.

## -property-value

The feed resource response.

## -remarks

Feed providers can access the resource request through the [FeedResourceRequestedArgs.Request](Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.Request) property and set the [FeedResourceRequestedArgs.Response](Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.Request) to a [FeedResourceResponse](xref:Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceResponse) that contains a stream to the resource and then return. If the evaluation or the resource is not immediately available, the provider should request a deferral by calling [FeedResourceRequestedArgs.GetDeferral](Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.GetDeferral), initiate a background task, and complete the deferral when the resource is available.

If the provider returns the [OnResourceRequested](xref:Microsoft.Windows.Widgets.Feeds.Providers.IFeedResourceProvider.OnResourceRequested(Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs)) call without setting the **FeedResourceRequestedArgs.Response** property, a web fetch will be made. When returning without a **FeedResourceResponse**, the provider may modify the [Headers](xref:Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceResponse.Headers) collection which will then be used by the web fetch.

## -see-also

## -examples


