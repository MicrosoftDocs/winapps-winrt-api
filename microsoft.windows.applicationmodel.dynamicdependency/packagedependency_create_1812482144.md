---
-api-id: M:Microsoft.Windows.ApplicationModel.DynamicDependency.PackageDependency.Create(System.String,Windows.ApplicationModel.PackageVersion,Microsoft.Windows.ApplicationModel.DynamicDependency.CreatePackageDependencyOptions)
-api-type: winrt method
---

# Microsoft.Windows.ApplicationModel.DynamicDependency.PackageDependency.Create(System.String,Windows.ApplicationModel.PackageVersion,Microsoft.Windows.ApplicationModel.DynamicDependency.CreatePackageDependencyOptions)

<!--
public static Microsoft.Windows.ApplicationModel.DynamicDependency.PackageDependency Create (string packageFamilyName, Windows.ApplicationModel.PackageVersion minVersion, Microsoft.Windows.ApplicationModel.DynamicDependency.CreatePackageDependencyOptions options);
-->


## -description

Creates an install-time reference for a framework package dependency for the current app, using the specified package family name and minimum version and the specified options. When you use this method, the framework package dependency is accessible to the current user only. To create a framework package dependency that is accessible to all users, use the [CreateForSystem](packagedependency_createforsystem_879672097.md) method instead.

## -parameters

### -param packageFamilyName

The package family name of the framework package on which to take dependency.

### -param minVersion

The minimum version of the framework package on which to take dependency.

### -param options

Defines additional criteria to specify the framework package you want to use in your app.

## -returns

The object that represents the package dependency, and provides members you can use to manage the lifetime of the dependency.

## -remarks

In your app's installer or during the first run of your app, call this method to specify a set of criteria for a framework package you want to use in your app. This informs the OS that your app has a dependency upon a framework package that meets the specified criteria. If one or more framework packages are installed that meet the criteria, Windows will ensure that at least one of these framework packages will remain installed until the install-time reference is deleted. For more information, see [Use the dynamic dependency API to reference framework packages at run time](/windows/apps/desktop/modernize/framework-packages/use-the-dynamic-dependency-api).

This function fails if the specified dependency criteria cannot be resolved to a specific package. This package resolution check can be skipped by using the [VerifyDependencyResolution](createpackagedependencyoptions_verifydependencyresolution.md) is specified for the *options* parameter. This is useful for installers running as user contexts other than the target user (for example, installers running as LocalSystem).

## -see-also

[Use the dynamic dependency API to reference framework packages at run time](/windows/apps/desktop/modernize/framework-packages/use-the-dynamic-dependency-api)

## -examples
