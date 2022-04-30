---
-api-id: M:Microsoft.Windows.ApplicationModel.WindowsAppRuntime.DeploymentManager.GetStatus
-api-type: winrt method
---

# Microsoft.Windows.ApplicationModel.WindowsAppRuntime.DeploymentManager.GetStatus

<!--
public static Microsoft.Windows.ApplicationModel.WindowsAppRuntime.DeploymentResult GetStatus ();
-->


## -description

Returns the current deployment status of the Windows App SDK runtime that is currently loaded. Use this method to identify if there is work required to install Windows App SDK runtime packages before the current app can use Windows App SDK features.

## -returns

An object that provides deployment status and error information for the Windows App SDK runtime referenced by the current package.

## -remarks

Call this method after the current app is initialized but before it has used any Windows App SDK features.

## -see-also

[Deployment guide for packaged apps](/windows/apps/windows-app-sdk/deploy-packaged-apps)

## -examples
