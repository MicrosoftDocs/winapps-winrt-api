---
-api-id: P:Microsoft.Windows.Widgets.Notifications.FeedAnnouncement.Duration
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Notifications.FeedAnnouncement.Duration

<!--
public System.TimeSpan Duration { get; set; }
-->


## -description

Gets or sets an optional duration value, specifying how long the announcement will be displayed. 

## -property-value

## -remarks

Once the duration time elapses, the announcement will be removed from the feeds host. The duration is subject to the platform's minimum and maximum threshold limits. Values outside these limits will be adjusted to the nearest threshold value, either minimum or maximum, as appropriate. If not specified, a default duration set by the platform will be used. 

The <xref:Microsoft.Windows.Widgets.Notifications.FeedAnnouncement.ExpirationTime> and **Duration** are related in such a way that, at the time an announcement secures a spot for display, the current time plus the duration must not exceed the expiration time.

## -see-also

## -examples


