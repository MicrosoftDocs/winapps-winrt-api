---
-api-id: M:Microsoft.Windows.AI.Text.TextSummarizer.SummarizeAsync(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AI.Text.TextSummarizer.SummarizeAsync(System.String)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.AI.Text.LanguageModelResponseResult,string> SummarizeAsync (string text);
-->

## -description

Asynchronously summarizes the text input.

## -parameters

### -param text

The text to summarize.

## -returns

The summarized text.

## -remarks

Returns a [LanguageModelResponseResult](languagemodelresponseresult.md) containing the summarized text. Check the [Status](languagemodelresponseresult_status.md) property to determine whether the operation completed successfully, and read the summary from the [Text](languagemodelresponseresult_text.md) property.

The operation reports progress as each token is generated, which you can use to display partial results in real time.

Before calling this method, you can check whether the text fits within the model's context window by calling [IsPromptLargerThanContext](textsummarizer_ispromptlargerthancontext_123976394.md).

## -see-also

[SummarizeParagraphAsync](textsummarizer_summarizeparagraphasync_633554225.md), [SummarizeConversationAsync](textsummarizer_summarizeconversationasync_1593584223.md), [LanguageModelResponseResult](languagemodelresponseresult.md), [Get started with Phi Silica](/windows/ai/apis/phi-silica)

## -examples

```csharp
using Microsoft.Windows.AI.Text;

using LanguageModel languageModel = await LanguageModel.CreateAsync();

var textSummarizer = new TextSummarizer(languageModel);
string text = "This is a large amount of text I want to have summarized.";
var result = await textSummarizer.SummarizeAsync(text);

if (result.Status == LanguageModelResponseStatus.Complete)
{
    Console.WriteLine(result.Text);
}
```
