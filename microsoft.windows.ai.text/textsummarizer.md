---
-api-id: T:Microsoft.Windows.AI.Text.TextSummarizer
-api-type: winrt class
---

# Microsoft.Windows.AI.Text.TextSummarizer

<!--
public sealed class TextSummarizer
-->

## -description

Represents a specialized lanugage model capable of summarizing text input.

## -remarks

**TextSummarizer** is a Text Intelligence Skill that uses a local [LanguageModel](languagemodel.md) to produce concise summaries of text. You create an instance by passing a **LanguageModel** to the [TextSummarizer constructor](textsummarizer_textsummarizer_769658051.md).

The class supports three summarization methods:

- [SummarizeAsync](textsummarizer_summarizeasync_822055106.md) — summarizes a block of text.
- [SummarizeParagraphAsync](textsummarizer_summarizeparagraphasync_633554225.md) — summarizes text and returns the result as a paragraph.
- [SummarizeConversationAsync](textsummarizer_summarizeconversationasync_1593584223.md) — summarizes a conversation represented by a collection of [ConversationItem](conversationitem.md) objects, with options controlled by [ConversationSummaryOptions](conversationsummaryoptions.md).

Before calling any summarization method, confirm that the text fits within the model's context window by calling [IsPromptLargerThanContext](textsummarizer_ispromptlargerthancontext_123976394.md).

> [!IMPORTANT]
> Phi Silica features are not available in China.

## -see-also

[Get started with Phi Silica](/windows/ai/apis/phi-silica), [LanguageModel](languagemodel.md), [ConversationItem](conversationitem.md), [ConversationSummaryOptions](conversationsummaryoptions.md), [TextRewriter](textrewriter.md), [TextToTableConverter](texttotableconverter.md)

## -examples

The following example shows how to summarize a block of text.

```csharp
using Microsoft.Windows.AI.Text;

using LanguageModel languageModel = await LanguageModel.CreateAsync();

var textSummarizer = new TextSummarizer(languageModel);
string text = "This is a large amount of text I want to have summarized.";
var result = await textSummarizer.SummarizeAsync(text);

Console.WriteLine(result.Text);
```
