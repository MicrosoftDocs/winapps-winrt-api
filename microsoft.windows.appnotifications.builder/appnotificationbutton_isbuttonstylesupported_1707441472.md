---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.IsButtonStyleSupported
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.IsButtonStyleSupported

<!--
public static bool IsButtonStyleSupported ();
-->


## -description

Returns a value indicating whether button styles are supported for app notification buttons on the current device.

## -returns

True if button styles are supported; otherwise, false. 

## -remarks

The [AppNotificationButton.SetButtonStyle](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetButtonStyle(Microsoft.Windows.AppNotifications.Builder.AppNotificationButtonStyle)) method allows you to specify one of the button styles from the [AppNotificationButtonStyle](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButtonStyle) enumeration to provide a consistent experience for common scenarios. This feature is only supported for on Windows 10 Build 19041 and later. This method allows you to determine at runtime if button styles are supported on the current device.

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

var builder = new AppNotificationBuilder()
    .AddText("Notification text.")
    .AddButton(button);

AppNotificationManager.Default.Show(builder.BuildNotification());
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


