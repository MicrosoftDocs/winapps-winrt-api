---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetButtonStyle(Microsoft.Windows.AppNotifications.Builder.AppNotificationButtonStyle)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetButtonStyle(Microsoft.Windows.AppNotifications.Builder.AppNotificationButtonStyle)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationButton SetButtonStyle (Microsoft.Windows.AppNotifications.Builder.AppNotificationButtonStyle value);
-->


## -description

Sets the button style for the app notification button.

## -parameters

### -param value

A value from the [AppNotificationButtonStyle](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButtonStyle) enumeration specifying the style for the button.

## -returns

Returns the **AppNotificationButton** instance so that additional method calls can be chained.

## -remarks

Button styles are only supported for on Windows 10 Build 19041 and later. Call [AppNotificationButton.IsButtonStyleSupported](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.IsButtonStyleSupported) to determine at runtime if button styles are supported on the current device.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates checking to see if the app notification button styles are supported and if so, setting the button style.

```csharp
var button = new AppNotificationButton("Reply")
    .AddArgument("action", "reply");

if(AppNotificationButton.IsButtonStyleSupported())
{
    button.SetButtonStyle(AppNotificationButtonStyle.Critical);
}

var notification = new AppNotificationBuilder()
    .AddText("Notification text.")
    .AddButton(button)
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
        <action content='Reply' arguments='action=reply' hint-toolTip='Click to reply.'/>
    </actions>
</toast>
```
