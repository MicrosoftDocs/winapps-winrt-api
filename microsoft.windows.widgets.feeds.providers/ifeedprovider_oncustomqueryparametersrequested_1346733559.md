---
-api-id: M:Microsoft.Windows.Widgets.Feeds.Providers.IFeedProvider.OnCustomQueryParametersRequested(Microsoft.Windows.Widgets.Feeds.Providers.CustomQueryParametersRequestedArgs)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Feeds.Providers.IFeedProvider.OnCustomQueryParametersRequested(Microsoft.Windows.Widgets.Feeds.Providers.CustomQueryParametersRequestedArgs)

<!--
public void OnCustomQueryParametersRequested (Microsoft.Windows.Widgets.Feeds.Providers.CustomQueryParametersRequestedArgs args);
-->


## -description

Notifies the feed provider that the Widgets Board needs the the app to update a feed's custom query parameters. This occurs when a fetch of feed data fails due to due to an expired authentication token was set in a previous call to <xref:Microsoft.Windows.Widgets.Feeds.Providers.FeedManager.SetCustomQueryParameters(Microsoft.Windows.Widgets.Feeds.Providers.CustomQueryParametersUpdateOptions)?displayProperty=nameWithType>.

## -parameters

### -param args

A <xref:Microsoft.Windows.Widgets.Feeds.Providers.CustomQueryParametersRequestedArgs?displayProperty=nameWithType> that provides the ID for the feed for which query parameters are being requested. The ID is specified in the app manifest file for the feed provider app. For more information, see [Feed provider package manifest XML format](/windows/apps/develop/feeds/feed-provider-manifest).

## -remarks

## -see-also

## -examples


