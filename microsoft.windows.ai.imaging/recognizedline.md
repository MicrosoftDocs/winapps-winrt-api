---
-api-id: T:Microsoft.Windows.AI.Imaging.RecognizedLine
-api-type: winrt class
---

# Microsoft.Windows.AI.Imaging.RecognizedLine

<!--
public sealed class RecognizedLine
-->

## -description

Represents a single line of text in an image detected by text recognition.

## -remarks

A **RecognizedLine** represents a single line of text detected within an image by the [TextRecognizer](textrecognizer.md). Access the [Text](recognizedline_text.md) property to get the full text of the line, the [Words](recognizedline_words.md) property to iterate over individual [RecognizedWord](recognizedword.md) objects, and the [Style](recognizedline_style.md) property to check whether the text appears handwritten (with a confidence level from [LineStyleConfidence](recognizedline_linestyleconfidence.md)).

## -see-also

[Get Started with AI Text Recognition (OCR)](/windows/ai/apis/text-recognition), [Text recognizer walkthrough](/windows/ai/apis/text-recognition-tutorial)

## -examples
