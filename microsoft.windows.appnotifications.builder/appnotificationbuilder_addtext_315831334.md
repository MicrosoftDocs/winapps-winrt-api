---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddText(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddText(System.String)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder AddText (string text);
-->


## -description

Adds a block of text to the XML payload for an app notification.

## -parameters

### -param text

A string containing the text to be displayed on the app notification.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

A maximum of three text elements can be added to an app notification. Exceeding this limit will throw an error.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates adding a text block to the XML payload for an app notification. 

```csharp
var notification = new AppNotificationBuilder()
    .AddText("Notification text.")
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


