---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetContextMenuPlacement
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetContextMenuPlacement

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationButton SetContextMenuPlacement ();
-->


## -description

Requests that the app notification button be placed in the context menu of the notification.

## -returns

Returns the **AppNotificationButton** instance so that additional method calls can be chained.

## -remarks

You can also set the context menu placement value with the [AppNotificationButton.ContextMenuPlacement](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.ContextMenuPlacement) property.

For guidance on using the **AppNotificationBuilder** APIs to create the UI forapp notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates the use of this method to set the context menu placement for the app notification button.

```csharp
var notification = new AppNotificationBuilder()
    .AddText("Notification text.")
    .AddButton(new AppNotificationButton("Reply")
        .AddArgument("action", "reply")
        .SetContextMenuPlacement())
    .BuildNotification();

AppNotificationManager.Default.Show(notification);
```

The resulting XML payload if the urgent scenario is supported:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
        </binding>
    </visual>
    <actions>
        <action content='Reply' arguments='action=reply' placement='contextMenu'/>
    </actions>
</toast>
```

