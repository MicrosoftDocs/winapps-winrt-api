---
-api-id: T:Microsoft.Windows.AppNotifications.Builder.AppNotificationImageCrop
-api-type: winrt enum
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationImageCrop

<!--
public enum AppNotificationImageCrop
-->


## -description

Specifies the cropping options for an image in an [AppNotification](xref:Microsoft.Windows.AppNotifications.AppNotification).

## -enum-fields

### -field Default: 0

Default. No cropping.

### -field Circle: 1

Circular cropping.

## -remarks

Set the crop for an app notification image in the call to  [AppNotificationBuilder.SetInlineImage](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetInlineImage(Windows.Foundation.Uri,Microsoft.Windows.AppNotifications.Builder.AppNotificationImageCrop,System.String)).

## -see-also

## -examples

The following example demonstrates setting an inline image in the XML payload for an app notification. 

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Notification text.")
    .SetInlineImage(new Uri("ms-appx:///Images/InlineImage.png"), AppNotificationImageCrop.Circle, "Alternate text");
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
            <image src='ms-appx:///Images/InlineImage.png' alt='Alternate text' hint-crop='circle'/>
        </binding>
    </visual>
</toast>
```


