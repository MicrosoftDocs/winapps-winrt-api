---
-api-id: T:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton
-api-type: winrt class
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton

<!--
public sealed class AppNotificationButton
-->


## -description

Represents a button that is displayed on an app notification.

## -remarks

Add a button to the XML payload for an app notification by calling [AppNotificationBuilder.AddButton](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddButton(Microsoft.Windows.AppNotifications.Builder.AppNotificationButton)). Up to 5 buttons may be added to a single app notification.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates adding a button to the XML payload for an app notification. 

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Send a message.")
    .AddTextBox("textBox")
    .AddButton(new AppNotificationButton("Send")
        .AddArgument("action", "sendMessage"));

AppNotificationManager.Default.Show(builder.BuildNotification());
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Send a message.</text>
        </binding>
    </visual>
    <actions>
        <input id='textBox' type='text'/><action content='Send' arguments='action=sendMessage'/>
    </actions>
</toast>
```


