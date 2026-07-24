---
-api-id: T:Microsoft.Windows.AI.Text.LanguageModelOptions
-api-type: winrt class
---

# Microsoft.Windows.AI.Text.LanguageModelOptions

<!--
public sealed class LanguageModelOptions
-->

## -description

Defines the options that affect how the language model responds to a prompt.

## -remarks

Pass a **LanguageModelOptions** instance to [LanguageModel.GenerateResponseAsync](languagemodel_generateresponseasync_1153118514.md) to customize model behavior. You can configure content filtering through the [ContentFilterOptions](languagemodeloptions_contentfilteroptions.md) property, which controls the severity levels allowed for different content categories.

## -see-also

[LanguageModel.GenerateResponseAsync](languagemodel_generateresponseasync_1153118514.md), [LanguageModel](languagemodel.md), [Content moderation](/windows/ai/apis/content-moderation)

## -examples
