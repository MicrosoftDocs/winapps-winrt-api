---
-api-id: M:Microsoft.Windows.PushNotifications.PushNotificationManager.UnregisterAll
-api-type: winrt method
---

# Microsoft.Windows.PushNotifications.PushNotificationManager.UnregisterAll

<!--
public void UnregisterAll ();
-->


## -description

Cleans up all registration-related data for push notifications. After this, push notifications for the app will not function until [Register](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.Register) is called again.


## -remarks

Calling **UnregisterAll* is not a common scenario. In most cases, apps should use [Unregister](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.Register).

## -see-also

## -examples


