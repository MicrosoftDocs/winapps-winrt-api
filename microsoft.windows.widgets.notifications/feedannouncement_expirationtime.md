---
-api-id: P:Microsoft.Windows.Widgets.Notifications.FeedAnnouncement.ExpirationTime
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Notifications.FeedAnnouncement.ExpirationTime

<!--
public System.DateTimeOffset ExpirationTime { get; set; }
-->


## -description

Gets or sets the optional expiration time for the announcement.

## -property-value

The expiration time for the announcement.

## -remarks

The expiration time indicates when the announcement will no longer be valid for display. For instance, if an announcement is set to expire in five minutes but cannot be provided a display slot due to other queued announcements, the feeds host application will discard it from the queue and it will not be displayed. If the provided expiration time falls at or before the current moment, indicating that it's either immediately expiring or already expired, the platform defaults to a predefined expiration value.

The **ExpirationTime** and [Duration](/windows/windows-app-sdk/api/winrt/microsoft.windows.widgets.notifications.feedannouncement.duration) are related in such a way that, at the time an announcement secures a spot for display, the current time plus the duration must not exceed the expiration time.

## -see-also

## -examples


