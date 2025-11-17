---
-api-id: M:Microsoft.Windows.AI.MachineLearning.ExecutionProvider.TryRegister
-api-type: winrt method
---

# Microsoft.Windows.AI.MachineLearning.ExecutionProvider.TryRegister

<!--
public bool TryRegister ();
-->

## -description

Attempts to register the execution provider with ONNX Runtime.

## -returns

True, if successful; otherwise, false.

## -remarks

## -see-also

## -examples

```csharp
var catalog = Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog.GetDefault();
var providers = catalog.FindAllProviders();
foreach (var provider in providers)
{
    await provider.EnsureReadyAsync();
    bool registered = provider.TryRegister();
    Console.WriteLine($"Provider {provider.Name} registration: {(registered ? "Success" : "Failed")}");
}
```

```cppwinrt
auto catalog = winrt::Microsoft::Windows::AI::MachineLearning::ExecutionProviderCatalog::GetDefault();
auto providers = catalog.FindAllProviders();
for (const auto& provider : providers)
{
    provider.EnsureReadyAsync().get();
    bool registered = provider.TryRegister();
    std::wcout << L"Provider " << provider.Name().c_str() 
              << L" registration: " << (registered ? L"Success" : L"Failed") << L"\n";
}
```

```Python
catalog = winml.ExecutionProviderCatalog.get_default()
providers = catalog.find_all_providers()
for provider in providers:
    provider.ensure_ready_async().get()
    # DO NOT call try_register in Python.
    # Use the name and library_path to directly register with onnxruntime.
    ort.register_execution_provider_library(provider.name, provider.library_path)
    print(f"Registered execution provider: {provider.name}")
```
