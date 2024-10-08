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

True if the current device supports the urgent app notification scenario; otherwise, false.

## -remarks

The [AppNotificationBuilder.SetScenario](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetScenario(Microsoft.Windows.AppNotifications.Builder.AppNotificationScenario)) method allows you to specify one of the scenarios from the [AppNotificationScenario](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationScenario) enumeration which causes the system to adjust some of the notification behaviors to present a consistent experience for the specified scenario. The **Urgent** scenario value is only supported for on Windows 10 Build 19041 and later. This method allows you to determine at runtime if the urgent scenario is supported on the current device.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates checking to see if the urgent app notification scenario is supported. 

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Notification text.");

if (AppNotificationBuilder.IsUrgentScenarioSupported())
{
    builder.SetScenario(AppNotificationScenario.Urgent);
}

AppNotificationManager.Default.Show(builder.BuildNotification());
```

The resulting XML payload if the urgent scenario is supported:

```xml
<toast scenario='urgent'>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
        </binding>
    </visual>
</toast>
```


