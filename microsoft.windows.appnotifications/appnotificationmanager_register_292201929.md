---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationManager.Register
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.Register

<!--
public void Register ();
-->

## -description

Registers the app to receive [NotificationInvoked](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.NotificationInvoked) events when the user interacts with an app notification.

> [!NOTE]
> The **AppNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -remarks

For packaged apps, the COM server is defined in the app manifest. The process calling **Register** and the process defined in the manifest as the COM server are required to be the same. For unpackaged apps, the calling process will be registered as the COM server and assets like the app display name and icon will be retrieved from the shell and registered as well.

To ensure that the **NotificationInvoked** event handler is called within the process of the running app, be sure to register the handler for that event before calling **Register**. Otherwise, a new process will be launched to handle the invocation.

Before your app terminates, call [Unregister](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.Unregister) to clean up resources and ensure that your app is launched for subsequent app notifications.

If you don't intend for your app to use the app notification feature ever again, you should call [UnregisterAll](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.UnregisterAll) in order to clean up the registrations in the system.

## -see-also

[NotificationInvoked](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.NotificationInvoked), [Unregister](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.Unregister), [UnregisterAll](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.UnregisterAll)

## -examples
