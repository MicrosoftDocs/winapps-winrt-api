---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddText(System.String,Microsoft.Windows.AppNotifications.Builder.AppNotificationTextProperties)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddText(System.String,Microsoft.Windows.AppNotifications.Builder.AppNotificationTextProperties)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder AddText (string text, Microsoft.Windows.AppNotifications.Builder.AppNotificationTextProperties properties);
-->


## -description

Adds a block of text, with display and localization options, to the XML payload for an app notification.

## -parameters

### -param text

A string containing the text to be displayed on the app notification.

### -param properties

An [AppNotificationTextProperties](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationTextProperties) specifying display and localization properties for the text.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notificiation content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates adding a text block to the XML payload for an app notification. 

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Notification text.", new AppNotificationTextProperties().SetMaxLines(2));

AppNotificationManager.Default.Show(builder.BuildNotification());
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text hint-maxLines='2'>Notification text.</text>
        </binding>
    </visual>
</toast>
```




