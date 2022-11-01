---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetAttributionText(System.String,System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetAttributionText(System.String,System.String)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder SetAttributionText (string text, string language);
-->


## -description

Sets the attribution text for an app notification.

## -parameters

### -param text

The attribution text.

### -param language

A string containg an IETF language tag specifying the language of the attribution text.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

The following image shows the placement of attribution text on an app notification.

:::image type="content" source="images/toast-content-attribution-text.png" alt-text="A screenshot of an app notification with overridden attribution text.":::

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Notification text.")
    .SetAttributionText("Attribution text", "en-US");

AppNotificationManager.Default.Show(builder.BuildNotification());
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
            <text placement='attribution' lang='en-US'>Attribution text</text>
        </binding>
    </visual>
</toast>
```
