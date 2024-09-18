---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationManager.Show(Microsoft.Windows.AppNotifications.AppNotification)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.Show(Microsoft.Windows.AppNotifications.AppNotification)

<!--
public void Show (Microsoft.Windows.AppNotifications.AppNotification notification);
-->

## -description

Displays the specified app notification in Action Center.

> [!NOTE]
> The **AppNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -parameters

### -param notification

An [AppNotification](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications/appnotification) object representing the notification to be shown.

## -remarks

> [!IMPORTANT]
> Your app must call [Register](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications/appnotificationmanager_register_292201929) before calling **Show**.

## -see-also

## -examples
