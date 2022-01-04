---
-api-id: M:Microsoft.Windows.AppLifecycle.AppInstance.GetActivatedEventArgs
-api-type: winrt method
---

# Microsoft.Windows.AppLifecycle.AppInstance.GetActivatedEventArgs

<!--
public Microsoft.Windows.AppLifecycle.AppActivationArguments GetActivatedEventArgs ();
-->


## -description

Retrieves the event arguments for an app activation that was registered by using one of the static methods of the [ActivationRegistrationManager](activationregistrationmanager.md) class.

## -returns

An object that contains the activation type and the data payload, or `null`. See **Remarks**.

## -remarks

The [AppActivationArguments](/windows/windows-app-sdk/api/winrt/microsoft.windows.applifecycle.appactivationarguments) object returned is limited to those activation kinds that are supported in the Windows App SDK. As of version 1.0 Stable, those are **Launch**, **File**, **Protocol**, and **StartupTask**. For other activation kinds, **GetActivatedEventArgs** returns `null`.

## -see-also

[App instancing](/windows/apps/windows-app-sdk/applifecycle/applifecycle-instancing)

## -examples
