---
-api-id: M:Microsoft.Windows.ApplicationModel.DynamicDependency.PackageDependency.Delete
-api-type: winrt method
---

# Microsoft.Windows.ApplicationModel.DynamicDependency.PackageDependency.Delete

<!--
public void Delete ();
-->


## -description

Deletes the install-time reference for the framework package dependency you created earlier by using the [Create](/windows/windows-app-sdk/api/winrt/microsoft.windows.applicationmodel.dynamicdependency.packagedependency.create) method. This method informs the OS that it is safe to remove the framework package if no other apps have a dependency on it.

## -remarks

Removing a package dependency is typically done when an app is uninstalled. A package dependency is implicitly removed if its lifetime artifact (specified via the [LifetimeArtifact](createpackagedependencyoptions_lifetimeartifact.md) property of the *options* parameter for the [Create](/windows/windows-app-sdk/api/winrt/microsoft.windows.applicationmodel.dynamicdependency.packagedependency.create) and [CreateForSystem](packagedependency_createforsystem_879672097.md) methods) is deleted. Package dependencies that are not referenced by other packages are elegible to be removed.

The caller of this function must have administrative privileges if the package dependency was created using the [CreateForSystem](packagedependency_createforsystem_879672097.md) method.

## -see-also

[Create](/windows/windows-app-sdk/api/winrt/microsoft.windows.applicationmodel.dynamicdependency.packagedependency.create), [CreateForSystem](packagedependency_createforsystem_879672097.md), [Use the dynamic dependency API to reference framework packages at run time](/windows/apps/desktop/modernize/framework-packages/use-the-dynamic-dependency-api)

## -examples
