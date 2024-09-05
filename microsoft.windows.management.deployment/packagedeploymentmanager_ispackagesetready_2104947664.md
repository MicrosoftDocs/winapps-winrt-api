---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.IsPackageSetReady(Microsoft.Windows.Management.Deployment.PackageSet)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.IsPackageSetReady(Microsoft.Windows.Management.Deployment.PackageSet)

<!--
public bool IsPackageSetReady (Microsoft.Windows.Management.Deployment.PackageSet packageSet);
-->


## -description

Determines whether the target package set is present (installed, registered) and ready for use. This method is a quick test to determine whether more (costly) work is needed before the target can be used.

## -parameters

### -param packageSet

The target package set to query about.

## -returns

`true` only if all packages referenced by *packageSet* are present (installed, registered) and ready for use; otherwise, `false`;

## -remarks

See Remarks for [IsPackageReady](./packagedeploymentmanager_ispackageready_1393453094.md).

## -see-also

## -examples

See the example in [PackageDeploymentManager.EnsurePackageSetReadyAsync](./packagedeploymentmanager_ensurepackagesetreadyasync_1294848852.md).
