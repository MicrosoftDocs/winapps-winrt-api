---
-api-id: M:Microsoft.Windows.PushNotifications.PushNotificationManager.Unregister
-api-type: winrt method
---

# Microsoft.Windows.PushNotifications.PushNotificationManager.Unregister

<!--
public void Unregister ();
-->


## -description

Unregisters the app from receiving [PushReceived](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.PushReceived) events for incoming push notifications.

## -remarks

After calling **Unregister**, a new process will be launched to handle subsequent notifications.

Register to receive **PushReceived** events by calling [Register](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.Register).


## -see-also

## -examples


