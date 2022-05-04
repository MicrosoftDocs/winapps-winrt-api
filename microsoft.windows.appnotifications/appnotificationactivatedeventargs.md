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

To get an instance of this class, call <xref:Microsoft.Windows.AppLifecycle.AppInstance.GetActivatedEventArgs?displayProperty=nameWithType>, check the <xref:Microsoft.Windows.AppLifecycle.AppActivationArguments.Kind?displayProperty=nameWithType> property of the returned object for the value <xref:Microsoft.Windows.AppLifecycle.ExtendedActivationKind.AppNotification?displayProperty=nameWithType>, then cast the <xref:Microsoft.Windows.AppLifecycle.AppActivationArguments.Args?displayProperty=nameWithType> property to an **AppNotificationActivatedEventArgs**.




## -see-also

## -examples


