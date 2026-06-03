---
-api-id: T:Microsoft.Windows.AI.Text.TextToTableConverter
-api-type: winrt class
---

# Microsoft.Windows.AI.Text.TextToTableConverter

<!--
public sealed class TextToTableConverter
-->

## -description

Represents a specialized lanugage model capable of formatting text input into a table.

## -remarks

**TextToTableConverter** is a Text Intelligence Skill that uses a local [LanguageModel](languagemodel.md) to format text into a structured table. You create an instance by passing a **LanguageModel** to the [TextToTableConverter constructor](texttotableconverter_texttotableconverter_769658051.md).

Call [ConvertAsync](texttotableconverter_convertasync_1749572750.md) to convert text into a [TextToTableResponseResult](texttotableresponseresult.md). The result contains rows accessible through [GetRows](texttotableresponseresult_getrows_1751622459.md), where each [TextToTableRow](texttotablerow.md) provides column values through [GetColumns](texttotablerow_getcolumns_2060251348.md).

> [!IMPORTANT]
> Phi Silica features are not available in China.

## -see-also

[Get started with Phi Silica](/windows/ai/apis/phi-silica), [LanguageModel](languagemodel.md), [TextToTableResponseResult](texttotableresponseresult.md), [TextToTableRow](texttotablerow.md), [TextSummarizer](textsummarizer.md), [TextRewriter](textrewriter.md)

## -examples
