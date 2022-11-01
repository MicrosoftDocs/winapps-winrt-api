---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.#ctor(System.String)
-api-type: winrt constructor
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.#ctor(System.String)

<!--
public AppNotificationButton (string content);
-->


## -description

Initializes a new instance of the [AppNotificationButton](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton) class with the specified button text.

## -parameters

### -param content

The text displayed on the button.

## -remarks

Add an **AppNotificationButton** to the xml payload for an app notification by calling [AppNotificationBuilder.AddButton](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddButton(Microsoft.Windows.AppNotifications.Builder.AppNotificationButton)).

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example shows the usage of this method to add a button to an app notification.

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Notification text.")
    .AddButton(new AppNotificationButton("Reply")
        .AddArgument("action", "reply"));

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
        <action content='Reply' arguments='action=reply'/>
    </actions>
</toast>
```
