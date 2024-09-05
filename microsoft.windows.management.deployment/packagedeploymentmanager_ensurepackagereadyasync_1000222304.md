---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.EnsurePackageReadyAsync(System.String,Microsoft.Windows.Management.Deployment.EnsureReadyOptions)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.EnsurePackageReadyAsync(System.String,Microsoft.Windows.Management.Deployment.EnsureReadyOptions)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.Management.Deployment.PackageDeploymentResult,Microsoft.Windows.Management.Deployment.PackageDeploymentProgress> EnsurePackageReadyAsync (string package, Microsoft.Windows.Management.Deployment.EnsureReadyOptions options);
-->


## -description

Asynchronously determines whether the target package(s) is/are present (installed, registered) and ready for use; and, if not, puts them in that state. That can involve downloading the target, registering it for the user, and remediating a package in an unhealthy state.

## -parameters

### -param package

The target package(s) to query about.

### -param options

Ensure-ready options for the operation.

## -returns

An asynchronous operation object which, when it completes, contains a value representing the result of the operation.

## -remarks

In terms of implementation, calling `EnsurePackageReady(pkg, options)` is functionally equivalent to:

```csharp
var pdm = PackageDeploymentManager().GetDefault();
if (!pdm.IsPackageReady(pkg))
{
    var result = await pdm.AddPackageAsync(pkg, options);
}
```

As you can see, **EnsurePackageReadyAsync** calls [IsPackageReady](./packagedeploymentmanager_ispackageready_1393453094.md), and returns early if all is ready. So there's no efficiency reason to call **IsPackageReady** yourself before you call **EnsurePackageReadyAsync**.

## -see-also

## -examples

A Fabrikam app installing Contoso's *Example1* and *Example2* packages, if necessary, via a [PackageSet](./packageset.md).

```csharp
void Install()
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
}

PackageVersion ToVersion(uint major, uint minor, uint build, uint revision) =>
    new PackageVersion {
        Major = checked((ushort)major),
        Minor = checked((ushort)minor),
        Build = checked((ushort)build),
        Revision = checked((ushort)revision)
    };
```
