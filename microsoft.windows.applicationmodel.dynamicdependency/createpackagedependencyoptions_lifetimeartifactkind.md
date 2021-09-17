---
-api-id: P:Microsoft.Windows.ApplicationModel.DynamicDependency.CreatePackageDependencyOptions.LifetimeArtifactKind
-api-type: winrt property
---

# Microsoft.Windows.ApplicationModel.DynamicDependency.CreatePackageDependencyOptions.LifetimeArtifactKind

<!--
public Microsoft.Windows.ApplicationModel.DynamicDependency.PackageDependencyLifetimeArtifactKind LifetimeArtifactKind { get; set; }
-->


## -description

Gets or sets the type of artifact to use to define the lifetime of the package dependency.

## -property-value

The type of artifact to use to define the lifetime of the package dependency.

## -remarks

The lifetime artifact can be the current process, a file, or a registry key that indicates to the system that the app is still available. If the specified artifact no longer exists, the OS can assume the dependency is no longer needed and it can uninstall the framework package if no other apps have declared a dependency on it. This feature is useful for scenarios where an app neglects to remove the install-time pin when it is uninstalled.

If you set this property to **PackageDependencyLifetimeArtifactKind.FilePath** or **PackageDependencyLifetimeArtifactKind.RegistryKey**, use the [LifetimeArtifact](createpackagedependencyoptions_lifetimeartifact.md) property to specify the name of the artifact.

## -see-also

[LifetimeArtifact](createpackagedependencyoptions_lifetimeartifact.md), [PackageDependency.Create](packagedependency_create_1812482144.md)

## -examples
