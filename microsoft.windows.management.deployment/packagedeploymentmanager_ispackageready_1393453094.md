---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.IsPackageReady(System.String)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.IsPackageReady(System.String)

<!--
public bool IsPackageReady (string package);
-->


## -description

Determines whether the target package(s) is/are present (installed, registered) and ready for use. This method is a quick test to determine whether more (costly) work is needed before the target can be used.

## -parameters

### -param package

The target package(s) to query about.

## -returns

`true` if the target package(s) is/are present (installed, registered) and ready for use; otherwise, `false`.

## -remarks

Reasons why a package isn't ready can include:

* The package isn't present on the machine.
* The package is present on the machine, but it's not registered for the user.
* The package is registered for the user, but it's not in a healthy state; for example, its **Package.Status** is *Tampered*.

You typically needn't call **IsPackageReady** before you call [EnsurePackageReadyAsync](./packagedeploymentmanager_ensurepackagereadyasync_1000222304.md). But doing so can be useful in a case where you need to do additional work before potentially performing deployment operations. For example, if you need to prompt the user for consent before installing the target:

```csharp
var pdm = PackageDeploymentManager().GetDefault();
if (!pdm.IsPackageReady(pkg))
{
    bool ok = AskUserForConsent(pkg);
    if (ok)
    {
        var options = new EnsureReadyOptions();
        var result = await pdm.EnsurePackageReadyAsync(pkg, options);
    }
}
```

## -see-also

## -examples
