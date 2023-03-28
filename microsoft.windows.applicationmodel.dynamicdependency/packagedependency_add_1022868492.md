---
-api-id: M:Microsoft.Windows.ApplicationModel.DynamicDependency.PackageDependency.Add(Microsoft.Windows.ApplicationModel.DynamicDependency.AddPackageDependencyOptions)
-api-type: winrt method
---

# Microsoft.Windows.ApplicationModel.DynamicDependency.PackageDependency.Add(Microsoft.Windows.ApplicationModel.DynamicDependency.AddPackageDependencyOptions)

<!--
public Microsoft.Windows.ApplicationModel.DynamicDependency.PackageDependencyContext Add (Microsoft.Windows.ApplicationModel.DynamicDependency.AddPackageDependencyOptions options);
-->


## -description

Adds a run-time reference for the framework package dependency you created earlier by using the [Create](/windows/windows-app-sdk/api/winrt/microsoft.windows.applicationmodel.dynamicdependency.packagedependency.create) method, with the specified options. After this method successfully returns, your app can activate types and use content from the framework package.

## -parameters

### -param options

Defines additional options to specify the framework package reference.

## -returns

An object that provides context info about the framework package dependency and enables you to remove the run-time reference.

## -remarks

Calling this method resolves the framework package dependency to a specific package on the system. It also informs the OS that the framework package is in active use and to handle any version updates in a side-by-side manner (effectively delay uninstalling or otherwise servicing the older version until after your app is done using it). Package resolution is specific to a user and can return different values for different users on a system.

Each successful **Add** call adds the resolved package to the calling process' package graph, even if already present. There is no duplicate detection or filtering applied by the API (that is, multiple references from a package is not harmful). After resolution is complete, the package dependency stays resolved for that user until the last reference across all processes for that user is removed via [PackageDependencyContext.Remove](packagedependencycontext_remove_13687727.md) or the process is terminated. Successful calls to this method change the [PackageDependency.GenerationId](packagedependency_generationid.md) value.

After this method successfully returns, your app can activate types and use content from the framework package until [PackageDependencyContext.Remove](packagedependencycontext_remove_13687727.md) is called.

If multiple packages are present in the package graph with the same rank as the call to **Add**, the resolved package is (by default) added after others of the same rank. To add a package before others of the same rank, specify [PrependIfRankCollision](addpackagedependencyoptions_prependifrankcollision.md) for the *options* parameter.

For more information, see [Use the dynamic dependency API to reference MSIX packages at run time](/windows/apps/desktop/modernize/framework-packages/use-the-dynamic-dependency-api).

## -see-also

[Use the dynamic dependency API to reference MSIX packages at run time](/windows/apps/desktop/modernize/framework-packages/use-the-dynamic-dependency-api)

## -examples


