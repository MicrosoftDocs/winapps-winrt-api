---
-api-id: M:Microsoft.Windows.AI.Imaging.TextRecognizer.RecognizeTextFromImage(Microsoft.Graphics.Imaging.ImageBuffer)
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.TextRecognizer.RecognizeTextFromImage(Microsoft.Graphics.Imaging.ImageBuffer)

<!--
public Microsoft.Windows.AI.Imaging.RecognizedText RecognizeTextFromImage (Microsoft.Graphics.Imaging.ImageBuffer imageBuffer);
-->

## -description

Recognize text in an image.

## -parameters

### -param imageBuffer

An uncompressed bitmap

## -returns

The result of a text recognition operation on an image.

## -remarks

Performs synchronous text recognition on the image. The image must be provided as an [ImageBuffer](/windows/windows-app-sdk/api/winrt/microsoft.graphics.imaging.imagebuffer), which you can create from a [SoftwareBitmap](/uwp/api/windows.graphics.imaging.softwarebitmap) using `ImageBuffer.CreateBufferAttachedToBitmap` (C#) or `ImageBuffer.CreateForSoftwareBitmap` (C++/WinRT).

The returned [RecognizedText](recognizedtext.md) contains a collection of [RecognizedLine](recognizedline.md) objects. Each line provides the recognized [Text](recognizedline_text.md), individual [Words](recognizedline_words.md) with bounding boxes and confidence scores, and a [Style](recognizedline_style.md) indicator (handwritten vs. printed).

For asynchronous processing, use [RecognizeTextFromImageAsync](textrecognizer_recognizetextfromimageasync_356575282.md) instead.

## -see-also

[Get Started with AI Text Recognition (OCR)](/windows/ai/apis/text-recognition), [Text recognizer walkthrough](/windows/ai/apis/text-recognition-tutorial)

## -examples
