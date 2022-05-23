---
-api-id: T:Microsoft.Windows.PushNotifications.PushNotificationChannelStatus
-api-type: winrt enum
---

# Microsoft.Windows.PushNotifications.PushNotificationChannelStatus

<!--
public enum PushNotificationChannelStatus
-->


## -description

Specifies the status of a push channel created with a call to [CreateChannelAsync](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.CreateChannelAsync(System.Guid)).

## -enum-fields

### -field InProgress: 0

The push channel creation request is in progress.

### -field InProgressRetry: 1

The push channel creation request is in progress and is in a backoff retry state. Check the [PushNotificationCreateChannelResult.ExtendedError](xref:Microsoft.Windows.PushNotifications.PushNotificationCreateChannelResult.ExtendedError) property to get the last extended error seen when creating a channel request.

### -field CompletedSuccess: 2

The push channel creation request completed succesfully.

### -field CompletedFailure: 3

The push channel creation request failed with a critical internal error. Check the **PushNotificationCreateChannelResult.ExtendedError** property to get the last extended error seen when creating a channel request.

## -remarks

## -see-also

## -examples


