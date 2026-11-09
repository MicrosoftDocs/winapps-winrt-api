---
-api-id: M:Microsoft.Windows.AI.Imaging.TextRecognizer.RecognizeTextFromImageAsync(Microsoft.Graphics.Imaging.ImageBuffer)
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.TextRecognizer.RecognizeTextFromImageAsync(Microsoft.Graphics.Imaging.ImageBuffer)

<!--
public Windows.Foundation.IAsyncOperation<Microsoft.Windows.AI.Imaging.RecognizedText> RecognizeTextFromImageAsync (Microsoft.Graphics.Imaging.ImageBuffer imageBuffer);
-->

## -description

Asynchronously recognize text in an image.

## -parameters

### -param imageBuffer

An uncompressed bitmap

## -returns

An asynchronous operation object which, when it completes, contains the result of a text recognition operation on an image.

## -remarks

Asynchronous version of [RecognizeTextFromImage](textrecognizer_recognizetextfromimage_2145955329.md). Use this method when you want to avoid blocking the UI thread. The image must be provided as an [ImageBuffer](/windows/windows-app-sdk/api/winrt/microsoft.graphics.imaging.imagebuffer).

## -see-also

[Get Started with AI Text Recognition (OCR)](/windows/ai/apis/text-recognition), [Text recognizer walkthrough](/windows/ai/apis/text-recognition-tutorial)

## -examples
