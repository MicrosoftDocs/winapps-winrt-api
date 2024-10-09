---
-api-id: T:Microsoft.Windows.AppNotifications.Builder.AppNotificationTextProperties
-api-type: winrt class
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationTextProperties

<!--
public sealed class AppNotificationTextProperties
-->


## -description

Specifies display and localization properties for text displayed on an app notification.

## -remarks

Add text with text properties to an app notification by calling [AppNotificationBuilder.AddText](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.builder.appnotificationbuilder.addtext)).

## -see-also

## -examples

The following example demonstrates adding a text block to the XML payload for an app notification. 

```csharp
var notification = new AppNotificationBuilder()
    .AddText("Notification text.", new AppNotificationTextProperties().SetMaxLines(2))
    .BuildNotification();

AppNotificationManager.Default.Show(notification);
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


