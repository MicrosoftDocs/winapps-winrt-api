---
-api-id: T:Microsoft.Windows.PushNotifications.PushNotificationCreateChannelStatus
-api-type: winrt struct
---

# Microsoft.Windows.PushNotifications.PushNotificationCreateChannelStatus

<!--
public struct PushNotificationCreateChannelStatus
-->


## -description

Provides status information for a push channel creation request initiated with a call to [CreateChannelAsync](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.CreateChannelAsync(System.Guid)).

## -struct-fields

### -field extendedError

The last extended error seen during channel creation.

### -field retryCount

The current count of retry attempts made by the platform.

### -field status

A member of the [PushNotificationChannelStatus](xref:Microsoft.Windows.PushNotifications.PushNotificationChannelStatus) enumeration specifying the current status of the push notification channel.

## -remarks

## -see-also

## -examples


