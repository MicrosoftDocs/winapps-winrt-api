---
-api-id: M:Microsoft.Windows.AI.MachineLearning.ExecutionProvider.EnsureReadyAsync
-api-type: winrt method
---

# Microsoft.Windows.AI.MachineLearning.ExecutionProvider.EnsureReadyAsync

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.AI.MachineLearning.ExecutionProviderReadyResult,double> EnsureReadyAsync ();
-->

## -description

Ensures that the execution provider is ready for use by downloading and installing any required components.

## -returns

## -remarks

## -see-also

## -examples

```csharp
var catalog = Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog.GetDefault();
var providers = catalog.FindAllProviders();
foreach (var provider in providers)
{
    await provider.EnsureReadyAsync();
    Console.WriteLine($"Provider {provider.Name} is ready");
}
```

```cppwinrt
auto catalog = winrt::Microsoft::Windows::AI::MachineLearning::ExecutionProviderCatalog::GetDefault();
auto providers = catalog.FindAllProviders();
for (const auto& provider : providers)
{
    provider.EnsureReadyAsync().get();
    std::wcout << L"Provider " << provider.Name().c_str() << L" is ready\n";
}
```

```Python
catalog = winml.ExecutionProviderCatalog.get_default()
providers = catalog.find_all_providers()
for provider in providers:
    provider.ensure_ready_async().get()
    print(f"Provider {provider.name} is ready")
```
