---
-api-id: P:Microsoft.Windows.AI.Text.LanguageModelOptions.TopK
-api-type: winrt property
---

# Microsoft.Windows.AI.Text.LanguageModelOptions.TopK

<!--
public uint TopK { get; set; }
-->

## -description

Gets or sets a value that specifies the maximum number of highest probability tokens used to identify a suitable response.

## -property-value

A value that specifies the maximum number of highest probability tokens used to identify a suitable response.

Value can range between 0-32064, inclusive. Default is 40.

## -remarks

Top-k sampling is also known as truncated sampling.

A low value indicates more predictable and less varied responses, while a higher value indicates more creative and varied responses.

## -see-also

[TopP](languagemodeloptions_topp.md), [Temperature](languagemodeloptions_temperature.md)

## -examples
