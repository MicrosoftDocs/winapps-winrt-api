---
-api-id: P:Microsoft.Windows.Widgets.Providers.WidgetAnalyticsInfoReportedArgs.AnalyticsJson
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Providers.WidgetAnalyticsInfoReportedArgs.AnalyticsJson

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
    "eventKind": "interaction",
    "interactionKind": "titleLink",
    "url": "https://www.contoso.com"
}
```

## -see-also

## -examples


