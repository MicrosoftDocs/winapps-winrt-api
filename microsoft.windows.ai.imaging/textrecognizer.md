---
-api-id: T:Microsoft.Windows.AI.Imaging.TextRecognizer
-api-type: winrt class
---

# Microsoft.Windows.AI.Imaging.TextRecognizer

<!--
public sealed class TextRecognizer : System.IDisposable
-->

## -description

Represents an object that can perform AI-based optical character recognition (OCR) within an image and detect, extract, and convert text into a character stream.

## -remarks

**TextRecognizer** performs AI-powered optical character recognition (OCR) on images using hardware acceleration on devices with a neural processing unit (NPU). It is faster and more accurate than the legacy [Windows.Media.Ocr.OcrEngine](/uwp/api/windows.media.ocr.ocrengine) APIs.

Before creating a **TextRecognizer** instance, call [GetReadyState](textrecognizer_getreadystate_1726041729.md) to check whether the model is available on the device. If the model is not ready, call [EnsureReadyAsync](textrecognizer_ensurereadyasync_1335418254.md) to download and prepare it. Then call [CreateAsync](textrecognizer_createasync_616540418.md) to create an instance.

Call [RecognizeTextFromImage](textrecognizer_recognizetextfromimage_2145955329.md) or [RecognizeTextFromImageAsync](textrecognizer_recognizetextfromimageasync_356575282.md) with an [ImageBuffer](/windows/windows-app-sdk/api/winrt/microsoft.graphics.imaging.imagebuffer) to get a [RecognizedText](recognizedtext.md) result containing detected lines, words, bounding boxes, and confidence levels.

The **TextRecognizer** class implements [IDisposable](/dotnet/api/system.idisposable), so you should use a `using` statement (C#) or call **Close** (C++/WinRT) to release resources when you are done.

## -see-also

[Get Started with AI Text Recognition (OCR)](/windows/ai/apis/text-recognition), [Text recognizer walkthrough](/windows/ai/apis/text-recognition-tutorial)

## -examples
