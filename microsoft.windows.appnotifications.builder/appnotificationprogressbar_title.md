---
-api-id: P:Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.Title
-api-type: winrt property
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.Title

<!--
public string Title { get; set; }
-->


## -description

Gets or sets a the title text of an app notification progress bar.

## -property-value

A string containing the title text value.

## -remarks

You can also set the title by calling [AppNotificationProgressBar.Title](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.Title).

You can set the title text using data binding by calling [AppNotificationProgressBar.BindTitle](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.BindTitle). Update the bound status value by assigning an [AppNotificationProgressData](xref:Microsoft.Windows.AppNotifications.AppNotificationProgressData) object to the [AppNotification.Progress](xref:Microsoft.Windows.AppNotifications.AppNotification.Progress)s property.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples


