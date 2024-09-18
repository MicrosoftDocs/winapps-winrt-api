---
-api-id: M:Microsoft.Windows.Widgets.Feeds.Providers.IFeedProvider.OnCustomQueryParametersRequested(Microsoft.Windows.Widgets.Feeds.Providers.CustomQueryParametersRequestedArgs)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Feeds.Providers.IFeedProvider.OnCustomQueryParametersRequested(Microsoft.Windows.Widgets.Feeds.Providers.CustomQueryParametersRequestedArgs)

<!--
public void OnCustomQueryParametersRequested (Microsoft.Windows.Widgets.Feeds.Providers.CustomQueryParametersRequestedArgs args);
-->


## -description

Notifies the feed provider that the Widgets Board needs the the app to update a feed's custom query parameters. This occurs when a fetch of feed data fails due to due to an expired authentication token was set in a previous call to [Microsoft.Windows.Widgets.Feeds.Providers.FeedManager.SetCustomQueryParameters](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.feedmanager.setcustomqueryparameters(microsoft.windows.widgets.feeds.providers.customqueryparametersupdateoptions)).

## -parameters

### -param args

A [Microsoft.Windows.Widgets.Feeds.Providers.CustomQueryParametersRequestedArgs](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.customqueryparametersrequestedargs) that provides the ID for the feed for which query parameters are being requested. The ID is specified in the app manifest file for the feed provider app. For more information, see [Feed provider package manifest XML format](/windows/apps/develop/feeds/feed-provider-manifest).

## -remarks

## -see-also

## -examples


