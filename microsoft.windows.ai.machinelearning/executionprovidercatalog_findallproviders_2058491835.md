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
    Console.WriteLine($"Found provider: {provider.Name}, Library path: {provider.LibraryPath}");
}
```

```cppwinrt
auto catalog = winrt::Microsoft::Windows::AI::MachineLearning::ExecutionProviderCatalog::GetDefault();
auto providers = catalog.FindAllProviders();
for (const auto& provider : providers)
{
    std::wcout << L"Found provider: " << provider.Name().c_str() 
              << L", Library path: " << provider.LibraryPath().c_str() << L"\n";
}
```

```Python
catalog = winml.ExecutionProviderCatalog.get_default()
providers = catalog.find_all_providers()
for provider in providers:
    print(f"Found provider: {provider.name}, Library path: {provider.library_path}")
```
