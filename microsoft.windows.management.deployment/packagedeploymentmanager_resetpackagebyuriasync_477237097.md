---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.ResetPackageByUriAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.ResetPackageByUriAsync(Windows.Foundation.Uri)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.Management.Deployment.PackageDeploymentResult,Microsoft.Windows.Management.Deployment.PackageDeploymentProgress> ResetPackageByUriAsync (System.Uri packageUri);
-->


## -description

Asynchronously provides the same functionality as is available interactively via Windows Settings' **Reset** button on the detail page for an app (**Apps** > **Installed apps** > **...** > **Advanced options** > **Reset**).

*If this app still isn't working right, reset it. The app's data will be deleted.*

## -parameters

### -param packageUri

The uri of the target package(s) to reset.

## -returns

An asynchronous operation object which, when it completes, contains a value representing the result of the operation.

## -remarks

## -see-also

## -examples
