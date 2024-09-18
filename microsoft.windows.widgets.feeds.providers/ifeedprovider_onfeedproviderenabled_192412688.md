---
-api-id: M:Microsoft.Windows.Widgets.Feeds.Providers.IFeedProvider.OnFeedProviderEnabled(Microsoft.Windows.Widgets.Feeds.Providers.FeedProviderEnabledArgs)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Feeds.Providers.IFeedProvider.OnFeedProviderEnabled(Microsoft.Windows.Widgets.Feeds.Providers.FeedProviderEnabledArgs)

<!--
public void OnFeedProviderEnabled (Microsoft.Windows.Widgets.Feeds.Providers.FeedProviderEnabledArgs args);
-->


## -description

Invoked when a feed associated with the provider is created by the Widgets Board host.

## -parameters

### -param args

A [FeedProviderEnabledArgs](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.feedproviderenabledargs) object that provides the feed provider ID of the feed provider that has been enabled.

## -remarks

In the handler for this method feed providers should update the custom query parameters by calling [Microsoft.Windows.Widgets.Feeds.Providers.FeedManager.SetCustomQueryParameters](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.feedmanager.setcustomqueryparameters(microsoft.windows.widgets.feeds.providers.customqueryparametersupdateoptions)).

## -see-also

## -examples


