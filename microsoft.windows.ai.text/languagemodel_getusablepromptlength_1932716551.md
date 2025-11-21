---
-api-id: M:Microsoft.Windows.AI.Text.LanguageModel.GetUsablePromptLength(Microsoft.Windows.AI.Text.LanguageModelContext,System.String)
-api-type: winrt method
---

# Microsoft.Windows.AI.Text.LanguageModel.GetUsablePromptLength(Microsoft.Windows.AI.Text.LanguageModelContext,System.String)

<!--
public ulong GetUsablePromptLength (Microsoft.Windows.AI.Text.LanguageModelContext context, string prompt);
-->

## -description

Returns the index in the given prompt where the given context window reached the maximum number of supported tokens.

## -parameters

### -param context

The context window.

### -param prompt

The input prompt.

## -returns

The index in the given prompt where the given context window reached the maximum number of supported tokens.

## -remarks

Can be used to trim a prompt to fit in the context window.

Language models translate human language prompts into tokens.

A token is the basic unit of information that a language model uses to understand prompts and generate responses. A text token can be a single character, a word fragment (or subword), or a complete word.

A context window defines the maximum number of tokens a language model can process at one time for understanding an input prompt and then generating a response. The context window acts like the model's short-term memory, holding the input prompt and the preceding conversation to maintain coherence. A larger context window enables more detailed conversations and processes larger documents but increases processing time, cost, and potentially reduces accuracy.

## -see-also

## -examples
