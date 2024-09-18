---
-api-id: M:Microsoft.Windows.PushNotifications.PushNotificationManager.Unregister
-api-type: winrt method
---

# Microsoft.Windows.PushNotifications.PushNotificationManager.Unregister

<!--
public void Unregister ();
-->

## -description

Unregisters the app from receiving [PushReceived](/windows/windows-app-sdk/api/winrt/microsoft.windows.pushnotifications/pushnotificationmanager_pushreceived) events for incoming push notifications.

> [!NOTE]
> The **PushNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -remarks

After calling **Unregister**, a new process will be launched to handle subsequent notifications.

Register to receive **PushReceived** events by calling [Register](/windows/windows-app-sdk/api/winrt/microsoft.windows.pushnotifications/pushnotificationmanager_register_292201929).

## -see-also

## -examples
