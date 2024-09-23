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

You can also set the title by calling [AppNotificationProgressBar.Title](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.builder.appnotificationprogressbar.title).

You can set the title text using data binding by calling [AppNotificationProgressBar.BindTitle](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.builder.appnotificationprogressbar.bindtitle). Update the bound status value by assigning an [AppNotificationProgressData](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.appnotificationprogressdata) object to the [AppNotification.Progress](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.appnotification.progress)s property.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples


