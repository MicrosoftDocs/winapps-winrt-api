---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddProgressBar(Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddProgressBar(Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder AddProgressBar (Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar value);
-->


## -description

Adds a progress bar to the XML payload for an app notification. 

## -parameters

### -param value

An [AppNotificationProgressBar](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar) representing the progress bar to be added to the notification.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

Bind the fields of an [AppNotificationProgressData](xref:Microsoft.Windows.AppNotifications.AppNotificationProgressData) to set the initial values and updated status of the progress bar. For information on data binding to a progress bar in an app notification, see [App notification progress bar and data binding](/windows/apps/design/shell/tiles-and-notifications/toast-progress-bar?tabs=builder-syntax).

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notificiation content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates adding a combo box to an app notification.

```csharp
var builder = new AppNotificationBuilder()
        .AddText("Downloading this week's new music...")
        .AddProgressBar(new AppNotificationProgressBar()
            .BindTitle()
            .BindValueStringOverride());

    var data = new AppNotificationProgressData(1 /* Sequence number */);
    data.Title = "Artist Name"; // Binds to {progressTitle} in xml payload
    data.Value = 0.5; // Binds to {progressValue} in xml payload
    data.ValueStringOverride = "1/2 songs"; // Binds to {progressValueString} in xml payload
    data.Status = "Downloading..."; // Binds to {progressStatus} in xml payload

    var notification = builder.BuildNotification();
    notification.Progress = data;

    AppNotificationManager.Default.Show(notification);
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Downloading this week&apos;s new music...</text>
            <progress title='{progressTitle}' status='{progressStatus}' value='{progressValue}' valueStringOverride='{progressValueString}'/>
        </binding>
    </visual>
</toast>"
```



