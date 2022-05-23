---
-api-id: M:Microsoft.Windows.PushNotifications.PushNotificationManager.CreateChannelAsync(System.Guid)
-api-type: winrt method
---

# Microsoft.Windows.PushNotifications.PushNotificationManager.CreateChannelAsync(System.Guid)

<!--
public Windows.Foundation.IAsyncOperationWithProgress<Microsoft.Windows.PushNotifications.PushNotificationCreateChannelResult,Microsoft.Windows.PushNotifications.PushNotificationCreateChannelStatus> CreateChannelAsync (Guid remoteId);
-->


## -description

Asynchronously requests a push channel from the Windows Push Notification Service (WNS).

## -parameters

### -param remoteId

The remote identifier for the created push channel. This value, known as the *Azure AppId*, is a GUID that matches the application ID specified in Azure Active Directory (AAD). For information on getting your application ID, see [Use the portal to create an Azure AD application and service principal that can access resources](/azure/active-directory/develop/howto-create-service-principal-portal
)
## -returns

An asynchronous action with progress that returns a [PushNotificationCreateChannelResult](xref:Microsoft.Windows.PushNotifications.PushNotificationCreateChannelResult) on completion.

## -remarks

In most cases channel creation requests should complete in a few seconds. Because this is a network operation, channel request operations can fail initially, which triggers retry logic built-in to the platform. In these cases channel request operations can take between 2 and 16 minutes. 

## -see-also

## -examples


