---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.StagePackageByUriAsync(Windows.Foundation.Uri,Microsoft.Windows.Management.Deployment.StagePackageOptions)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.StagePackageByUriAsync(Windows.Foundation.Uri,Microsoft.Windows.Management.Deployment.StagePackageOptions)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.Management.Deployment.PackageDeploymentResult,Microsoft.Windows.Management.Deployment.PackageDeploymentProgress> StagePackageByUriAsync (System.Uri packageUri, Microsoft.Windows.Management.Deployment.StagePackageOptions options);
-->


## -description

Stages a [Package](/uwp/api/windows.applicationmodel.package) to the system without registering it.

## -parameters

### -param packageUri

The source URI of the main package.

### -param options

The deployment options for the package.

## -returns

The status of the deployment request. The [PackageDeploymentResult](packagedeploymentresult.md) contains the final returned value of the deployment operation, once it is completed. The [PackageDeploymentProgress](packagedeploymentprogress.md) can be used to obtain the percentage of completion over the entire course of the deployment operation.

## -remarks

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)

## -examples
