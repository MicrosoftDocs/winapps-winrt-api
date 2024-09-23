---
-api-id: M:Microsoft.Windows.Widgets.Feeds.Providers.IFeedProvider.OnFeedDisabled(Microsoft.Windows.Widgets.Feeds.Providers.FeedDisabledArgs)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Feeds.Providers.IFeedProvider.OnFeedDisabled(Microsoft.Windows.Widgets.Feeds.Providers.FeedDisabledArgs)

<!--
public void OnFeedDisabled (Microsoft.Windows.Widgets.Feeds.Providers.FeedDisabledArgs args);
-->


## -description

Invoked by the Widgets Board when a feed is disabled.

## -parameters

### -param args

A [FeedDisabledArgs](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.feeddisabledargs) object that provides the feed ID and feed provider ID of the feed that has been disabled.

## -remarks

Feed providers are not required to perform any actions in response to this method invocation, but it can be used for telemetry purposes or to revoke authentication tokens, if needed.

## -see-also

## -examples


