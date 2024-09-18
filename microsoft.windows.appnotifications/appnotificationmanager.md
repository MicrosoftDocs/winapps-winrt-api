---
-api-id: T:Microsoft.Windows.AppNotifications.AppNotificationManager
-api-type: winrt class
---

# Microsoft.Windows.AppNotifications.AppNotificationManager

<!--
public sealed class AppNotificationManager
-->

## -description

Provides APIs for managing app notifications, including showing and removing notifications in Notification Center (called Action Center in Windows 10), updating notification progress, and registering and unregistering for app notification invocations.

> [!NOTE]
> The **AppNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -remarks

Get an instance of this class by accessing the [AppNotificationManager.Default](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.Default) property.

## -see-also

[AppNotificationManager.Default](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.Default), [AppNotification](xref:Microsoft.Windows.AppNotifications.AppNotification)

## -examples
