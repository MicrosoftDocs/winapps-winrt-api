---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetScenario(Microsoft.Windows.AppNotifications.Builder.AppNotificationScenario)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetScenario(Microsoft.Windows.AppNotifications.Builder.AppNotificationScenario)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder SetScenario (Microsoft.Windows.AppNotifications.Builder.AppNotificationScenario value);
-->


## -description

Sets the scenario for the app notification, which causes the system to adjust some of the notification behaviors to present a consistent experience for the specified scenario. 

## -parameters

### -param value

A value from the <xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationScenario> enumeration specifying the scenario for the app notification.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.


## -remarks

The [Urgent](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationScenario.Urgent) scenario value is only supported for on Windows 10 Build 19041 and later. Call [IsUrgentScenarioSupported](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.IsUrgentScenarioSupported) to determine at runtime if the urgent scenario is supported on the current device.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates setting the notification scenario in the XML payload for an app notification. 

```csharp
var notification = new AppNotificationBuilder()
    .AddText("Notification text.")
    .SetScenario(AppNotificationScenario.Reminder)
    .BuildNotification();

AppNotificationManager.Default.Show(notification);
```

The resulting XML payload:

```xml
<toast scenario='reminder'>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
        </binding>
    </visual>
</toast>
```
