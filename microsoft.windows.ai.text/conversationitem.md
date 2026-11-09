---
-api-id: T:Microsoft.Windows.AI.Text.ConversationItem
-api-type: winrt class
---

# Microsoft.Windows.AI.Text.ConversationItem

<!--
public sealed class ConversationItem
-->

## -description

Represents the messages in a conversation.

## -remarks

A **ConversationItem** represents a single message in a conversation. Each item has a [Message](conversationitem_message.md) property containing the message text and a [Participant](conversationitem_participant.md) property identifying who sent the message.

You use a collection of **ConversationItem** objects as input to [TextSummarizer.SummarizeConversationAsync](textsummarizer_summarizeconversationasync_1593584223.md) to produce a summary of a multi-turn conversation. Use [ConversationSummaryOptions](conversationsummaryoptions.md) to control how the summary is generated.

## -see-also

[TextSummarizer](textsummarizer.md), [ConversationSummaryOptions](conversationsummaryoptions.md), [TextSummarizer.SummarizeConversationAsync](textsummarizer_summarizeconversationasync_1593584223.md)

## -examples
