---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetHeroImage(Windows.Foundation.Uri)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetHeroImage(Windows.Foundation.Uri)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder SetHeroImage (System.Uri imageUri);
-->


## -description

Sets the image that is displayed at the top of an app notification, taking up the full width of the notification.

## -parameters

### -param imageUri

The URI of the hero image file.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

The following screenshot illustrates the placement of the hero image.

:::image type="content" source="images/toast-content-hero-image.png" alt-text="A screenshot of an app notification with a hero image.":::

Supported image file types include:

- .png
- .jpg
- .svg

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates setting an app logo override image in the XML payload for an app notification. 

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Notification text.")
    .SetHeroImage(new Uri("ms-appx:///Images/HeroImage.png"));

AppNotificationManager.Default.Show(builder.BuildNotification());
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
            <image placement='hero' src='ms-appx:///Images/HeroImage.png'/>
        </binding>
    </visual>
</toast>
```


