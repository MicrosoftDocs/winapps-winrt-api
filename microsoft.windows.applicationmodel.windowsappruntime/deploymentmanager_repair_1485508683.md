---
-api-id: M:Microsoft.Windows.ApplicationModel.WindowsAppRuntime.DeploymentManager.Repair
-api-type: winrt method
---

# Microsoft.Windows.ApplicationModel.WindowsAppRuntime.DeploymentManager.Repair

<!--
public static Microsoft.Windows.ApplicationModel.WindowsAppRuntime.DeploymentResult Repair ();
-->


## -description

Attempts to repair the Windows App SDK runtime, regardless of its state. For that reason, to avoid an unecessary repair when the Windows App SDK runtime is in a good state, you should call this API only when the deployment status is not OK.

All info about the version, channel, and architecture needed are derived from the current Windows App SDK Framework package.

## -returns

## -remarks

Since both the Main and Singleton packages will be repaired, it's possible that the Main package repair fails and Initialize returns with a PackageRepairFailed status. Or it's possible that the Main package is repaired successfully but the Singleton package repair fails and Initialize returns with a PackageRepairFailed status. In both cases, the returned WindowsAppRuntimeStatus will contain the error of the first package repair failure. There will be no rollback of any successfully repaired packages. For info about how to handle errors, see [Address installation errors](/windows/apps/windows-app-sdk/deploy-packaged-apps#address-installation-errors).

```csharp
if (DeploymentManager.GetStatus().Status == DeploymentStatus.PackageRepairRequired ||
    DeploymentManager.GetStatus().Status == DeploymentStatus.Unknown)
{
    // Repair will always attempt to repair the Windows App SDK runtime regardless of its state.
    // Repair can sometimes take several seconds to deploy the packages.
    // These should be run on a separate thread so as not to hang your app while the
    // packages deploy.
    var repairTask = Task.Run(() => DeploymentManager.Repair());
    // ...do other work while the repair is running...
    repairTask.Wait();

    // Check the result.
    if (repairTask.Result.Status != DeploymentStatus.Ok)
    {
        // The Repair has failed.
        // Do error reporting or gather information for submitting a bug.
        // Gracefully exit the program or carry on without using the Windows App SDK runtime.
    }
}
```

## -see-also

## -examples
