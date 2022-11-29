---
-api-id: M:Microsoft.Windows.ApplicationModel.WindowsAppRuntime.DeploymentManager.Initialize(Microsoft.Windows.ApplicationModel.WindowsAppRuntime.DeploymentInitializeOptions)
-api-type: winrt method
---

# Microsoft.Windows.ApplicationModel.WindowsAppRuntime.DeploymentManager.Initialize(Microsoft.Windows.ApplicationModel.WindowsAppRuntime.DeploymentInitializeOptions)

<!--
public static Microsoft.Windows.ApplicationModel.WindowsAppRuntime.DeploymentResult Initialize (Microsoft.Windows.ApplicationModel.WindowsAppRuntime.DeploymentInitializeOptions deploymentInitializeOptions);
-->


## -description

Checks the status of the Windows App SDK runtime referenced by the current package, and attempts to register any missing Windows App SDK packages that can be registered, while applying the options supplied.

> [!IMPORTANT]
> Your app should call **DeploymentManager.Initialize** during startup.

## -parameters

### -param deploymentInitializeOptions

A [DeploymentInitializeOptions](deploymentinitializeoptions.md) object that specifies options for the registration operation.

## -returns

An object that provides deployment status and error information for the Windows App SDK runtime referenced by the current package.

## -remarks

See *Remarks* for [Initialize()](deploymentmanager_initialize_1754723448.md).

## -see-also

[Deployment guide for packaged apps](/windows/apps/windows-app-sdk/deploy-packaged-apps)

## -examples
