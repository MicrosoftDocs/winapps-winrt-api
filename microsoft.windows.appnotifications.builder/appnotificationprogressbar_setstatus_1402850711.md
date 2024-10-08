---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.SetStatus(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.SetStatus(System.String)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar SetStatus (string value);
-->


## -description

Sets the status text of an app notification progress bar.

## -parameters

### -param value

A string containing the status value.

## -returns

Returns the **AppNotificationProgressBar** instance so that additional method calls can be chained.

## -remarks

You can also set the status with the **AppNotificationProgressBar.Status** property.

The **Status** value is bound by default. Update the bound status value by assigning an [AppNotificationProgressData](xref:Microsoft.Windows.AppNotifications.AppNotificationProgressData) object to the [AppNotification.Progress](xref:Microsoft.Windows.AppNotifications.AppNotification.Progress)s property.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example illustrates how to set the **Status** property of an app notification progress bar.


```csharp
 var notification = new AppNotificationBuilder()
    .AddText("Downloading your weekly playlist...")
    .AddProgressBar(new AppNotificationProgressBar()
        .SetTitle("Progress bar title")
        .SetValue(.5)
        .SetStatus("Downloading...")
        .SetValueStringOverride("1/2 files downloaded"))
    .BuildNotification();

AppNotificationManager.Default.Show(notification);
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Downloading your weekly playlist...</text>
            <progress title='Progress bar title' status='Downloading...' value='0.5' valueStringOverride='1/2 files downloaded'/>
        </binding>
    </visual>
</toast>
```


