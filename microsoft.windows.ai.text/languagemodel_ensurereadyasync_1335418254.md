---
-api-id: M:Microsoft.Windows.AI.Text.LanguageModel.EnsureReadyAsync
-api-type: winrt method
---

# Microsoft.Windows.AI.Text.LanguageModel.EnsureReadyAsync

<!--
public static Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.AI.AIFeatureReadyResult,double> EnsureReadyAsync ();
-->

## -description

Ensures the underlying language model is ready for use by downloading and installing any required components.

## -returns

An asynchronous action with progress object that returns an [AIFeatureReadyResult](../microsoft.windows.ai/aifeaturereadyresult.md) on completion.

## -remarks

Call [GetReadyState](languagemodel_getreadystate_1726041729.md) before calling this method to determine whether the model needs to be installed. If the model is already ready, you can skip calling **EnsureReadyAsync** and proceed directly to [CreateAsync](languagemodel_createasync_616540418.md).

The progress value (a `double` between 0 and 1) indicates the download and installation progress.

Check the [AIFeatureReadyResult.Status](../microsoft.windows.ai/aifeaturereadyresult_status.md) property of the returned result to confirm that the operation completed successfully. If it did not succeed, call [AIFeatureReadyResult.ExtendedError](../microsoft.windows.ai/aifeaturereadyresult_extendederror.md) for diagnostic details.

## -see-also

[GetReadyState](languagemodel_getreadystate_1726041729.md), [CreateAsync](languagemodel_createasync_616540418.md), [Get started with Phi Silica](/windows/ai/apis/phi-silica)

## -examples
