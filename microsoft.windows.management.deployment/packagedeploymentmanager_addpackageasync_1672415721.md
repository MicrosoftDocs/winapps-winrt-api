---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.AddPackageAsync(System.String,Microsoft.Windows.Management.Deployment.AddPackageOptions)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.AddPackageAsync(System.String,Microsoft.Windows.Management.Deployment.AddPackageOptions)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.Management.Deployment.PackageDeploymentResult,Microsoft.Windows.Management.Deployment.PackageDeploymentProgress> AddPackageAsync (string package, Microsoft.Windows.Management.Deployment.AddPackageOptions options);
-->


## -description

Adds a [Package](/uwp/api/windows.applicationmodel.package) (the main package) and its dependency packages for the current user, using the specified deployment options.

## -parameters

### -param package

The package to add.

### -param options

The deployment options for the package.

## -returns

The DeploymentProgress percentage of completion over the entire course of the deployment operation.

## -remarks

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)

## -examples

A Fabrikam app installing Contoso's *Example* package from an `.msix` file.

```csharp
void Install()
{
    var package = "d:\\contoso\\example.msix";
    var packageDeploymentManager = PackageDeploymentManager.GetDefault();
    var options = new AddPackageOptions();
    var deploymentResult = await packageDeploymentManager.AddPackageAsync(package, options);
    if (deplymentResult.Status == PackageDeploymentStatus.CompletedSuccess)
    {
        Console.WriteLine("OK");
    }
    else
    {
        Console.WriteLine("Error:{} ExtendedError:{} {}",
            deploymentResult.Error.HResult, deploymentResult.ExtendedError.HResult, deploymentResult.ErrorText);
    }
}
```
