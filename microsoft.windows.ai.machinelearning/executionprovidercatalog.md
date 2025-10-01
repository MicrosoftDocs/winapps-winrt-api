---
-api-id: T:Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog
-api-type: winrt class
---

# Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog

<!--
public sealed class ExecutionProviderCatalog
-->


## -description

Provides methods to discover, acquire, and register AI execution providers (EPs) for use with the ONNX Runtime.

**ExecutionProviderCatalog** handles the complexity of package management and hardware selection, and it's the entry point for your app to access hardware-optimized machine learning acceleration through the Windows ML runtime.

## -remarks

## -see-also

## -examples

```csharp
// Get the default catalog
var catalog = Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog.GetDefault();
// Ensure and register all compatible execution providers
await catalog.EnsureAndRegisterCertifiedAsync();
// Use ONNX Runtime directly for inference (using Microsoft.ML.OnnxRuntime namespace)
```

```cppwinrt
// Get the default catalog
winrt::Microsoft::Windows::AI::MachineLearning::ExecutionProviderCatalog catalog = 
    winrt::Microsoft::Windows::AI::MachineLearning::ExecutionProviderCatalog::GetDefault();
// Ensure and register all compatible execution providers
catalog.EnsureAndRegisterCertifiedAsync().get();
// Use ONNX Runtime C API directly for inference
```

```Python
import winui3.microsoft.windows.ai.machinelearning as winml
# Get the default catalog
catalog = winml.ExecutionProviderCatalog.get_default()
# DO NOT call winml's register methods in Python. Those will not work for the onnxruntime Python environment.
# Instead, register execution providers following this pattern:
providers = catalog.find_all_providers()
    for provider in providers:
        provider.ensure_ready_async().get()
        ort.register_execution_provider_library(provider.name, provider.library_path)
```
