---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationManager.UpdateAsync(Microsoft.Windows.AppNotifications.AppNotificationProgressData,System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.UpdateAsync(Microsoft.Windows.AppNotifications.AppNotificationProgressData,System.String)

<!--
public Windows.Foundation.IAsyncOperation<Microsoft.Windows.AppNotifications.AppNotificationProgressResult> UpdateAsync (Microsoft.Windows.AppNotifications.AppNotificationProgressData data, string tag);
-->


## -description

Updates the progress data for app notifications with the specified tag identifier.

## -parameters

### -param data

An [AppNotificationProgressData](xref:Microsoft.Windows.AppNotifications.AppNotificationProgressData) representing the progress of an app notification.

### -param tag

The unique identifier for the set of notifications to be updated, accessed with the [Tag](xref:Microsoft.Windows.AppNotifications.AppNotification.Tag) property.

## -returns

An asynchronous operation that returns an [AppNotificationProgressResult](xref:Microsoft.Windows.AppNotifications.AppNotificationProgressResult) value.

## -remarks

## -see-also

[AppNotificationProgressData](xref:Microsoft.Windows.AppNotifications.AppNotificationProgressData), [Tag](xref:Microsoft.Windows.AppNotifications.AppNotification.Tag), [AppNotificationProgressResult](xref:Microsoft.Windows.AppNotifications.AppNotificationProgressResult)

## -examples


