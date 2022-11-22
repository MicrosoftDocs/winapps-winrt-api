---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.IsToolTipSupported
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.IsToolTipSupported

<!--
public static bool IsToolTipSupported ();
-->


## -description

Returns a value indicating whether tool-tips are supported for app notification buttons on the current device.

## -returns

True if tool-tips are supported; otherwise, false.

## -remarks

The [AppNotificationButton.SetToolTip](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetToolTip(System.String)) method allows you to provide a tool-tip string that is displayed when the user mouses over the button. This feature is only supported for on Windows 10 Build 19041 and later. This method allows you to determine at runtime if tool-tips are supported on the current device.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates checking to see if the app notification button styles are supported. 

```csharp
var button = new AppNotificationButton("Reply")
    .AddArgument("action", "reply");

if (AppNotificationButton.IsToolTipSupported())
{
    button.SetToolTip("Click to reply.");
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
        <action content='Reply' arguments='action=reply' hint-toolTip='Click to reply'/>
    </actions>
</toast>
```
