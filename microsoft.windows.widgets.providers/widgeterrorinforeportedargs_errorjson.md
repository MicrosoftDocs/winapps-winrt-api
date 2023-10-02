---
-api-id: P:Microsoft.Windows.Widgets.Providers.WidgetErrorInfoReportedArgs.ErrorJson
-api-type: winrt property
---

# Microsoft.Windows.Widgets.Providers.WidgetErrorInfoReportedArgs.ErrorJson

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
  "host": "dashboard.microsoft.com",
  "version": "1.0",
  "errorKind": "cardValidation",
  "didRenderCard": true,
  "validationEvents": ["Too many actions defined", "Unknown element type: 'myNewType'"],
  "source": [
        "\"actions\":[{\"type\":\"Action.Submit\",\"title\":\"Action1\"}, {\"type\":\"Action.Submit\",\"title\":\"Action2\"}, {\"type\":\"Action.Submit\",\"title\":\"Action3\"}]",
        "{\"type\":\"myNewType\",\"myProperty\":\"My Value\"}"
  ]
}
```

## -see-also

## -examples


