---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetTimeStamp(Windows.Foundation.DateTime)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetTimeStamp(Windows.Foundation.DateTime)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder SetTimeStamp (System.DateTimeOffset value);
-->


## -description

Sets the custom time stamp for an app notification.

## -parameters

### -param value

A [DateTimeOffset](xref:System.DateTimeOffset) value specifying the value for the custom time stamp.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

The following screenshot illustrates the placement of the custom time stamp.

:::image type="content" source="images/toast-content-inline-image.png" alt-text="A screenshot of an app notification with a custom timestamp.":::

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates setting the custom time stamp in the XML payload for an app notification.

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Notification text.")
    .SetTimeStamp(DateTimeOffset.Now);

AppNotificationManager.Default.Show(builder.BuildNotification());
```

The resulting XML payload:

```xml
<toast displayTimestamp='2022-10-25T15:54:31-07:00'>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
        </binding>
    </visual>
</toast>
```
