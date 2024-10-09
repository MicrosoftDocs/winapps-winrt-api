---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationManager.RemoveByIdAsync(System.UInt32)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.RemoveByIdAsync(System.UInt32)

<!--
public Windows.Foundation.IAsyncAction RemoveByIdAsync (uint notificationId);
-->

## -description

Asynchronously removes the app notification with the specified ID from Notification Center (called Action Center in Windows 10).

> [!NOTE]
> The **AppNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -parameters

### -param notificationId

The unique identifier for the app notification to be removed. The ID is set by the platform and can be accessed with the [Id](xref:Microsoft.Windows.AppNotifications.AppNotification.Id) property.

## -returns

An asynchronous action.

## -remarks

## -see-also

## -examples
