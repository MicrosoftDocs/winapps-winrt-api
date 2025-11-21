---
-api-id: M:Microsoft.Windows.AI.Text.TextSummarizer.IsPromptLargerThanContext(System.String,System.UInt64@)
-api-type: winrt method
---

# Microsoft.Windows.AI.Text.TextSummarizer.IsPromptLargerThanContext(System.String,System.UInt64@)

<!--
public bool IsPromptLargerThanContext (string text, out ulong cutoffPosition);
-->

## -description

Returns whether the text input is too large for the context window.

## -parameters

### -param text [in]

The text to summarize.

### -param cutoffPosition [out]

The location in the text input where truncation occurs based on the size of the context window.

## -returns

True, if the text input is too large; otherwise, false. The default is false.

## -remarks

A context window acts like the model's short-term memory, holding the input prompt and the preceding conversation to maintain coherence. A larger context window enables more detailed conversations and processes larger documents but increases processing time, cost, and potentially reduces accuracy.

## -see-also

## -examples
