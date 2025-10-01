---
-api-id: M:Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog.FindAllProviders
-api-type: winrt method
---

# Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog.FindAllProviders

<!--
public Microsoft.Windows.AI.MachineLearning.ExecutionProvider[] FindAllProviders ();
-->


## -description

Retrieves a collection of all execution providers compatible with the current hardware.

## -returns

A collection of all execution providers compatible with the current hardware.

## -remarks

## -see-also

## -examples

```csharp
var catalog = Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog.GetDefault();
var providers = catalog.FindAllProviders();
foreach (var provider in providers)
{
    Console.WriteLine($"Found provider: {provider.Name}, Type: {provider.DeviceType}");
}
```

```cppwinrt
auto catalog = winrt::Microsoft::Windows::AI::MachineLearning::ExecutionProviderCatalog::GetDefault();
auto providers = catalog.FindAllProviders();
for (const auto& provider : providers)
{
    std::wcout << L"Found provider: " << provider.Name().c_str() 
              << L", Type: " << static_cast<int>(provider.DeviceType()) << L"\n";
}
```

```Python
catalog = winml.ExecutionProviderCatalog.get_default()
providers = catalog.find_all_providers()
for provider in providers:
    print(f"Found provider: {provider.name}, Type: {provider.device_type}")
```
