---
-api-id: E:Microsoft.Windows.PushNotifications.PushNotificationManager.PushReceived
-api-type: winrt event
---

# Microsoft.Windows.PushNotifications.PushNotificationManager.PushReceived

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.Windows.PushNotifications.PushNotificationManager,Microsoft.Windows.PushNotifications.PushNotificationReceivedEventArgs> PushReceived;
-->

## -description

Raised when a push notification for the app is received by the platform.

> [!NOTE]
> The **PushNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -remarks

To ensure that the **PushReceived** event handler is called within the process of the running app, be sure to register the handler for this event before calling [Register](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.Register). Otherwise, a new process will be launched to handle the notification.

## -see-also

## -examples
