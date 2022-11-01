---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddTextBox(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddTextBox(System.String)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder AddTextBox (string id);
-->


## -description

Adds a text box to the XML payload for an app notification. 

## -parameters

### -param id

The ID of the text box.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

Up to five input controls can be added to a single notification.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates adding a text box to the XML payload for an app notification. 

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Notification text.")
    .AddTextBox("textBox");

AppNotificationManager.Default.Show(builder.BuildNotification());
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
        <input id='textBox' type='text'/>
    </actions>
</toast>
```


