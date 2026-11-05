---
-api-id: T:Microsoft.Windows.AI.Text.TextRewriter
-api-type: winrt class
---

# Microsoft.Windows.AI.Text.TextRewriter

<!--
public sealed class TextRewriter
-->

## -description

Represents a specialized language model capable of rewriting text input.

## -remarks

**TextRewriter** is a Text Intelligence Skill that uses a local [LanguageModel](languagemodel.md) to rephrase text. You create an instance by passing a **LanguageModel** to the [TextRewriter constructor](textrewriter_textrewriter_769658051.md).

The rewriter corrects spelling and grammar errors, enhances word choice, and optimizes clarity and readability while preserving the original meaning and intent. You can optionally specify a [TextRewriteTone](textrewritetone.md) to control the style of the rewritten output (for example, professional, casual, or friendly).

Call [RewriteAsync](textrewriter_rewriteasync_54766249.md) with the text you want to rewrite. An overload accepts a **TextRewriteTone** parameter to change the output style.

> [!IMPORTANT]
> Phi Silica features are not available in China.

## -see-also

[Get started with Phi Silica](/windows/ai/apis/phi-silica), [LanguageModel](languagemodel.md), [TextRewriteTone](textrewritetone.md), [TextSummarizer](textsummarizer.md), [TextToTableConverter](texttotableconverter.md)

## -examples
