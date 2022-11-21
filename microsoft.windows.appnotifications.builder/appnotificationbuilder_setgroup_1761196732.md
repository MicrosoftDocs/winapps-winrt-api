---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetGroup(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetGroup(System.String)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder SetGroup (string group);
-->


## -description

Sets the group identifier for an app notification.

## -parameters

### -param group

A string identifying the group to which the app notification belongs.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

You can use the group identifier to remove all app notifications in a group from the Notification Center by calling [AppNotificationManager.RemoveByGroupAsync](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.RemoveByGroupAsync(System.String)).

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates setting the group for an app notification.

```csharp
var notification = new AppNotificationBuilder()
    .AddText("Notification text.")
    .SetGroup("Notification group")
    .BuildNotification();

AppNotificationManager.Default.Show(notification);
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
        </binding>
    </visual>
</toast>
```

An example of removing all of the notifications from Notification Center by group.

```csharp
await AppNotificationManager.Default.RemoveByGroupAsync("Notification group");
```
