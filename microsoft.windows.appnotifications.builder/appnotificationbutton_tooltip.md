---
-api-id: P:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.ToolTip
-api-type: winrt property
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.ToolTip

<!--
public string ToolTip { get; set; }
-->


## -description

Gets or sets the tool-tip text for the app notification button.

## -property-value

A string containing the tool-tip text.

## -remarks

You can also set the tool-tip text by calling the [AppNotificationButton.SetToolTip](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetToolTip(System.String)) method.

Tool-tip text is only supported for on Windows 10 Build 19041 and later. Call [AppNotificationButton.IsToolTipSupported](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.IsToolTipSupported) to determine at runtime if tool-tips are supported on the current device.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates the use of this property to set the tool-tip for the app notification button.

```csharp
var button = new AppNotificationButton("Reply")
    .AddArgument("action", "reply");

if (AppNotificationButton.IsToolTipSupported())
{
    button.ToolTip = "Click to reply.";
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


