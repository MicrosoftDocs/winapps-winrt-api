---
-api-id: M:Microsoft.Windows.Widgets.Feeds.Providers.IFeedProvider.OnFeedProviderDisabled(Microsoft.Windows.Widgets.Feeds.Providers.FeedProviderDisabledArgs)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Feeds.Providers.IFeedProvider.OnFeedProviderDisabled(Microsoft.Windows.Widgets.Feeds.Providers.FeedProviderDisabledArgs)

<!--
public void OnFeedProviderDisabled (Microsoft.Windows.Widgets.Feeds.Providers.FeedProviderDisabledArgs args);
-->


## -description

Invoked by the Widgets Board when all of the feeds for this provider have been disabled.

## -parameters

### -param args

A [FeedProviderDisabledArgs](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers/feedproviderdisabledargs) object that provides the feed provider ID of the feed provider that has been disabled.

## -remarks

Feed providers can use this method to revoke any authentication tokens previously granted for this feed provider.

## -see-also

## -examples


