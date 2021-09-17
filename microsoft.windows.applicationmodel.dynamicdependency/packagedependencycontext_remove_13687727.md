---
-api-id: M:Microsoft.Windows.ApplicationModel.DynamicDependency.PackageDependencyContext.Remove
-api-type: winrt method
---

# Microsoft.Windows.ApplicationModel.DynamicDependency.PackageDependencyContext.Remove

<!--
public void Remove ();
-->


## -description

Removes a resolved package dependency from the current process' package graph (that is, a run-time reference for a framework package dependency that was added by using the [PackageDependency.Add](/windows/windows-app-sdk/api/winrt/microsoft.windows.applicationmodel.dynamicdependency.packagedependency.add) method).

## -remarks

This method does not unload loaded resources such as DLLs. After removing a package dependency, any files loaded from the package can continue
to be used. Future file resolution will fail to see the removed package dependency.

Successful calls to this method change the [PackageDependency.GenerationId](packagedependency_generationid.md) value.

## -see-also

## -examples


