---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationManager.UpdateAsync(Microsoft.Windows.AppNotifications.AppNotificationProgressData,System.String,System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.UpdateAsync(Microsoft.Windows.AppNotifications.AppNotificationProgressData,System.String,System.String)

<!--
public Windows.Foundation.IAsyncOperation<Microsoft.Windows.AppNotifications.AppNotificationProgressResult> UpdateAsync (Microsoft.Windows.AppNotifications.AppNotificationProgressData data, string tag, string group);
-->

## -description

Updates the progress data for app notifications with the specified tag and group identifiers.

> [!NOTE]
> The **AppNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -parameters

### -param data

An [AppNotificationProgressData](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.appnotificationprogressdata) representing the progress of an app notification.

### -param tag

The unique identifier for the set of notifications to be updated, accessed with the [Tag](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.appnotification.tag) property.

### -param group

The unique identifier for the app notification group to be updated, accessed with the [Group](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.appnotification.group) property.

## -returns

An asynchronous operation that returns an [AppNotificationProgressResult](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.appnotificationprogressresult).

## -remarks

## -see-also

[AppNotificationProgressData](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.appnotificationprogressdata), [Tag](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.appnotification.tag), [Group](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.appnotification.group), [AppNotificationProgressResult](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.appnotificationprogressresult)

## -examples
