---
-api-id: P:Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.Value
-api-type: winrt property
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.Value

<!--
public double Value { get; set; }
-->


## -description

Gets or sets the progress value of an app notification progress bar.

## -property-value

The progress value.

## -remarks

You can also set the status by calling [AppNotificationProgressBar.SetValue](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.SetValue(System.Double)).

The **Value** value is bound by default. Update the bound status value by assigning an [AppNotificationProgressData](xref:Microsoft.Windows.AppNotifications.AppNotificationProgressData) object to the [AppNotification.Progress](xref:Microsoft.Windows.AppNotifications.AppNotification.Progress)s property.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples


