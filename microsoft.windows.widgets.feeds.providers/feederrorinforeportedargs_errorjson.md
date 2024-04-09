---
-api-id: P:Microsoft.Windows.Widgets.Feeds.Providers.FeedErrorInfoReportedArgs.ErrorJson
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Feeds.Providers.FeedErrorInfoReportedArgs.ErrorJson

<!--
public string ErrorJson { get; }
-->


## -description

Gets a JSON string describing the error that triggered the error event.

## -property-value

A JSON string.

## -remarks

The JSON string returned by this property uses the following format:

```json
{
  "host": "dashboard.microsoft.com ",
  "version": "1.0",
  "feedId": "{FEED_ID}",
  "announcementId": "{ANNOUNCEMENT_ID}",
  "error": "{ERROR_KIND}",
  "errorMessage": "{ERROR_MESSAGE}"
}

The following example shows the error JSON string returned when the announcement expired while waiting for a slot to display:

```json
json
{
"host": "dashboard.microsoft.com ",
"version": "1.0",
"feedId": "MyFeedId",
"announcementId": "MyAnnouncementId",
"errorKind": "Announcement",
"errorMessage": "Announcement expired"
}
```

## -see-also

## -examples


