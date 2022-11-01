---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetIcon(Windows.Foundation.Uri)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetIcon(Windows.Foundation.Uri)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationButton SetIcon (System.Uri value);
-->


## -description

Sets the icon for an **AppNotificationButton**.

## -parameters

### -param value

The URI of the button icon.

## -returns

Returns the **AppNotificationButton** instance so that additional method calls can be chained.

## -remarks

You can also set the icon for an app notification button with the [AppNotificationButton.Icon](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.Icon).

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

The following example demonstrates the use of this method to set the icon for the app notification button.

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Notification text.")
    .AddButton(new AppNotificationButton("Reply")
        .AddArgument("action", "reply")
        .SetIcon(new Uri("ms-appx:///Images/Reply.png")));

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
        <action content='Reply' arguments='action=reply' imageUri='ms-appx:///Images/Reply.png'/>
    </actions>
</toast>
```


