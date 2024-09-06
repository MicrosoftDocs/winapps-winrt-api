---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.IsPackageSetProvisioned(Microsoft.Windows.Management.Deployment.PackageSet)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.IsPackageSetProvisioned(Microsoft.Windows.Management.Deployment.PackageSet)

<!--
public bool IsPackageSetProvisioned (Microsoft.Windows.Management.Deployment.PackageSet packageSet);
-->


## -description

Determines whether the target package set is provisioned.

## -parameters

### -param packageSet

The target package set to query about.

## -returns

`true` if the target package set is provisioned; otherwise, `false`.

## -remarks

This method requires administrative privileges.

## -see-also

## -examples

A Fabrikam app installing Contoso's *Example1* and *Example2* packages for all users if necessary, and with explicit user confirmation before the installation.

```csharp
void Install()
{
    // We want to check what's provisioned by PackageFamilyName. If something's
    // not provisioned, then we'll also need MinVersion and PackageUri to Stage and
    // Provision. But checking whether a family is provisioned supports only some
    // URI schemes (notably, not the one that we need for our staging work). So we'll
    // define the PackageSet with the families that we want checked, and if something's
    // not provisioned, then we'll add the additional properties needed.

    var packageSet = new PackageSet() {
        Items = { new PackageSetItem() { PackageFamilyName = "contoso.example1_1234567890abc" },
                { new PackageSetItem() { PackageFamilyName = "contoso.example2_1234567890abc" }
        }
    };

    var packageDeploymentManager = PackageDeploymentManager.GetDefault();
    if (packageDeploymentManager.IsPackageSetProvisioned(packageSet))
    {
        return;
    }

    bool ok = PromptUserForConfirmation();
    if (!ok)
    {
        return;
    }

    packageSet.Items()[0].MinVersion(ToVersion(1, 2, 3, 4));
    packageSet.Items()[0].PackageUri(new Uri("c:\\contoso\\example1-1.2.3.4.msix"));
    packageSet.Items()[1].MinVersion(ToVersion(2, 4, 6, 8));
    packageSet.Items()[1].PackageUri(new Uri("https://contoso.com/example2-2.4.6.8.msix"));

    var stageOptions = new StagePackageOptions();
    var deploymentResult = await packageDeploymentManager.StagePackageSetReadyAsync(packageSet, options);
    if (deplymentResult.Status == PackageDeploymentStatus.CompletedSuccess)
    {
        Console.WriteLine("Staged");
    }
    else
    {
        Console.WriteLine("Error:{} ExtendedError:{} {}",
            deploymentResult.Error.HResult, deploymentResult.ExtendedError.HResult, deploymentResult.ErrorText);
        return;
    }

    var options = new ProvisionPackageOptions();
    var deploymentResult = await packageDeploymentManager.ProvisionPackageSetReadyAsync(packageSet, options);
    if (deplymentResult.Status == PackageDeploymentStatus.CompletedSuccess)
    {
        Console.WriteLine("Provisioned");
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
