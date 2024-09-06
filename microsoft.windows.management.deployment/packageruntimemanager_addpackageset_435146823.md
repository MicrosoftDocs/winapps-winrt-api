---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageRuntimeManager.AddPackageSet(Microsoft.Windows.Management.Deployment.PackageSet)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageRuntimeManager.AddPackageSet(Microsoft.Windows.Management.Deployment.PackageSet)

<!--
public Microsoft.Windows.Management.Deployment.PackageSetRuntimeDisposition AddPackageSet (Microsoft.Windows.Management.Deployment.PackageSet packageSet);
-->


## -description

Make the package(s) in the package set available to the calling process. That is, dynamically add the package(s) in the package set to the caller's package graph.

## -parameters

### -param packageSet

The package set.

## -returns

A [PackageSetRuntimeDisposition](./packagesetitemruntimedisposition.md) representing the result of the operation.

## -remarks

## -see-also

## -examples

`AddPackageSet(ps)` is functionally equivalent to this code example:

```csharp
var pdm = PackageDeploymentManager().GetDefault();
foreach (PackageSetItem psi in ps.Items)
{
    var pd = TryCreatePackageDependency(psi);
    if (pd != null)
    {
        pdm.AddPackageDependency(pd);
    }
}
```

This next example is of a Fabrikam app using Contoso's *Example1* and *Example2* packages via Dynamic Dependencies; installing them if necessary. These packages are added to the package graph, and not explicitly removed (they stay in
the package graph until process termination).

```csharp
void AddExample1AndExample2ToThePackageGraph()
{
    var packageSet = new PackageSet() {
        Items = { new PackageSetItem() { PackageFamilyName = "contoso.example1_1234567890abc",
                                         MinVersion = ToVersion(1, 2, 3, 4),
                                         PackageUri = new Uri("c:\\contoso\\example1-1.2.3.4.msix") },
                { new PackageSetItem() { PackageFamilyName = "contoso.example2_1234567890abc",
                                         MinVersion = ToVersion(2, 4, 6, 8),
                                         PackageUri = new Uri("https://contoso.com/example2-2.4.6.8.msix") } };

    var packageDeploymentManager = PackageDeploymentManager.GetDefault();
    var options = new EnsureReadyOptions();
    var deploymentResult = await packageDeploymentManager.EnsurePackageSetReadyAsync(packageSet, options);
    if (deplymentResult.Status == PackageDeploymentStatus.CompletedSuccess)
    {
        Console.WriteLine("OK");
    }
    else
    {
        Console.WriteLine("Error:{} ExtendedError:{} {}",
            deploymentResult.Error.HResult, deploymentResult.ExtendedError.HResult, deploymentResult.ErrorText);
    }

    var packageRuntimeManager = PackageRuntimeManager.GetDefault();
    var packageSetRuntimeDisposition = packageRuntimeManager.AddPackageSet(packageSet);
}

PackageVersion ToVersion(uint major, uint minor, uint build, uint revision) =>
    new PackageVersion {
        Major = checked((ushort)major),
        Minor = checked((ushort)minor),
        Build = checked((ushort)build),
        Revision = checked((ushort)revision)
    };
```
