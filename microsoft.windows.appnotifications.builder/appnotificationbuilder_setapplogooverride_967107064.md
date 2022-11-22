---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetAppLogoOverride(Windows.Foundation.Uri,Microsoft.Windows.AppNotifications.Builder.AppNotificationImageCrop,System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetAppLogoOverride(Windows.Foundation.Uri,Microsoft.Windows.AppNotifications.Builder.AppNotificationImageCrop,System.String)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder SetAppLogoOverride (System.Uri imageUri, Microsoft.Windows.AppNotifications.Builder.AppNotificationImageCrop imageCrop, string alternateText);
-->


## -description

Sets the image that is displayed on the left side of an app notification, using the specified cropping method and alternate text.

## -parameters

### -param imageUri

The URI of the app logo override image file.

### -param imageCrop

A member of the [AppNotificationImageCrop](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationImageCrop) enumeration specifying the cropping method.

### -param alternateText

A string containing the alternate text for the app logo override image.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

The following screenshot illustrates the placement of the app logo override image with the **Circle** cropping method.

:::image type="content" source="images/toast-content-hint-crop.png" alt-text="A screenshot of an app notification with a circle-cropped image":::

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
var notification = new AppNotificationBuilder()
    .AddText("Notification text.")
    .SetAppLogoOverride(new Uri("ms-appx:///Images/AppLogo.png"), 
        AppNotificationImageCrop.Circle,
        "Alternate text")
    .BuildNotification();

AppNotificationManager.Default.Show(notification);
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
            <image placement='appLogoOverride' src='ms-appx:///Images/AppLogo.png' alt='Alternate text' hint-crop='circle'/>
        </binding>
    </visual>
</toast>
```


