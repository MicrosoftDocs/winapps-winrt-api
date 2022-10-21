---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetAttributionText(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetAttributionText(System.String)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder SetAttributionText (string text);
-->


## -description

Sets the attribution text for an app notification.

## -parameters

### -param text

The attribution text.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

The following image shows the placement of attribution text on an app notification.

:::image type="content" source="images/toast-content-attribution-text.png" alt-text="A screenshot of an app notification with overridden attribution text.":::

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notificiation content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates setting the attribution text in the XML payload for an app notification.

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Notification text.")
    .SetAttributionText("Attribution text");

AppNotificationManager.Default.Show(builder.BuildNotification());
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
            <text placement='attribution'>Attribution text</text>
        </binding>
    </visual>
</toast>
```



