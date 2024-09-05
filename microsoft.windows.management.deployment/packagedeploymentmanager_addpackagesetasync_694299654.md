---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.AddPackageSetAsync(Microsoft.Windows.Management.Deployment.PackageSet,Microsoft.Windows.Management.Deployment.AddPackageOptions)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.AddPackageSetAsync(Microsoft.Windows.Management.Deployment.PackageSet,Microsoft.Windows.Management.Deployment.AddPackageOptions)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.Management.Deployment.PackageDeploymentResult,Microsoft.Windows.Management.Deployment.PackageDeploymentProgress> AddPackageSetAsync (Microsoft.Windows.Management.Deployment.PackageSet packageSet, Microsoft.Windows.Management.Deployment.AddPackageOptions options);
-->


## -description

## -parameters

### -param packageSet

### -param options

## -returns

## -remarks

## -see-also

## -examples

`AddPackageSetAsync(ps, options)` is functionally equivalent to this code example:

```csharp
var pdm = PackageDeploymentManager().GetDefault();
foreach (PackageSetItem psi in ps.Items)
{
    var result = await pdm.AddPackageAsync(psi.PackageUri, options)
    if (result.Status != PackageDeploymentStatus.CompletedSuccess)
    {
        return result;
    }
}
return new PackageDeploymentResult(PackageDeploymentStatus.CompletedSuccess);
```

This next example is of a Fabrikam app installing Contoso's *Example1* and *Example2* packages via a [PackageSet](./packageset.md).

```csharp
void Install()
{
    var packageSet = new PackageSet() {
        Items = { new PackageSetItem() { PackageUri = new Uri("c:\\contoso\\example1-1.2.3.4.msix") },
                { new PackageSetItem() { PackageUri = new Uri("https://contoso.com/example2-2.4.6.8.msix") } };

    var packageDeploymentManager = PackageDeploymentManager.GetDefault();
    var options = new AddPackageOptions();
    var deploymentResult = await packageDeploymentManager.AddPackageByUriAsync(packageSet, options);
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
