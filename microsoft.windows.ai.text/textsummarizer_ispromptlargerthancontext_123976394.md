---
-api-id: M:Microsoft.Windows.AI.Text.TextSummarizer.IsPromptLargerThanContext(Microsoft.Windows.AI.Text.ConversationItem[],Microsoft.Windows.AI.Text.ConversationSummaryOptions,System.UInt64@)
-api-type: winrt method
---

# Microsoft.Windows.AI.Text.TextSummarizer.IsPromptLargerThanContext(Microsoft.Windows.AI.Text.ConversationItem[],Microsoft.Windows.AI.Text.ConversationSummaryOptions,System.UInt64@)

<!--
public bool IsPromptLargerThanContext (Microsoft.Windows.AI.Text.ConversationItem[] messages, Microsoft.Windows.AI.Text.ConversationSummaryOptions options, out ulong cutoffPosition);
-->

## -description

Returns whether the text of a conversation is too large for the context window.

## -parameters

### -param messages

The collection of conversation posts and responses to summarize.

### -param options

The configuration options for summarizing a conversation.

### -param cutoffPosition

The location in the text input where truncation occurs based on the size of the context window.

## -returns

True, if the text input is too large; otherwise, false. The default is false.

## -remarks

A context window acts like the model's short-term memory, holding the input prompt and the preceding conversation to maintain coherence. A larger context window enables more detailed conversations and processes larger documents but increases processing time, cost, and potentially reduces accuracy.

## -see-also

## -examples
