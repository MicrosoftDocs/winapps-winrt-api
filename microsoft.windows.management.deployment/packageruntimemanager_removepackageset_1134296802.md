---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageRuntimeManager.RemovePackageSet(Microsoft.Windows.Management.Deployment.PackageSetRuntimeDisposition)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageRuntimeManager.RemovePackageSet(Microsoft.Windows.Management.Deployment.PackageSetRuntimeDisposition)

<!--
public void RemovePackageSet (Microsoft.Windows.Management.Deployment.PackageSetRuntimeDisposition packageSetRuntimeDisposition);
-->


## -description

## -parameters

### -param packageSetRuntimeDisposition

## -remarks

## -see-also

## -examples

A Fabrikam app uses Contoso's *Example1* and *Example2* packages via Dynamic Dependencies; installing them if necessary. These packages are added to the package graph, and later removed when no longer needed.

```csharp
void DoWorkWithExample1AndExample2()
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
    DoWork();
    packageRuntimeManager.RemovePackageSet(packageSetRuntimeDisposition);
}

PackageVersion ToVersion(uint major, uint minor, uint build, uint revision) =>
    new PackageVersion {
        Major = checked((ushort)major),
        Minor = checked((ushort)minor),
        Build = checked((ushort)build),
        Revision = checked((ushort)revision)
    };
```
