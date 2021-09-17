---
-api-id: T:Microsoft.Windows.ApplicationModel.DynamicDependency.PackageDependencyLifetimeArtifactKind
-api-type: winrt enum
---

# Microsoft.Windows.ApplicationModel.DynamicDependency.PackageDependencyLifetimeArtifactKind

<!--
public enum PackageDependencyLifetimeArtifactKind
-->


## -description

Defines the type of artifacts you can assign to the [LifetimeArtifactKind](createpackagedependencyoptions_lifetimeartifactkind.md) property to define the lifetime of a package dependency.

## -enum-fields

### -field Process: 0

The current process is the lifetime artifact. The package dependency is implicitly deleted when the process terminates.

### -field FilePath: 1

The lifetime artifact is an absolute filename or path. The package dependency is implicitly deleted when this is deleted.

### -field RegistryKey: 2

The lifetime artifact is a registry key in the format *root*\\*subkey*, where *root* is one of the following: HKEY_LOCAL_MACHINE, HKEY_CURRENT_USER, HKEY_CLASSES_ROOT, or HKEY_USERS. The package dependency is implicitly deleted when this is deleted.

## -remarks

## -see-also

[LifetimeArtifactKind](createpackagedependencyoptions_lifetimeartifactkind.md), [PackageDependency.Create](packagedependency_create_1812482144.md)

## -examples
