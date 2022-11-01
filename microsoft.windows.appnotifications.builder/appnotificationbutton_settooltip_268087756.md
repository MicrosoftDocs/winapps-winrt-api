---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetToolTip(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetToolTip(System.String)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationButton SetToolTip (string value);
-->


## -description

Sets the tool-tip text for the app notification button.

## -parameters

### -param value

A string containing the tool-tip text.

## -returns

Returns the **AppNotificationButton** instance so that additional method calls can be chained.

## -remarks

You can also set the tool-tip text by using the [AppNotificationButton.ToolTip](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.ToolTip) property.

Tool-tip text is only supported for on Windows 10 Build 19041 and later. Call [AppNotificationButton.IsToolTipSupported](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.IsToolTipSupported) to determine at runtime if tool-tips are supported on the current device.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates the use of this method to set the tool-tip for the app notification button.

```csharp
var button = new AppNotificationButton("Reply")
    .AddArgument("action", "reply");

if (AppNotificationButton.IsToolTipSupported())
{
    button.SetToolTip("Click to reply.");
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
        <action content='Reply' arguments='action=reply' hint-toolTip='Click to reply'/>
    </actions>
</toast>
```

