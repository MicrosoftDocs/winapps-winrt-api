---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationManager.GetAllAsync
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.GetAllAsync

<!--
public Windows.Foundation.IAsyncOperation<System.Collections.Generic.IList<Microsoft.Windows.AppNotifications.AppNotification>> GetAllAsync ();
-->

## -description

Gets all the app notifications for calling app that are currently displayed in Action Center.

> [!NOTE]
> The **AppNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -returns

A list of [AppNotification](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications/appnotification) objects.

## -remarks

Note that the [AppNotification](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications/appnotification) objects returned by **GetAllAsync** will have the default values set for the [Priority](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications/appnotificationpriority) and [SuppressDisplay](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications/appnotification_suppressdisplay) properties, because these properties are transient.

## -see-also

[AppNotification](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications/appnotification)

## -examples
