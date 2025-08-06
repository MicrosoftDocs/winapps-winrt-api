---
-api-id: T:Microsoft.Windows.PushNotifications.PushNotificationReceivedEventArgs
-api-type: winrt class
---

# Microsoft.Windows.PushNotifications.PushNotificationReceivedEventArgs

<!--
public sealed class PushNotificationReceivedEventArgs
-->


## -description

Provides data for the [PushReceived](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.PushReceived) event.

## -remarks

To ensure that the [PushReceived](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.PushReceived) event handler is called within the process of the running app, be sure to register the handler for this event before calling [Register](xref:Microsoft.Windows.PushNotifications.PushNotificationManager.Register). Otherwise, the following runtime exception will be thrown:
> System.Runtime.InteropServices.COMException: 'Element not found. Must register event handlers before calling Register().'


## -see-also

## -examples


