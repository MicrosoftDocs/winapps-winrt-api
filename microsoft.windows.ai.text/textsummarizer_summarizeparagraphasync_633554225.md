---
-api-id: M:Microsoft.Windows.AI.Text.TextSummarizer.SummarizeParagraphAsync(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AI.Text.TextSummarizer.SummarizeParagraphAsync(System.String)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.AI.Text.LanguageModelResponseResult,string> SummarizeParagraphAsync (string text);
-->

## -description

Asynchronously summarizes a paragraph of text input.

## -parameters

### -param text

The paragraph of text to summarize.

## -returns

The summarized text.

## -remarks

Unlike [SummarizeAsync](textsummarizer_summarizeasync_822055106.md) which returns a list of key points, this method returns the summary as a single flowing paragraph.

## -see-also

[SummarizeAsync](textsummarizer_summarizeasync_822055106.md), [SummarizeConversationAsync](textsummarizer_summarizeconversationasync_1593584223.md)

## -examples
