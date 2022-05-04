---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationManager.UnregisterAll
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.UnregisterAll

<!--
public void UnregisterAll ();
-->


## -description

Cleans up all registration-related data for app notifications. After this, app notifications for the app will not function until until [Register](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.Register) is called again.

## -remarks

If you don't intend for your app to use the app notification feature ever again, you should call **UnregisterAll** in order to clean up the registrations in the system.

## -see-also

## -examples


