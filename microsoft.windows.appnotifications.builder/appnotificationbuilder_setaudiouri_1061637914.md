---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetAudioUri(Windows.Foundation.Uri)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetAudioUri(Windows.Foundation.Uri)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder SetAudioUri (System.Uri audioUri);
-->


## -description

Sets the sound file that is played when an app notification is displayed.

## -parameters

### -param audioUri

The URI of the audio file.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

The following audio file types are supported:

- .aac
- .flac
- .m4a
- .mp3
- .wav
- .wma

The following audio file sources are supported:

- ms-appx:///
- ms-resource

The following audio file sources are unsupported:

- ms-appdata
- Internet URLs, such as http://, https://
- Absolute file paths, such as C:/, F:/, etc.

You can specify a sound event, which plays a system-defined sound, by calling [SetAudioEvent](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetAudioEvent(Microsoft.Windows.AppNotifications.Builder.AppNotificationSoundEvent,Microsoft.Windows.AppNotifications.Builder.AppNotificationAudioLooping)).

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates setting an audio URI in the XML payload for an app notification.

```csharp
var builder = new AppNotificationBuilder()
    .AddText("Notification text.")
    .SetAudioUri(new Uri("ms-appx:///Audio/NotificationSound.mp3"));


AppNotificationManager.Default.Show(builder.BuildNotification());
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
        </binding>
    </visual>
    <audio src='ms-appx:///Audio/NotificationSound.mp3'/>
</toast>
```


