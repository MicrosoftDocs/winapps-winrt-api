---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.RepairPackageAsync(System.String)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.RepairPackageAsync(System.String)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.Management.Deployment.PackageDeploymentResult,Microsoft.Windows.Management.Deployment.PackageDeploymentProgress> RepairPackageAsync (string package);
-->


## -description

Asynchronously provides the same functionality as is available interactively via Windows Settings' **Repair** button on the detail page for an app (**Apps** > **Installed apps** > **...** > **Advanced options** > **Repair**).

*If this app isn't working right, we can try to repair it. The app's data won't be affected.*

## -parameters

### -param package

The target package(s) to repair.

## -returns

An asynchronous operation object which, when it completes, contains a value representing the result of the operation.

## -remarks

## -see-also

## -examples
