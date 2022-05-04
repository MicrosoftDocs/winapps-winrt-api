---
-api-id: E:Microsoft.Windows.AppNotifications.AppNotificationManager.NotificationInvoked
-api-type: winrt event
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.NotificationInvoked

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.Windows.AppNotifications.AppNotificationManager,Microsoft.Windows.AppNotifications.AppNotificationActivatedEventArgs> NotificationInvoked;
-->


## -description

Raised when an app notification for the app is invoked through user interaction.

## -remarks

To ensure that the **NotificationInvoked** event handler is called within the process of the running app, be sure to register the handler for this event before calling [Register](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.Register). Otherwise, a new process will be launched to handle the invocation.



## -see-also

[Register](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.Register)

## -examples


