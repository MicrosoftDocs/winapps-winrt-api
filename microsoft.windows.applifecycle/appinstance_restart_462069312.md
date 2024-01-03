---
-api-id: M:Microsoft.Windows.AppLifecycle.AppInstance.Restart(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppLifecycle.AppInstance.Restart(System.String)

<!--
public static Windows.ApplicationModel.Core.AppRestartFailureReason Restart (string arguments);
-->

## -description

Restarts the application instance.

## -parameters

### -param arguments

The arguments to pass to the restarted instance.

## -returns

The status of the restart request.

## -remarks

## -see-also

[AppRestartFailureReason](/uwp/api/windows.applicationmodel.core.apprestartfailurereason)

## -examples

In this example, assume the app has encountered an error during initialization. The app displays an error dialog, and after the user clicks OK the app must restart. The example outputs debug info for these use cases.

```csharp
using Windows.ApplicationModel.Core;
using Microsoft.Windows.AppLifecycle;
using System.Diagnostics;
...
private void HandleInitializationError()
{   
    // Restart app in safe mode to avoid another initialization failure.
    // Note: Your app would need to handle the 'safemode' argument and
    //       implement a safe mode experience in this scenario.
    AppRestartFailureReason reason = AppInstance.Restart("/safemode");
    switch (reason)
    {
        case AppRestartFailureReason.RestartPending:
            Debug.WriteLine("Another restart is currently pending.");
            break;
        case AppRestartFailureReason.InvalidUser:
            Debug.WriteLine("Current user is not signed in or not a valid user.");
            break;
        case AppRestartFailureReason.Other:
            Debug.WriteLine("Failure restarting.");
            break;
    }
}
```
