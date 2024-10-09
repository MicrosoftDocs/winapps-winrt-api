---
-api-id: M:Microsoft.Windows.PushNotifications.PushNotificationManager.UnregisterAll
-api-type: winrt method
---

# Microsoft.Windows.PushNotifications.PushNotificationManager.UnregisterAll

<!--
public void UnregisterAll ();
-->

## -description

Cleans up all registration-related data for push notifications. After this, push notifications for the app will not function until [Register](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.Register) is called again.

> [!NOTE]
> The **PushNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -remarks

Calling **UnregisterAll* is not a common scenario. In most cases, apps should use [Unregister](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.Register).

## -see-also

## -examples
