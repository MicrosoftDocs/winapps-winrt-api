---
-api-id: P:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.Icon
-api-type: winrt property
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.Icon

<!--
public System.Uri Icon { get; set; }
-->


## -description

Gets or sets the icon for an **AppNotificationButton**.

## -property-value

The URI of the button icon.

## -remarks

You can also set the icon for an app notification button by calling [AppNotificationButton.SetIcon](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetIcon(Windows.Foundation.Uri)).

The following screenshot illustrates an app notification button that uses an icon.

:::image type="content" source="images/toast-content-button-icons.png" alt-text="A screenshot of an app notification with buttons that use icons.":::

Supported image file types include:

- .png
- .jpg
- .svg

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example shows the usage of this property to set the icon for an app notification button.

```csharp
var button = new AppNotificationButton("Reply")
    .AddArgument("action", "reply");
button.Icon = new Uri("ms-appx:///Images/Reply.png");

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
        <action content='Reply' arguments='action=reply' imageUri='ms-appx:///Images/Reply.png'/>
    </actions>
</toast>
```
