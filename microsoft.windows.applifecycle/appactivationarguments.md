---
-api-id: T:Microsoft.Windows.AppLifecycle.AppActivationArguments
-api-type: winrt class
---

# Microsoft.Windows.AppLifecycle.AppActivationArguments

<!--
public sealed class AppActivationArguments
-->


## -description

Contains information about the type and data payload for an app activation that was registered by using one of the static methods of the [ActivationRegistrationManager](activationregistrationmanager.md) class.

## -remarks

When a registered activation is triggered, an instance of this class is passed to the event handler for the [Activated](appinstance_activated.md) event of the [AppInstance](appinstance.md) class. Alternatively, the app can call the [GetActivatedEventArgs](appinstance_getactivatedeventargs_19856196.md) of the [AppInstance](appinstance.md) class to get an instance of this class.

## -see-also

[ActivationRegistrationManager](activationregistrationmanager.md), [Activated](appinstance_activated.md), [GetActivatedEventArgs](appinstance_getactivatedeventargs_19856196.md), [Rich activation](/windows/apps/windows-app-sdk/applifecycle/applifecycle-rich-activation)

## -examples


