---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationManager.GetAllAsync
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.GetAllAsync

<!--
public Windows.Foundation.IAsyncOperation<System.Collections.Generic.IList<Microsoft.Windows.AppNotifications.AppNotification>> GetAllAsync ();
-->


## -description

Gets all the app notifications for calling app that are currently displayed in Action Center.

## -returns

A list of [AppNotification](xref:Microsoft.Windows.AppNotifications.AppNotification) objects.

## -remarks

Note that the [AppNotification](xref:Microsoft.Windows.AppNotifications.AppNotification) objects returned by **GetAllAsync** will have the default values set for the [Priority](xref:Microsoft.Windows.AppNotifications.AppNotificationPriority) and [SuppressDisplay](xref:Microsoft.Windows.AppNotifications.AppNotification.SuppressDisplay) properties, because these properties are transient.

## -see-also

[AppNotification](xref:Microsoft.Windows.AppNotifications.AppNotification)

## -examples


