---
-api-id: M:Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog.GetDefault
-api-type: winrt method
---

# Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog.GetDefault

<!--
public static Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog GetDefault ();
-->


## -description

Retrieves the default [ExecutionProviderCatalog](./executionprovidercatalog.md) instance that provides access to all execution providers on the system.

## -returns

## -remarks

## -see-also

## -examples

```csharp
var catalog = Microsoft.Windows.AI.MachineLearning.ExecutionProviderCatalog.GetDefault();
```

```cppwinrt
auto catalog = winrt::Microsoft::Windows::AI::MachineLearning::ExecutionProviderCatalog::GetDefault();
```

```Python
catalog = winml.ExecutionProviderCatalog.get_default()
```
