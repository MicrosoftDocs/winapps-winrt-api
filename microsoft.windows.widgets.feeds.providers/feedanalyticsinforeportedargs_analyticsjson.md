---
-api-id: P:Microsoft.Windows.Widgets.Feeds.Providers.FeedAnalyticsInfoReportedArgs.AnalyticsJson
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Feeds.Providers.FeedAnalyticsInfoReportedArgs.AnalyticsJson

<!--
public string AnalyticsJson { get; }
-->


## -description

Gets a JSON string describing the user interaction that triggered the analytics event.

## -property-value

A JSON string.

## -remarks

The JSON string returned by this property uses the following format:

```json
{
"host": "dashboard.microsoft.com",
"version": "1.0",
"feedId": "{feedDefinitionId}",
"eventKind": "visibility",
"visibilityKind": "visible",
"currentAnnouncement":
{
    "id": "{currentAnnouncementId}"
},
"missedAnnouncements":
[
    {
        "id": "{missedAnnouncementId1}"
    },
    {
        "id": "{missedAnnouncementId2}"
    }
]
}
```

Starting with Windows App SDK 1.6, the analytics JSON payload may contain a **currentAnnouncement** or **missedAnnouncement** objects specifying the [Id](../microsoft.windows.widgets.notifications/feedannouncement_id.md) property value of announcements sent from the widget provider with calls to [FeedManager.TryShowAnnouncement](feedmanager_tryshowannouncement_1521207212.md).

## -see-also

## -examples


