---
-api-id: M:Microsoft.Windows.AI.Text.LanguageModel.CreateAsync
-api-type: winrt method
---

# Microsoft.Windows.AI.Text.LanguageModel.CreateAsync

<!--
public static Windows.Foundation.IAsyncOperation<Microsoft.Windows.AI.Text.LanguageModel> CreateAsync ();
-->

## -description

Asynchronously creates a new instance of the language model object.

## -returns

A language model object.

## -remarks

Call [GetReadyState](languagemodel_getreadystate_1726041729.md) before calling this method. If **GetReadyState** does not return `Ready`, call [EnsureReadyAsync](languagemodel_ensurereadyasync_1335418254.md) first to download and install the model.

The returned **LanguageModel** implements [IDisposable](/dotnet/api/system.idisposable). Use a `using` statement (C#) or call [Close](languagemodel_close_811482585.md) (C++/WinRT) to release model resources when you are done.

## -see-also

[GetReadyState](languagemodel_getreadystate_1726041729.md), [EnsureReadyAsync](languagemodel_ensurereadyasync_1335418254.md), [Get started with Phi Silica](/windows/ai/apis/phi-silica)

## -examples
