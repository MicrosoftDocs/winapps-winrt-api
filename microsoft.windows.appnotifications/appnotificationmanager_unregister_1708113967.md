---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationManager.Unregister
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.Unregister

<!--
public void Unregister ();
-->


## -description

Unregisters the app from receiving [NotificationInvoked](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.NotificationInvoked) events when the user interacts with an app notification.

## -remarks

After calling **Unregister**, any subsequent calls to invoke the Notification by the user would launch a new process"

Register to receive **NotificationInvoked** events by calling [Register](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.Register).

## -see-also

## -examples


