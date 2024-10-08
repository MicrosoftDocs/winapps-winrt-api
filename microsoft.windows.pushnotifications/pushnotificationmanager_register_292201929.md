---
-api-id: M:Microsoft.Windows.PushNotifications.PushNotificationManager.Register
-api-type: winrt method
---

# Microsoft.Windows.PushNotifications.PushNotificationManager.Register

<!--
public void Register ();
-->

## -description

Registers the app to receive [PushReceived](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.PushReceived) events when incoming notifications are received.

> [!NOTE]
> The **PushNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -remarks

For packaged apps, the COM server is defined in the app manifest. The process calling **Register** and the process defined in the manifest as the COM server are required to be the same. For unpackaged apps, the calling process will be registered as the COM server.

To ensure that the **PushReceived** event handler is called within the process of the running app, be sure to register the handler for that event before calling **Register**. Otherwise, a new process will be launched to handle the notification.

Before your app terminates, call [Unregister](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.Unregister) or [UnregisterAll](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.UnregisterAll).

## -see-also

## -examples
