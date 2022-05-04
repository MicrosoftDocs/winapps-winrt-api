---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationManager.UpdateAsync(Microsoft.Windows.AppNotifications.AppNotificationProgressData,System.String,System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.UpdateAsync(Microsoft.Windows.AppNotifications.AppNotificationProgressData,System.String,System.String)

<!--
public Windows.Foundation.IAsyncOperation<Microsoft.Windows.AppNotifications.AppNotificationProgressResult> UpdateAsync (Microsoft.Windows.AppNotifications.AppNotificationProgressData data, string tag, string group);
-->


## -description

Updates the progress data for app notifications with the specified tag and group identifiers.

## -parameters

### -param data

An [AppNotificationProgressData](xref:Microsoft.Windows.AppNotifications.AppNotificationProgressData) representing the progress of an app notification.

### -param tag

The unique identifier for the set of notifications to be updated, accessed with the [Tag](xref:Microsoft.Windows.AppNotifications.AppNotification.Tag) property.

### -param group

The unique identifier for the app notification group to be updated, accessed with the [Group](xref:Microsoft.Windows.AppNotifications.AppNotification.Group) property.

## -returns

An asynchronous operation that returns an [AppNotificationProgressResult](xref:Microsoft.Windows.AppNotifications.AppNotificationProgressResult).

## -remarks

## -see-also

[AppNotificationProgressData](xref:Microsoft.Windows.AppNotifications.AppNotificationProgressData), [Tag](xref:Microsoft.Windows.AppNotifications.AppNotification.Tag), [Group](xref:Microsoft.Windows.AppNotifications.AppNotification.Group), [AppNotificationProgressResult](xref:Microsoft.Windows.AppNotifications.AppNotificationProgressResult)

## -examples


