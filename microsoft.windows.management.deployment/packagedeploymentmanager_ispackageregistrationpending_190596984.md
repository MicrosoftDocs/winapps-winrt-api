---
-api-id: M:Microsoft.Windows.Management.Deployment.PackageDeploymentManager.IsPackageRegistrationPending(System.String)
-api-type: winrt method
---

# Microsoft.Windows.Management.Deployment.PackageDeploymentManager.IsPackageRegistrationPending(System.String)

<!--
public bool IsPackageRegistrationPending (string packageFamilyName);
-->


## -description

Detects whether package registration is pending for the specified target.

If a package is in use, and you call [AddPackageAsync](./packagedeploymentmanager_addpackageasync_1672415721.md) with a newer version and with the option [DeferRegistrationWhenPackagesAreInUse](/uwp/api/windows.management.deployment.addpackageoptions.deferregistrationwhenpackagesareinuse) set to `true`, then the registration is delayed until the package is no longer in use. When it's no longer in use, then it can be updated. In cases like that, **IsPackageRegistrationPending** returns `true`.

## -parameters

### -param packageFamilyName

The package family name of the target to query about.

## -returns

`true` if package registration is pending for the specified target; otherwise, `false`.

## -remarks

## -see-also

## -examples
