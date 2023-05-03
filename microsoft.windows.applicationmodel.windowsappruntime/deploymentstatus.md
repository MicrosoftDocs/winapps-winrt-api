---
-api-id: T:Microsoft.Windows.ApplicationModel.WindowsAppRuntime.DeploymentStatus
-api-type: winrt enum
---

# Microsoft.Windows.ApplicationModel.WindowsAppRuntime.DeploymentStatus

<!--
public enum DeploymentStatus
-->


## -description

Represents the deployment status of the Windows App SDK runtime that is currently loaded.

## -enum-fields

### -field Unknown: 0

The Windows App SDK runtime is in an unknown deployment state.

### -field Ok: 1

The Windows App SDK runtime is in a good deployment state.

### -field PackageInstallRequired: 2

A package install is required in order for the Windows App SDK runtime to be in a good deployment state.

### -field PackageInstallFailed: 3

The installation of a package for the Windows App SDK runtime failed.

### -field PackageRepairFailed: 4

The repair of a package for the Windows App SDK runtime failed.

## -remarks

## -see-also

[Deployment guide for packaged apps](/windows/apps/windows-app-sdk/deploy-packaged-apps)

## -examples
