---
-api-id: T:Microsoft.Windows.PushNotifications.PushNotificationChannel
-api-type: winrt class
---

# Microsoft.Windows.PushNotifications.PushNotificationChannel

<!--
public sealed class PushNotificationChannel
-->


## -description

Represents a push notification channel.

## -remarks

Request a push notification channel by calling [CreateChannelAsync](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.CreateChannelAsync(System.Guid)), passing in the Azure Active Directory (AAD) application ID for your app. Upon successful completion, pass the value of the [Uri](xref:Microsoft.Windows.PushNotifications.PushNotificationChannel.Uri) property to your cloud service. Your cloud service uses this URI to send a notification request to the Windows Push Notification Service (WNS) to request for a push notification to be sent to the device, invoking [PushReceived](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.PushReceived) event.

## -see-also



## -examples


