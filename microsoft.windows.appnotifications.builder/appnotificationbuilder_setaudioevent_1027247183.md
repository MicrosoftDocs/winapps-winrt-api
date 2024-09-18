---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetAudioEvent(Microsoft.Windows.AppNotifications.Builder.AppNotificationSoundEvent,Microsoft.Windows.AppNotifications.Builder.AppNotificationAudioLooping)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetAudioEvent(Microsoft.Windows.AppNotifications.Builder.AppNotificationSoundEvent,Microsoft.Windows.AppNotifications.Builder.AppNotificationAudioLooping)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder SetAudioEvent (Microsoft.Windows.AppNotifications.Builder.AppNotificationSoundEvent appNotificationSoundEvent, Microsoft.Windows.AppNotifications.Builder.AppNotificationAudioLooping loop);
-->


## -description

Sets the audio event and looping behavior for an app notification.

## -parameters

### -param appNotificationSoundEvent

A member of the [AppNotificationSoundEvent](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationSoundEvent) enumeration specifying a system sound to play.

### -param loop

A member of the [AppNotificationAudioLooping](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationAudioLooping) enumeration specifying the looping behavior for the audio.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

This method allows you to provide an consistent audio experience by specifying an audio event type, which uses standardized system sounds. You can specify a custom sound for an app notification by calling [SetAudioUri](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.SetAudioUri(Windows.Foundation.Uri,Microsoft.Windows.AppNotifications.Builder.AppNotificationAudioLooping)).

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates setting an audio event in the XML payload for an app notification.

```csharp
var notification = new AppNotificationBuilder()
    .AddText("Notification text.")
    .SetAudioEvent(AppNotificationSoundEvent.Alarm, AppNotificationAudioLooping.Loop)
    .BuildNotification();
    
AppNotificationManager.Default.Show(notification);
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
        </binding>
    </visual>
    <audio src='ms-winsoundevent:Notification.Looping.Alarm' loop='true'/>
</toast>
```


