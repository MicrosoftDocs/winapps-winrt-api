---
-api-id: M:Microsoft.Windows.Widgets.Feeds.Providers.FeedManager.TryShowAnnouncement(System.String,System.String,Microsoft.Windows.Widgets.Notifications.FeedAnnouncement)
-api-type: winrt method
---

# Microsoft.Windows.Widgets.Feeds.Providers.FeedManager.TryShowAnnouncement(System.String,System.String,Microsoft.Windows.Widgets.Notifications.FeedAnnouncement)

<!--
public void TryShowAnnouncement (string feedProviderDefinitionId, string feedDefinitionId, Microsoft.Windows.Widgets.Notifications.FeedAnnouncement announcement);
-->


## -description

Requests that an announcement be shown in the taskbar. The feeds host may or may not show this announcement, based on its policies. If the user interacts with the announcement, the feed provider's [FeedAnnouncementInvokedArgs)](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.feeds.providers.ifeedannouncementinvokedtarget.onannouncementinvoked(microsoft.windows.widgets.notifications.feedannouncementinvokedargs)) method will be called.

## -parameters

### -param feedProviderDefinitionId

The definition ID of the feed provider. This is the value specified in the *Id* attribute of the **FeedProvider** element in the provider's package manifest file. For more information see [Feed provider package manifest XML format](/windows/apps/develop/feeds/feed-provider-manifest).

### -param feedDefinitionId

The definition ID of the feed. This is the value specified in the *Id* attribute of the **Definition** element in the provider's package manifest file. For more information see [Feed provider package manifest XML format](/windows/apps/develop/feeds/feed-provider-manifest).

### -param announcement

A [FeedAnnouncement](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.notifications.feedannouncement) object that provides the data for the announcement to be displayed.

## -remarks

## -see-also

## -examples


