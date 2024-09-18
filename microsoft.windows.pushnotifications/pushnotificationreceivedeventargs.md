---
-api-id: T:Microsoft.Windows.PushNotifications.PushNotificationReceivedEventArgs
-api-type: winrt class
---

# Microsoft.Windows.PushNotifications.PushNotificationReceivedEventArgs

<!--
public sealed class PushNotificationReceivedEventArgs
-->


## -description

Provides data for the [PushReceived](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.PushReceived) event.

## -remarks

To ensure that the **PushReceived** event handler is called within the process of the running app, be sure to register the handler for this event before calling [Register](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.Register). Otherwise, a new process will be launched to handle the notification.


## -see-also

## -examples


