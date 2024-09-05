---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.AddPackageByUriAsync(Windows.Foundation.Uri,Microsoft.Windows.Management.Deployment.AddPackageOptions)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.AddPackageByUriAsync(Windows.Foundation.Uri,Microsoft.Windows.Management.Deployment.AddPackageOptions)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.Management.Deployment.PackageDeploymentResult,Microsoft.Windows.Management.Deployment.PackageDeploymentProgress> AddPackageByUriAsync (System.Uri packageUri, Microsoft.Windows.Management.Deployment.AddPackageOptions options);
-->


## -description

## -parameters

### -param packageUri

### -param options

## -returns

## -remarks

## -see-also

## -examples

A Fabrikam app installing Contoso's *Example* package from an `https:` source.

```csharp
void Install()
{
    var package = new Uri("https://contoso.com/example.msix");
    var packageDeploymentManager = PackageDeploymentManager.GetDefault();
    var options = new AddPackageOptions();
    var deploymentResult = await packageDeploymentManager.AddPackageByUriAsync(package, options);
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
