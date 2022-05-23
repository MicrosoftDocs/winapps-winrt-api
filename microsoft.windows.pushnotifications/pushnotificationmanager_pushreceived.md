---
-api-id: E:Microsoft.Windows.PushNotifications.PushNotificationManager.PushReceived
-api-type: winrt event
---

# Microsoft.Windows.PushNotifications.PushNotificationManager.PushReceived

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.Windows.PushNotifications.PushNotificationManager,Microsoft.Windows.PushNotifications.PushNotificationReceivedEventArgs> PushReceived;
-->


## -description

Raised when a push notification for the app is received by the platform.

## -remarks

To ensure that the **PushReceived** event handler is called within the process of the running app, be sure to register the handler for this event before calling [Register](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.Register). Otherwise, a new process will be launched to handle the notification.

## -see-also

## -examples


