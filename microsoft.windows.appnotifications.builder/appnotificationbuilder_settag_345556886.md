---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetTag(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetTag(System.String)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder SetTag (string value);
-->


## -description

Sets the tag identifier for an app notification.

## -parameters

### -param value

A string identifying the tag associated with the app notification.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

You can use the tag to remove notifications associated with the tag from the Notification Center by calling [AppNotificationManager.RemoveByTagAsync](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.RemoveByTagAsync(System.String)) or [AppNotificationManager.RemoveByTagAndGroupAsync](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.RemoveByTagAndGroupAsync(System.String,System.String)).

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates setting the tag for an app notification.

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Notification text.")
    .SetTag("Tag value");

AppNotificationManager.Default.Show(builder.BuildNotification());
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

An example of removing all of the notifications from Notification Center by tag.

```csharp
await AppNotificationManager.Default.RemoveByTagAsync("Tag value");
```
