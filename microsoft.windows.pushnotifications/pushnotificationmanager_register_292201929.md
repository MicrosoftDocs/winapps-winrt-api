---
-api-id: M:Microsoft.Windows.PushNotifications.PushNotificationManager.Register
-api-type: winrt method
---

# Microsoft.Windows.PushNotifications.PushNotificationManager.Register

<!--
public void Register ();
-->


## -description

Registers the app to receive [PushReceived](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.PushReceived) events when incoming notifications are received.


## -remarks

For packaged apps, the COM server is defined in the app manifest. The process calling **Register** and the process defined in the manifest as the COM server are required to be the same. For unpackaged apps, the calling process will be registered as the COM server.

To ensure that the **PushReceived** event handler is called within the process of the running app, be sure to register the handler for that event before calling **Register**. Otherwise, a new process will be launched to handle the notification.

Before your app terminates, call [Unregister](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.Unregister) or [UnregisterAll](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.UnregisterAll).


## -see-also

## -examples


