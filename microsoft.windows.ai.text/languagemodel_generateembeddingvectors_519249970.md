---
-api-id: M:Microsoft.Windows.AI.Text.LanguageModel.GenerateEmbeddingVectors(System.String,Microsoft.Windows.AI.ContentSafety.ContentFilterOptions)
-api-type: winrt method
---

# Microsoft.Windows.AI.Text.LanguageModel.GenerateEmbeddingVectors(System.String,Microsoft.Windows.AI.ContentSafety.ContentFilterOptions)

<!--
public Microsoft.Windows.AI.Text.LanguageModelEmbeddingVectorResult GenerateEmbeddingVectors (string prompt, Microsoft.Windows.AI.ContentSafety.ContentFilterOptions contentFilterOptions);
-->

## -description

Returns an embedding vector representing the string prompt.

## -parameters

### -param prompt

The string prompt.

### -param contentFilterOptions

Options that affect how the language model filters responses to the prompt.

## -returns

## -remarks

Language models translate human language prompts into tokens.

A token is the basic unit of information that a language model uses to understand prompts and generate responses. A text token can be a single character, a word fragment (or subword), or a complete word.

Embeddings are tokens that have been transformed into a format that the language model can interpret and learn from. These transformations are typically represented as high-dimensional mathematical vector spaces (much more than the usual two or three dimensions), with each dimension representing a different feature or aspect of data.

## -see-also

## -examples
