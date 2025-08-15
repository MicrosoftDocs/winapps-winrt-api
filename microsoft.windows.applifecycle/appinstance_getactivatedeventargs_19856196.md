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

The [AppActivationArguments](appactivationarguments.md) object returned is limited to those activation kinds that are supported in the Windows App SDK. As of version 1.0, those are **Launch**, **File**, **Protocol**, and **StartupTask**. For other activation kinds, **GetActivatedEventArgs** returns `null`.

For packaged apps, this method wraps the [Windows.ApplicationModel.AppInstance.GetActivatedEventArgs](/uwp/api/windows.applicationmodel.appinstance.getactivatedeventargs) method, and therefore returns the same value. Also for packaged apps, this method will only return the arguments the first time it is called in an app. So, you should call it as early as possible during activation, as the arguments may become unavailable later.

## -see-also

[App instancing](/windows/apps/windows-app-sdk/applifecycle/applifecycle-instancing)

## -examples
