---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationManager.Unregister
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.Unregister

<!--
public void Unregister ();
-->

## -description

Unregisters the app from receiving [NotificationInvoked](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.NotificationInvoked) events when the user interacts with an app notification.

> [!NOTE]
> The **AppNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -remarks

After calling **Unregister**, any subsequent calls to invoke the Notification by the user would launch a new process"

Register to receive **NotificationInvoked** events by calling [Register](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.Register).

## -see-also

## -examples
