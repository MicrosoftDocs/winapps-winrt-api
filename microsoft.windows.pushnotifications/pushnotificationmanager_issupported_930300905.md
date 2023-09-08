---
-api-id: M:Microsoft.Windows.PushNotifications.PushNotificationManager.IsSupported
-api-type: winrt method
---

# Microsoft.Windows.PushNotifications.PushNotificationManager.IsSupported

<!--
public static bool IsSupported ();
-->

## -description

Gets a boolean value indicating if the Microsoft.Windows.PushNotifications notification APIs are supported for the calling app. 

> [!NOTE]
> The **PushNotificationManager** class has a dependency on the [Singleton package](/windows/apps/windows-app-sdk/deployment-architecture#singleton-package). Because of that dependency, there are certain considerations to be aware of if you're calling these APIs from a [self-contained app](/windows/apps/package-and-deploy/deploy-overview). For more info, and specifics, see [Dependencies on additional MSIX packages](/windows/apps/package-and-deploy/self-contained-deploy/deploy-self-contained-apps#dependencies-on-additional-msix-packages).

## -returns

True if push notifications APIs are supported; otherwise, false.

## -remarks

If push notifications are not supported, we recommended that you use polling or your own custom socket implementation to receive payloads.

## -see-also

## -examples
