---
-api-id: M:Microsoft.Windows.AI.Imaging.TextRecognizer.EnsureReadyAsync
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.TextRecognizer.EnsureReadyAsync

<!--
public static Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.AI.AIFeatureReadyResult,double> EnsureReadyAsync ();
-->

## -description

Ensures that the [TextRecognizer](textrecognizer.md) is ready for use by downloading and installing any required components.

## -returns

An asynchronous operation with progress object that returns an [AIFeatureReadyResult](../microsoft.windows.ai/aifeaturereadyresult.md) on completion.

## -remarks

Call [GetReadyState](textrecognizer_getreadystate_1726041729.md) before calling this method to determine whether the model needs to be installed. If the model is already ready, you can skip calling **EnsureReadyAsync** and proceed directly to [CreateAsync](textrecognizer_createasync_616540418.md).

The progress value (a `double` between 0 and 1) indicates the download and installation progress. Check the [AIFeatureReadyResult.Status](../microsoft.windows.ai/aifeaturereadyresult_status.md) property to confirm success.

## -see-also

[Get Started with AI Text Recognition (OCR)](/windows/ai/apis/text-recognition), [Text recognizer walkthrough](/windows/ai/apis/text-recognition-tutorial)

## -examples
