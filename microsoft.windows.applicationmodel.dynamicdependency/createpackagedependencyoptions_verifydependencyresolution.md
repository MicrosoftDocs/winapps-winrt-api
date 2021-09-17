---
-api-id: P:Microsoft.Windows.ApplicationModel.DynamicDependency.CreatePackageDependencyOptions.VerifyDependencyResolution
-api-type: winrt property
---

# Microsoft.Windows.ApplicationModel.DynamicDependency.CreatePackageDependencyOptions.VerifyDependencyResolution

<!--
public bool VerifyDependencyResolution { get; set; }
-->


## -description

Gets or sets a value that indicates whether to disable dependency resolution when pinning a package dependency. This is useful for installers running as user contexts other than the target user (for example, installers running as LocalSystem).

## -property-value

Specify **true** to verify dependency resolution when pinning a package dependency; specify **false** to disable dependency resolution.

## -remarks

## -see-also

[PackageDependency.Create](packagedependency_create_1812482144.md)

## -examples


