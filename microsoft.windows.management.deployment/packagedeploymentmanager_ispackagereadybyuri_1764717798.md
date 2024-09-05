---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.IsPackageReadyByUri(Windows.Foundation.Uri)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.IsPackageReadyByUri(Windows.Foundation.Uri)

<!--
public bool IsPackageReadyByUri (System.Uri packageUri);
-->


## -description

Determines, for a uri, whether the target package(s) is/are present (installed, registered) and ready for use. This method is a quick test to determine whether more (costly) work is needed before the target can be used.

## -parameters

### -param packageUri

The uri of the target package(s) to query about.

## -returns

`true` if the target package(s) is/are present (installed, registered) and ready for use; otherwise, `false`;

## -remarks

See Remarks for [IsPackageReady](./packagedeploymentmanager_ispackageready_1393453094.md).

## -see-also

## -examples


