---
-api-id: P:Microsoft.Windows.ApplicationModel.DynamicDependency.CreatePackageDependencyOptions.LifetimeArtifact
-api-type: winrt property
---

# Microsoft.Windows.ApplicationModel.DynamicDependency.CreatePackageDependencyOptions.LifetimeArtifact

<!--
public string LifetimeArtifact { get; set; }
-->


## -description

Gets or sets the name of the artifact used to define the lifetime of the package dependency, if the [LifetimeArtifactKind](createpackagedependencyoptions_lifetimeartifactkind.md) property is set to **PackageDependencyLifetimeArtifactKind.FilePath** or **PackageDependencyLifetimeArtifactKind.RegistryKey**.

## -property-value

## -remarks

Do not use this property if the [LifetimeArtifactKind](createpackagedependencyoptions_lifetimeartifactkind.md) property is set to **PackageDependencyLifetimeArtifactKind.Process**.

## -see-also

[LifetimeArtifactKind](createpackagedependencyoptions_lifetimeartifactkind.md), [PackageDependency.Create](packagedependency_create_1812482144.md)

## -examples


