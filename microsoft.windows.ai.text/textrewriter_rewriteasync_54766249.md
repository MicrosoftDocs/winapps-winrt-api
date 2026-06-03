---
-api-id: M:Microsoft.Windows.AI.Text.TextRewriter.RewriteAsync(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AI.Text.TextRewriter.RewriteAsync(System.String)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.AI.Text.LanguageModelResponseResult,string> RewriteAsync (string text);
-->

## -description

Rewrites the text provided in the [default](textrewritetone.md) tone.

## -parameters

### -param text

The text to rewrite.

## -returns

The rewritten text in the [default](textrewritetone.md) tone.

## -remarks

Rewrites the text using the default tone. The rewriter corrects spelling and grammar errors, enhances word choice, and optimizes clarity and readability while preserving the original meaning.

The operation reports progress as each token is generated. Check the [Status](languagemodelresponseresult_status.md) property of the returned [LanguageModelResponseResult](languagemodelresponseresult.md) and read the rewritten text from the [Text](languagemodelresponseresult_text.md) property.

To specify a particular tone, use the [RewriteAsync(String, TextRewriteTone)](textrewriter_rewriteasync_2021107407.md) overload.

## -see-also

[RewriteAsync(String, TextRewriteTone)](textrewriter_rewriteasync_2021107407.md), [TextRewriteTone](textrewritetone.md), [LanguageModelResponseResult](languagemodelresponseresult.md)

## -examples
