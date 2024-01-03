---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationManager.RemoveByGroupAsync(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.RemoveByGroupAsync(System.String)

<!--
public Windows.Foundation.IAsyncAction RemoveByGroupAsync (string group);
-->

## -description

Asynchronously removes all app notifications for the app that have the specified group identifier from Action Center.

> [!NOTE]
> The **AppNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -parameters

### -param group

The unique identifier for the app notification group to be removed, accessed with the [Group](xref:Microsoft.Windows.AppNotifications.AppNotification.Group) property.

## -returns

An asynchronous action.

## -remarks

## -see-also

## -examples
