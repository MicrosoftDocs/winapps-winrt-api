---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.BuildNotification
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.BuildNotification

<!--
public Microsoft.Windows.AppNotifications.AppNotification BuildNotification ();
-->


## -description

Returns an [AppNotification](xref:Microsoft.Windows.AppNotifications.AppNotification) object representing the XML payload for an app notification.

## -returns

An [AppNotification](xref:Microsoft.Windows.AppNotifications.AppNotification) object. 

## -remarks

Use the methods of the [AppNotificationBuilder](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder) to assemble the elements you want to include in an app notification. Call **BuildNotificaion** to get an **AppNotification** object that you can pass into <xref:Microsoft.Windows.AppNotifications.AppNotificationManager.Show(Microsoft.Windows.AppNotifications.AppNotification)?displayProperty=nameWithType>.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates building an **AppNotification** from an instance of **AppNotificationBuilder**. 

```csharp
var builder = new AppNotificationBuilder()
                .AddText("Notification text.");

AppNotificationManager.Default.Show(builder.BuildNotification());
```


