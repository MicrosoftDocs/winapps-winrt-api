---
-api-id: T:Microsoft.Windows.AI.Imaging.RecognizedText
-api-type: winrt class
---

# Microsoft.Windows.AI.Imaging.RecognizedText

<!--
public sealed class RecognizedText
-->

## -description

Represents the result of a text recognition operation on an image.

## -remarks

**RecognizedText** contains the full result of a text recognition (OCR) operation performed by [TextRecognizer](textrecognizer.md). Access the [Lines](recognizedtext_lines.md) property to iterate over each [RecognizedLine](recognizedline.md) detected in the image. Each line in turn contains individual [RecognizedWord](recognizedword.md) objects with bounding boxes and confidence scores.

## -see-also

[RecognizeTextFromImage](textrecognizer_recognizetextfromimage_2145955329.md), [RecognizeTextFromImageAsync](textrecognizer_recognizetextfromimageasync_356575282.md), [Get Started with AI Text Recognition (OCR)](/windows/ai/apis/text-recognition), [Text recognizer walkthrough](/windows/ai/apis/text-recognition-tutorial)

## -examples
