---
-api-id: P:Microsoft.Windows.AI.Text.LanguageModelOptions.Temperature
-api-type: winrt property
---

# Microsoft.Windows.AI.Text.LanguageModelOptions.Temperature

<!--
public float Temperature { get; set; }
-->

## -description

Gets or sets a value that specifies how random (explorative) or conservative (deterministic) a response should be.

## -property-value

A value that specifies how random (explorative) or conservative (deterministic) a response should be.

Value can range between 0 and FLT_MAX, inclusive. Default is 0.9.

## -remarks

A low value indicates more predictable and less varied responses, while a higher value indicates more creative and varied responses.

## -see-also

## -examples

[TopK](languagemodeloptions_topk.md), [TopP](languagemodeloptions_topp.md)
