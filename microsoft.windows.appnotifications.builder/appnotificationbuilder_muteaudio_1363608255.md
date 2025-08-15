---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.MuteAudio
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.MuteAudio

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder MuteAudio ();
-->


## -description

Requests that the system mute any audio associated with the app notification.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

To specify the audio for an app notification, use [SetAudioEvent](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.builder.appnotificationbuilder.setaudioevent) or [SetAudioUri](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.builder.appnotificationbuilder.setaudiouri).

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates requesting audio muting in the XML payload for an app notification.

```csharp
var notification = new AppNotificationBuilder()
    .AddText("Notification text.")
    .MuteAudio()
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
    <audio silent='true'/>
</toast>
```
