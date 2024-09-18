---
-api-id: M:Microsoft.Windows.Widgets.Feeds.Providers.IFeedProvider.OnFeedEnabled(Microsoft.Windows.Widgets.Feeds.Providers.FeedEnabledArgs)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Feeds.Providers.IFeedProvider.OnFeedEnabled(Microsoft.Windows.Widgets.Feeds.Providers.FeedEnabledArgs)

<!--
public void OnFeedEnabled (Microsoft.Windows.Widgets.Feeds.Providers.FeedEnabledArgs args);
-->


## -description

Invoked by the Widgets Board when a feed is enabled. 

## -parameters

### -param args

A [FeedEnabledArgs](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers/feedenabledargs) object that provides the feed ID and feed provider ID of the feed that has been enabled.

## -remarks

Feed providers are not required to perform any actions in response to this method invocation, but it can be used for telemetry purposes or to update the query string parameters, if needed.

## -see-also

## -examples


