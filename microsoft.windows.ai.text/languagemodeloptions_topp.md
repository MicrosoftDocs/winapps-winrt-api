---
-api-id: P:Microsoft.Windows.AI.Text.LanguageModelOptions.TopP
-api-type: winrt property
---

# Microsoft.Windows.AI.Text.LanguageModelOptions.TopP

<!--
public float TopP { get; set; }
-->

## -description

Gets or sets a probability threshold value used to identify a suitable response from the smallest possible set of tokens.

## -property-value

Value can range between 0 to 1, inclusive. Default is 0.9.

A low value indicates more predictable and less varied responses, while a higher value indicates more creative and varied responses.

## -remarks

Top-p sampling is also known as nucleus sampling.

Tokens that have a cumulative value greater than the value of this property are selected for the language model response.

For example, given a sentence such as "Microsoft's mission is to empower every person and every organization on the planet to achieve ???", a model might have 10 words that are appropriate to complete the sentence. If only five of those words have a reasonable probability of being correct ("more" 0.6 / "success" 0.20 / "excellence" 0.15 / "growth" .02 / "impact" .01), and the default TopP value of 0.9 is being used, the model will only base its response on the cumulative probability of the words "more" + "success" + "excellence" (0.6 + 0.20 + 0.15 = .95).

## -see-also

[TopK](languagemodeloptions_topk.md), [Temperature](languagemodeloptions_temperature.md)

## -examples
