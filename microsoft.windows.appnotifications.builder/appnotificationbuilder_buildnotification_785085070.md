---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.BuildNotification
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.BuildNotification

<!--
public Microsoft.Windows.AppNotifications.AppNotification BuildNotification ();
-->


## -description

Returns an [AppNotification](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications/appnotification) object representing the XML payload for an app notification.

## -returns

An [AppNotification](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications/appnotification) object. 

## -remarks

Use the methods of the [AppNotificationBuilder](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.builder/appnotificationbuilder) to assemble the elements you want to include in an app notification. Call **BuildNotificaion** to get an **AppNotification** object that you can pass into [Microsoft.Windows.AppNotifications.AppNotificationManager.Show](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications/appnotificationmanager_show_344905657).

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates building an **AppNotification** from an instance of **AppNotificationBuilder**. 

```csharp
var notification = new AppNotificationBuilder()
    .AddText("Notification text.")
    .BuildNotification();

AppNotificationManager.Default.Show(notification);
```


