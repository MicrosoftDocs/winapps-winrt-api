---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.IsUrgentScenarioSupported
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.IsUrgentScenarioSupported

<!--
public static bool IsUrgentScenarioSupported ();
-->


## -description

Returns a value indicating whether the urgent app notification scenario is supported on the current device.

## -returns

True if the current device supports the urget app notification scenario; otherwise, false.

## -remarks

The <Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetScenario(Microsoft.Windows.AppNotifications.Builder.AppNotificationScenario)?displayProperty=nameWithType> method allows you to specify one of the scenarios from in the <xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationScenario> enumeration which causes the system to adjust some of the notification behaviors to present a consistent experience for the specified scenario. The **Urgent** scenario value is only supported for on Windows 10 Build 19041 and later. This method allows you to determine at runtime if the urgent scenario is supported on the current device.

## -see-also

## -examples


