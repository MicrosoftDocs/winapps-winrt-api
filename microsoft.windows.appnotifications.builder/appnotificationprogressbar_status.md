---
-api-id: P:Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.Status
-api-type: winrt property
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.Status

<!--
public string Status { get; set; }
-->


## -description

Gets or sets the status text of an app notification progress bar.

## -property-value

A string containing the status text value.

## -remarks

You can also set the status with by calling [AppNotificationProgressBar.SetStatus](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.builder.appnotificationprogressbar.setstatus)).

The **Status** value is bound by default. Update the bound status value by assigning an [AppNotificationProgressData](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.appnotificationprogressdata) object to the [AppNotification.Progress](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.appnotification.progress)s property.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples


