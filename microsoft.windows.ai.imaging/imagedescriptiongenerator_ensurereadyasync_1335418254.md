---
-api-id: M:Microsoft.Windows.AI.Imaging.ImageDescriptionGenerator.EnsureReadyAsync
-api-type: winrt method
---

# Microsoft.Windows.AI.Imaging.ImageDescriptionGenerator.EnsureReadyAsync

<!--
public static Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.AI.AIFeatureReadyResult,double> EnsureReadyAsync ();
-->

## -description

Ensures that the [ImageDescriptionGenerator](imagedescriptiongenerator.md) is ready for use by downloading and installing any required components.

## -returns

An asynchronous operation with progress object that returns an [AIFeatureReadyResult](../microsoft.windows.ai/aifeaturereadyresult.md) on completion.

## -remarks

Call [GetReadyState](imagedescriptiongenerator_getreadystate_1726041729.md) before calling this method to determine whether the model needs to be installed. If the model is already ready, you can skip calling **EnsureReadyAsync** and proceed directly to [CreateAsync](imagedescriptiongenerator_createasync_616540418.md).

## -see-also

[Get Started with AI Imaging](/windows/ai/apis/imaging)

## -examples
