---
-api-id: T:Microsoft.Windows.AppNotifications.Builder.AppNotificationDuration
-api-type: winrt enum
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationDuration

<!--
public enum AppNotificationDuration
-->


## -description

Specifies the duration for which an [AppNotification](xref:Microsoft.Windows.AppNotifications.AppNotification) is displayed.

## -enum-fields

### -field Default: 0

The default duration.

### -field Long: 1

Long duration.

## -remarks

Set the duration for an app notification by calling [AppNotificationBuilder.SetDuration](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetDuration(Microsoft.Windows.AppNotifications.Builder.AppNotificationDuration)).

## -see-also

## -examples

The following example demonstrates setting the duration in the XML payload for an app notification.

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



