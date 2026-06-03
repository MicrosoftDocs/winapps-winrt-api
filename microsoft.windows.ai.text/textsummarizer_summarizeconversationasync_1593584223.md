---
-api-id: M:Microsoft.Windows.AI.Text.TextSummarizer.SummarizeConversationAsync(Windows.Foundation.Collections.IVectorView{Microsoft.Windows.AI.Text.ConversationItem},Microsoft.Windows.AI.Text.ConversationSummaryOptions)
-api-type: winrt method
---

# Microsoft.Windows.AI.Text.TextSummarizer.SummarizeConversationAsync(Windows.Foundation.Collections.IVectorView{Microsoft.Windows.AI.Text.ConversationItem},Microsoft.Windows.AI.Text.ConversationSummaryOptions)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.AI.Text.LanguageModelResponseResult,string> SummarizeConversationAsync (System.Collections.Generic.IReadOnlyList<Microsoft.Windows.AI.Text.ConversationItem> messages, Microsoft.Windows.AI.Text.ConversationSummaryOptions options);
-->

## -description

Asynchronously summarizes the text of a conversation.

## -parameters

### -param messages

The collection of conversation posts and responses to summarize.

### -param options

The configuration options for summarizing a conversation.

## -returns

The summarized text.

## -remarks

Summarizes a multi-turn conversation represented by a collection of [ConversationItem](conversationitem.md) objects. Each **ConversationItem** contains a [Message](conversationitem_message.md) and a [Participant](conversationitem_participant.md) name.

Use the [ConversationSummaryOptions](conversationsummaryoptions.md) parameter to control whether the summary includes message citations, participant attribution, and to set the maximum number of key points.

## -see-also

[SummarizeAsync](textsummarizer_summarizeasync_822055106.md), [ConversationItem](conversationitem.md), [ConversationSummaryOptions](conversationsummaryoptions.md)

## -examples
