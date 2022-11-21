---
-api-id: P:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.ButtonStyle
-api-type: winrt property
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.ButtonStyle

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationButtonStyle ButtonStyle { get; set; }
-->


## -description

Gets or sets the style of a button.

## -property-value

A value from the [AppNotificationButtonStyle](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButtonStyle) enumeration specifying the style of the button.

## -remarks

For guidance on using the **AppNotificationBuilder** APIs to create the UI forapp notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example shows the usage of this property to set the style of an app notification button.

```csharp
var notification = new AppNotificationBuilder()
    .AddText("Notification text.")
    .AddButton(new AppNotificationButton("Reply")
        .AddArgument("action", "reply")
        .SetButtonStyle(AppNotificationButtonStyle.Critical))
    .BuildNotification();

AppNotificationManager.Default.Show(notification);
```

The resulting XML payload:

```xml
<toast useButtonStyle='true'>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
        </binding>
    </visual>
    <actions>
        <action content='Reply' arguments='action=reply' hint-buttonStyle='Critical'/>
    </actions>
</toast>
```

