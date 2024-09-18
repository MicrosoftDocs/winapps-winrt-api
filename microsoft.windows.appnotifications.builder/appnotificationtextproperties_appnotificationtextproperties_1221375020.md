---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationTextProperties.#ctor
-api-type: winrt constructor
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationTextProperties.#ctor

<!--
public AppNotificationTextProperties ();
-->


## -description

Initializes a new instance of the [AppNotificationTextProperties](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationTextProperties) class, which specifies display and localization properties for the text.

## -remarks

Add text with text properties to an app notification by calling [AppNotificationBuilder.AddText](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddText(System.String,Microsoft.Windows.AppNotifications.Builder.AppNotificationTextProperties)).

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


