---
-api-id: M:Microsoft.Windows.AppNotifications.AppNotificationManager.RemoveByTagAndGroupAsync(System.String,System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.AppNotificationManager.RemoveByTagAndGroupAsync(System.String,System.String)

<!--
public Windows.Foundation.IAsyncAction RemoveByTagAndGroupAsync (string tag, string group);
-->


## -description

Asynchronously removes all app notifications for the app that have the specified group and tag identifiers from Action Center.

## -parameters

### -param tag

The unique identifier for the set of notifications to be removed from the specified group, accessed with the [Tag](xref:Microsoft.Windows.AppNotifications.AppNotification.Tag) property.

### -param group

The unique identifier for the app notification group from which notifications to be removed, accessed with the [Group](xref:Microsoft.Windows.AppNotifications.AppNotification.Group) property.

## -returns

An asynchronous action.

## -remarks

Both the *tag* and *group* parameters must be non-empty strings.

## -see-also

## -examples


