---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetInlineImage(Windows.Foundation.Uri,Microsoft.Windows.AppNotifications.Builder.AppNotificationImageCrop,System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetInlineImage(Windows.Foundation.Uri,Microsoft.Windows.AppNotifications.Builder.AppNotificationImageCrop,System.String)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder SetInlineImage (System.Uri imageUri, Microsoft.Windows.AppNotifications.Builder.AppNotificationImageCrop imagecrop, string alternateText);
-->


## -description

Sets the image that is displayed inline, after any text elements, filling the full width of the visual area in an app notification, using the specified cropping behavior.

## -parameters

### -param imageUri

The URI of the inline image file.

### -param imagecrop

A member of the [AppNotificationImageCrop](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationImageCrop) enumeration specifying the cropping method.

### -param alternateText

A string containing the alternate text for the inline image.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

The following screenshot illustrates the placement of the inline image.

:::image type="content" source="images/toast-content-inline-image.png" alt-text="A screenshot of an app notification with an inline image.":::

Supported image file types include:

- .png
- .jpg
- .svg

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates setting an inline image in the XML payload for an app notification. 

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Notification text.")
    .SetInlineImage(new Uri("ms-appx:///Images/InlineImage.png"), 
        AppNotificationImageCrop.Default);

AppNotificationManager.Default.Show(builder.BuildNotification());
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
            <image src='ms-appx:///Images/InlineImage.png' alt='Alternate text'/>
        </binding>
    </visual>
</toast>
```


