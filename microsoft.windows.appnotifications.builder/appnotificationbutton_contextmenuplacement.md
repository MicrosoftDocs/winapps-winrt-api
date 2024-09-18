---
-api-id: P:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.ContextMenuPlacement
-api-type: winrt property
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.ContextMenuPlacement

<!--
public bool ContextMenuPlacement { get; set; }
-->


## -description

Gets or sets a value specifying whether the button is displayed inside the app notification context menu.

## -property-value

True if the button is placed inside the app notification context menu; otherwise, false.

## -remarks

You can also set the context menu placement value by calling [AppNotificationButton.SetContextMenuPlacement](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetContextMenuPlacement).

For guidance on using the **AppNotificationBuilder** APIs to create the UI forapp notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example shows the usage of this method to add the button to the app notification context menu.

```csharp
var button = new AppNotificationButton("More info")
    .AddArgument("action", "info");
button.ContextMenuPlacement = true;

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
        <action content='More info' arguments='action=info' placement='contextMenu'/>
    </actions>
</toast>
```
