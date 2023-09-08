---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationManager.UnregisterAll
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.UnregisterAll

<!--
public void UnregisterAll ();
-->

## -description

Cleans up all registration-related data for app notifications. After this, app notifications for the app will not function until until [Register](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.Register) is called again.

> [!NOTE]
> The **AppNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -remarks

If you don't intend for your app to use the app notification feature ever again, you should call **UnregisterAll** in order to clean up the registrations in the system.

## -see-also

## -examples
