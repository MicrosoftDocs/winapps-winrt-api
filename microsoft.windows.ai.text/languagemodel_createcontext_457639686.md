---
-api-id: M:Microsoft.Windows.AI.Text.LanguageModel.CreateContext(System.String,Microsoft.Windows.AI.ContentSafety.ContentFilterOptions)
-api-type: winrt method
---

# Microsoft.Windows.AI.Text.LanguageModel.CreateContext(System.String,Microsoft.Windows.AI.ContentSafety.ContentFilterOptions)

<!--
public Microsoft.Windows.AI.Text.LanguageModelContext CreateContext (string systemPrompt, Microsoft.Windows.AI.ContentSafety.ContentFilterOptions contentFilterOptions);
-->

## -description

Returns a context window that defines the tokens a language model can process at one time for understanding an input prompt and then generating a response.

## -parameters

### -param systemPrompt

The string prompt.

### -param contentFilterOptions

Options that affect how the language model filters responses to the prompt.

## -returns

A context window

## -remarks

A context window acts like the model's short-term memory, holding the input prompt and the preceding conversation to maintain coherence. A larger context window enables more detailed conversations and processes larger documents but increases processing time, cost, and potentially reduces accuracy.

## -see-also

## -examples
