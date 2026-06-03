---
-api-id: M:Microsoft.Windows.AI.Text.TextRewriter.RewriteAsync(System.String,Microsoft.Windows.AI.Text.TextRewriteTone)
-api-type: winrt method
---

# Microsoft.Windows.AI.Text.TextRewriter.RewriteAsync(System.String,Microsoft.Windows.AI.Text.TextRewriteTone)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.AI.Text.LanguageModelResponseResult,string> RewriteAsync (string text, Microsoft.Windows.AI.Text.TextRewriteTone tone);
-->

## -description

Rewrites the text provided in the specified tone.

## -parameters

### -param text

The text to rewrite.

### -param tone

The tone in which to rewrite the text.

## -returns

The rewritten text in the specified tone.

## -remarks

Rewrites the text using the specified [TextRewriteTone](textrewritetone.md), which controls the style of the output (for example, professional, casual, or friendly). The rewriter corrects spelling and grammar errors, enhances word choice, and optimizes clarity and readability while preserving the original meaning.

## -see-also

[RewriteAsync(String)](textrewriter_rewriteasync_54766249.md), [TextRewriteTone](textrewritetone.md), [LanguageModelResponseResult](languagemodelresponseresult.md)

## -examples
