---
-api-id: M:Microsoft.Windows.AI.Imaging.TextRecognizer.GetReadyState
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.TextRecognizer.GetReadyState

<!--
public static Microsoft.Windows.AI.AIFeatureReadyState GetReadyState ();
-->

## -description

Retrieves the state of the underlying language model.

## -returns

The state of the underlying language model.

Returns `Ready` if the underlying language model is installed.

## -remarks

Use this method to check whether the text recognition model is available on the device before calling [CreateAsync](textrecognizer_createasync_616540418.md). If the returned state is `EnsureNeeded`, call [EnsureReadyAsync](textrecognizer_ensurereadyasync_1335418254.md) to download and install the model.

## -see-also

[Get Started with AI Text Recognition (OCR)](/windows/ai/apis/text-recognition), [Text recognizer walkthrough](/windows/ai/apis/text-recognition-tutorial)

## -examples
