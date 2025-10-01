---
-api-id: M:Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog.EnsureAndRegisterAllAsync
-api-type: winrt method
---

# Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog.EnsureAndRegisterAllAsync

<!--
public Windows.Foundation.IAsyncOperationWithProgress<System.Collections.Generic.IList<Microsoft.Windows.AI.MachineLearning.ExecutionProvider>,double> EnsureAndRegisterAllAsync ();
-->


## -description

Ensures that all compatible execution providers are ready, and registers them with the ONNX Runtime.

## -returns

## -remarks

## -see-also

## -examples

```csharp
var catalog = Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog.GetDefault();
try
{
    // This will ensure providers are ready and register them with ONNX Runtime
    await catalog.EnsureAndRegisterCertifiedAsync();
    Console.WriteLine("All execution providers are ready and registered");
}
catch (Exception ex)
{
    Console.WriteLine($"Failed to prepare execution providers: {ex.Message}");
}
```

```cppwinrt
auto catalog = winrt::Microsoft::Windows::AI::MachineLearning::ExecutionProviderCatalog::GetDefault();
try 
{
    // This will ensure providers are ready and register them with ONNX Runtime
    catalog.EnsureAndRegisterCertifiedAsync().get();
    std::wcout << L"All execution providers are ready and registered\n";
}
catch (const winrt::hresult_error& ex) 
{
    std::wcout << L"Failed to prepare execution providers: " << ex.message().c_str() << L"\n";
}
```

```Python
# DO NOT call this method in Python. 
# Onnxruntime's Python and native environments are separate.
# This method will not work for the onnxruntime Python environment.
```
