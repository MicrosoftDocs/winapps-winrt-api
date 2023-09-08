---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationManager.RemoveByTagAsync(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.RemoveByTagAsync(System.String)

<!--
public Windows.Foundation.IAsyncAction RemoveByTagAsync (string tag);
-->

## -description

Asynchronously removes all app notifications for the app that have the specified tag identifier from Notification Center (called Action Center in Windows 10).

> [!NOTE]
> The **AppNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -parameters

### -param tag

The unique identifier for the set of notifications to be removed, accessed with the [Tag](xref:Microsoft.Windows.AppNotifications.AppNotification.Tag) property.

## -returns

An asynchronous action.

## -remarks

## -see-also

## -examples
