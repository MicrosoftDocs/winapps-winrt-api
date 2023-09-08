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

> [!NOTE]
> The **AppNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

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
