---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetDuration(Microsoft.Windows.AppNotifications.Builder.AppNotificationDuration)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetDuration(Microsoft.Windows.AppNotifications.Builder.AppNotificationDuration)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder SetDuration (Microsoft.Windows.AppNotifications.Builder.AppNotificationDuration duration);
-->


## -description

Sets the duration for an app notification.

## -parameters

### -param duration

A value from the [AppNotificationDuration](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationDuration) enumeration specifying the duration for the app notification.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notificiation content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates setting an duration in the XML payload for an app notification.

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Notification text.")
    .SetDuration(AppNotificationDuration.Long);

AppNotificationManager.Default.Show(builder.BuildNotification());
```

The resulting XML payload:

```xml
<toast duration='long'>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
        </binding>
    </visual>
</toast>
```
