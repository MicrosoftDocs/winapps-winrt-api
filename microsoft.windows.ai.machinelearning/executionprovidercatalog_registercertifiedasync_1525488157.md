---
-api-id: M:Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog.RegisterCertifiedAsync
-api-type: winrt method
---

# Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog.RegisterCertifiedAsync

<!--
public Windows.Foundation.IAsyncOperationWithProgress<System.Collections.Generic.IList<Microsoft.Windows.AI.MachineLearning.ExecutionProvider>,double> RegisterCertifiedAsync ();
-->


## -description

Registers all compatible execution providers with the ONNX Runtime without ensuring they are ready. This registers only providers that are already present on the machine, avoiding the potentially long download times that might be required by [EnsureAndRegisterCertifiedAsync](./executionprovidercatalog_ensureandregistercertifiedasync_1948987701.md).

## -returns

## -remarks

## -see-also

## -examples

```csharp
var catalog = Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog.GetDefault();
await catalog.RegisterCertifiedAsync();
```

```cppwinrt
auto catalog = winrt::Microsoft::Windows::AI::MachineLearning::ExecutionProviderCatalog::GetDefault();
catalog.RegisterCertifiedAsync().get();
```

```Python
# DO NOT call this method in Python.
```
