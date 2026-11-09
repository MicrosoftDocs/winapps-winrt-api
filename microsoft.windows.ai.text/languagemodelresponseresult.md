---
-api-id: T:Microsoft.Windows.AI.Text.LanguageModelResponseResult
-api-type: winrt class
---

# Microsoft.Windows.AI.Text.LanguageModelResponseResult

<!--
public sealed class LanguageModelResponseResult
-->

## -description

Represents a language model response.

## -remarks

**LanguageModelResponseResult** is returned by [LanguageModel.GenerateResponseAsync](languagemodel_generateresponseasync_1596814667.md) and contains the generated text, a status code, and extended error information if the request failed.

Check the [Status](languagemodelresponseresult_status.md) property to determine whether the response completed successfully. A status of [Complete](languagemodelresponsestatus.md) indicates that the [Text](languagemodelresponseresult_text.md) property contains the full response. Other status values indicate errors such as content moderation blocks, context window overflow, or policy restrictions. When the status indicates an error, call [ExtendedError](languagemodelresponseresult_extendederror.md) for diagnostic details.

## -see-also

[LanguageModel.GenerateResponseAsync](languagemodel_generateresponseasync_1596814667.md), [LanguageModelResponseStatus](languagemodelresponsestatus.md), [LanguageModel](languagemodel.md)

## -examples
