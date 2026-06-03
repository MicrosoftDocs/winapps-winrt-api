---
-api-id: M:Microsoft.Windows.AI.Text.LanguageModel.GetReadyState
-api-type: winrt method
---

# Microsoft.Windows.AI.Text.LanguageModel.GetReadyState

<!--
public static Microsoft.Windows.AI.AIFeatureReadyState GetReadyState ();
-->

## -description

Returns the readiness state of the language model.

## -returns

The readiness state of the language model.

## -remarks

Use this method to check whether the language model is available on the device before calling [CreateAsync](languagemodel_createasync_616540418.md). If the returned state is `NotReady`, call [EnsureReadyAsync](languagemodel_ensurereadyasync_1335418254.md) to download and install the model.

## -see-also

[EnsureReadyAsync](languagemodel_ensurereadyasync_1335418254.md), [CreateAsync](languagemodel_createasync_616540418.md), [Get started with Phi Silica](/windows/ai/apis/phi-silica)

## -examples

```csharp
if (LanguageModel.GetReadyState() == AIFeatureReadyState.NotReady) 
{ 
    var op = await LanguageModel.EnsureReadyAsync(); 
}
```
