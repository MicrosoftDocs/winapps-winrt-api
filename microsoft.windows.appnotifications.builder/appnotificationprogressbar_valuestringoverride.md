---
-api-id: P:Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.ValueStringOverride
-api-type: winrt property
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.ValueStringOverride

<!--
public string ValueStringOverride { get; set; }
-->


## -description

Gets or sets the value string override of an app notification progress bar.

## -property-value

The value string override text.

## -remarks

You can also set the value string override text by calling [AppNotificationProgressBar.SetValueStringOverride](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.SetValueStringOverride(System.String)) property.

You can set the title text using data binding by calling [AppNotificationProgressBar.BindValueStringOverride](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.BindValueStringOverride). Update the bound status value by assigning an [AppNotificationProgressData](xref:Microsoft.Windows.AppNotifications.AppNotificationProgressData) object to the [AppNotification.Progress](xref:Microsoft.Windows.AppNotifications.AppNotification.Progress)s property.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples


