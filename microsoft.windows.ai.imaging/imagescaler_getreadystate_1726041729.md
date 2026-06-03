---
-api-id: M:Microsoft.Windows.AI.Imaging.ImageScaler.GetReadyState
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.ImageScaler.GetReadyState

<!--
public static Microsoft.Windows.AI.AIFeatureReadyState GetReadyState ();
-->

## -description

Retrieves the state of the underlying language model.

## -returns

The state of the underlying language model.

Returns `Ready` if the underlying language model is installed.

## -remarks

Use this method to check whether the image scaling model is available on the device before calling [CreateAsync](imagescaler_createasync_616540418.md). If the returned state is `NotReady`, call [EnsureReadyAsync](imagescaler_ensurereadyasync_1335418254.md) to download and install the model.

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging), [Image scaler walkthrough](/windows/ai/apis/imaging-tutorial)

## -examples
