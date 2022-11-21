---
-api-id: T:Microsoft.Windows.AppNotifications.Builder.AppNotificationScenario
-api-type: winrt enum
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationScenario

<!--
public enum AppNotificationScenario
-->


## -description

Specifies the scenario for an app notification, which causes the system to adjust some of the notification behaviors to present a consistent experience for the specified scenario. 

## -enum-fields

### -field Default: 0

The default scenario.

### -field Reminder: 1

The reminder scenario.

### -field Alarm: 2

The alarm scenario.

### -field IncomingCall: 3

The incoming call scenario.

### -field Urgent: 4

The urgent scenario.

## -remarks

Set the scenario for an app notification XML payload by calling [AppNotificationBuilder.SetScenario](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetScenario(Microsoft.Windows.AppNotifications.Builder.AppNotificationScenario)).

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


