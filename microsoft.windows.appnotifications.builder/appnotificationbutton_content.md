---
-api-id: P:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.Content
-api-type: winrt property
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.Content

<!--
public string Content { get; set; }
-->


## -description

Gets or sets the button text for an **AppNotificationButton**.

## -property-value

A string containing the button text.

## -remarks

For guidance on using the **AppNotificationBuilder** APIs to create the UI forapp notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example shows the usage of this property to set the button text for an app notification button.

```csharp
var args = new Dictionary<string, string>() { { "action", "reply" }, { "arg2", "value" } };
var button = new AppNotificationButton();
button.Content = "Reply";
button.Arguments = args;

var notification = new AppNotificationBuilder()
    .AddText("Notification text.")
    .AddButton(button)
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
    <actions>
        <action content='Reply' arguments='action=reply;arg2=value'/>
    </actions>
</toast>
```
