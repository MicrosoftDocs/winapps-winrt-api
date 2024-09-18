---
-api-id: E:Microsoft.Windows.AppNotifications.AppNotificationManager.NotificationInvoked
-api-type: winrt event
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.NotificationInvoked

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.Windows.AppNotifications.AppNotificationManager,Microsoft.Windows.AppNotifications.AppNotificationActivatedEventArgs> NotificationInvoked;
-->

## -description

Raised when an app notification for the app is invoked through user interaction.

> [!NOTE]
> The **AppNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -remarks

To ensure that the **NotificationInvoked** event handler is called within the process of the running app, be sure to register the handler for this event before calling [Register](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.Register). Otherwise, a new process will be launched to handle the invocation.

## -see-also

[Register](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.Register)

## -examples
