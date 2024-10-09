---
-api-id: P:Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.Response
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.Response

<!--
public Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceResponse Response { get; set; }
-->


## -description

Gets or sets the [FeedResourceResponse](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.feedresourceresponse) representing the response to the feed resource request.

## -property-value

The feed resource response.

## -remarks

Feed providers can access the resource request through the [FeedResourceRequestedArgs.Request](Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.Request) property and set the [FeedResourceRequestedArgs.Response](Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.Request) to a [FeedResourceResponse](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.feedresourceresponse) that contains a stream to the resource and then return. If the evaluation or the resource is not immediately available, the provider should request a deferral by calling [FeedResourceRequestedArgs.GetDeferral](Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.GetDeferral), initiate a background task, and complete the deferral when the resource is available.

If the provider returns the [OnResourceRequested](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.ifeedresourceprovider.onresourcerequested)) call without setting the **FeedResourceRequestedArgs.Response** property, a web fetch will be made. When returning without a **FeedResourceResponse**, the provider may modify the [Headers](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.feedresourceresponse.headers) collection which will then be used by the web fetch.

## -see-also

## -examples


