---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetAppLogoOverride(Windows.Foundation.Uri)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetAppLogoOverride(Windows.Foundation.Uri)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder SetAppLogoOverride (System.Uri imageUri);
-->


## -description

Sets the image that is displayed on the left side of an app notification.

## -parameters

### -param imageUri

The URI of the app logo override image file.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

The following screenshots illustrates the placement of the app logo override image.

:::image type="content" source="images/toast-content-applogooverride.png" alt-text="A screenshot of an app notification with an app logo override image.":::

Supported image file types include:

- .png
- .jpg
- .svg

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notificiation content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates setting an app logo override image in the XML payload for an app notification. 

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Notification text.")
    .SetAppLogoOverride(new Uri("ms-appx:///Images/AppLogo.png"));

AppNotificationManager.Default.Show(builder.BuildNotification());
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
            <image placement='appLogoOverride' src='ms-appx:///Images/AppLogo.png'/>
        </binding>
    </visual>
</toast>
```


