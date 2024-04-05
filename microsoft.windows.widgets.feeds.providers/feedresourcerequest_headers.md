---
-api-id: P:Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequest.Headers
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequest.Headers

<!--
public Windows.Foundation.Collections.StringMap Headers { get; set; }
-->


## -description

Gets or sets a dictionary of header values that can be used to in a feed resource request.

## -property-value

A dictionary of header values.

## -remarks

 If the provider returns from [IFeedResourceProvider.OnResourceRequested](xref:Microsoft.Windows.Widgets.Feeds.Providers.IFeedResourceProvider.OnResourceRequested(Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs)) setting the [FeedResourceRequestedArgs.Response](Microsoft.Windows.Widgets.Feeds.Providers.FeedResourceRequestedArgs.Request) property, the header collection may be modified and will be used to fetch the resource from the web.

## -see-also

## -examples


