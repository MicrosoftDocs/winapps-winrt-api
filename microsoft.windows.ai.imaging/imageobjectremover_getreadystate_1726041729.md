---
-api-id: M:Microsoft.Windows.AI.Imaging.ImageObjectRemover.GetReadyState
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.ImageObjectRemover.GetReadyState

<!--
public static Microsoft.Windows.AI.AIFeatureReadyState GetReadyState ();
-->

## -description

Retrieves the state of the underlying language model.

## -returns

The state of the underlying language model.

Returns `Ready` if the underlying language model is installed.

## -remarks

Use this method to check whether the object removal model is available on the device before calling [CreateAsync](imageobjectremover_createasync_616540418.md). If the returned state is `NotReady`, call [EnsureReadyAsync](imageobjectremover_ensurereadyasync_1335418254.md) to download and install the model.

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
