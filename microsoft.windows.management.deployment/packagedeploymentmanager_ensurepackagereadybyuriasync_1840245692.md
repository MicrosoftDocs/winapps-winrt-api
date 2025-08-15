---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.EnsurePackageReadyByUriAsync(Windows.Foundation.Uri,Microsoft.Windows.Management.Deployment.EnsureReadyOptions)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.EnsurePackageReadyByUriAsync(Windows.Foundation.Uri,Microsoft.Windows.Management.Deployment.EnsureReadyOptions)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.Management.Deployment.PackageDeploymentResult,Microsoft.Windows.Management.Deployment.PackageDeploymentProgress> EnsurePackageReadyByUriAsync (System.Uri packageUri, Microsoft.Windows.Management.Deployment.EnsureReadyOptions options);
-->


## -description

Asynchronously determines, for a uri, whether the target package(s) is/are present (installed, registered) and ready for use; and, if not, puts them in that state. That can involve downloading the target, registering it for the user, and remediating a package in an unhealthy state.

## -parameters

### -param packageUri

The uri of the target package(s) to query about.

### -param options

Ensure-ready options for the operation.

## -returns

An asynchronous operation object which, when it completes, contains a value representing the result of the operation.

## -remarks

See Remarks for [EnsurePackageReadyAsync](./packagedeploymentmanager_ensurepackagereadyasync_1000222304.md).

## -see-also

## -examples
