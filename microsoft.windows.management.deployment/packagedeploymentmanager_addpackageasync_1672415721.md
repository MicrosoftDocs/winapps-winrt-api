---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.AddPackageAsync(System.String,Microsoft.Windows.Management.Deployment.AddPackageOptions)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.AddPackageAsync(System.String,Microsoft.Windows.Management.Deployment.AddPackageOptions)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.Management.Deployment.PackageDeploymentResult,Microsoft.Windows.Management.Deployment.PackageDeploymentProgress> AddPackageAsync (string package, Microsoft.Windows.Management.Deployment.AddPackageOptions options);
-->


## -description

## -parameters

### -param package

### -param options

## -returns

## -remarks

## -see-also

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
