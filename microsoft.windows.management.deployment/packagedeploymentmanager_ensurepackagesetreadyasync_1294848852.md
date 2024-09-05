---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.EnsurePackageSetReadyAsync(Microsoft.Windows.Management.Deployment.PackageSet,Microsoft.Windows.Management.Deployment.EnsureReadyOptions)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.EnsurePackageSetReadyAsync(Microsoft.Windows.Management.Deployment.PackageSet,Microsoft.Windows.Management.Deployment.EnsureReadyOptions)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.Management.Deployment.PackageDeploymentResult,Microsoft.Windows.Management.Deployment.PackageDeploymentProgress> EnsurePackageSetReadyAsync (Microsoft.Windows.Management.Deployment.PackageSet packageSet, Microsoft.Windows.Management.Deployment.EnsureReadyOptions options);
-->


## -description

Asynchronously determines whether the target package set is present (installed, registered) and ready for use; and, if not, puts it in that state. That can involve downloading the target, registering it for the user, and remediating a package in an unhealthy state.

## -parameters

### -param packageSet

The target package set to query about.

### -param options

Ensure-ready options for the operation.

## -returns

An asynchronous operation object which, when it completes, contains a value representing the result of the operation.

## -remarks

See Remarks for [EnsurePackageReadyAsync](./packagedeploymentmanager_ensurepackagereadyasync_1000222304.md).

## -see-also

## -examples

A Fabrikam app installing Contoso's *Example1* and *Example2* packages, if necessary, and with explicit user confirmation before the installation.

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
    if (!packageDeploymentManager.IsPackageSetReady(packageSet))
    {
        bool ok = PromptUserForConfirmation();
        if (!ok)
        {
            return;
        }
    }

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
