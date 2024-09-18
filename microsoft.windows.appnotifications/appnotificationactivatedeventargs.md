---
-api-id: T:Microsoft.Windows.AppNotifications.AppNotificationActivatedEventArgs
-api-type: winrt class
---

# Microsoft.Windows.AppNotifications.AppNotificationActivatedEventArgs

<!--
public sealed class AppNotificationActivatedEventArgs
-->


## -description

Represents event args associated with an app activation triggered by an app notification.

## -remarks

To get an instance of this class, call [Microsoft.Windows.AppLifecycle.AppInstance.GetActivatedEventArgs](/windows/windows-app-sdk/api/winrt/microsoft.windows.applifecycle/appinstance_getactivatedeventargs_19856196), check the [Microsoft.Windows.AppLifecycle.AppActivationArguments.Kind](/windows/windows-app-sdk/api/winrt/microsoft.windows.applifecycle/appactivationarguments_kind) property of the returned object for the value <xref:Microsoft.Windows.AppLifecycle.ExtendedActivationKind.AppNotification?displayProperty=nameWithType>, then cast the [Microsoft.Windows.AppLifecycle.AppActivationArguments.Data](/windows/windows-app-sdk/api/winrt/microsoft.windows.applifecycle/appactivationarguments_data) property to an **AppNotificationActivatedEventArgs**.




## -see-also

## -examples


