---
-api-id: T:Microsoft.Windows.AppNotifications.Builder.AppNotificationButtonStyle
-api-type: winrt enum
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButtonStyle

<!--
public enum AppNotificationButtonStyle
-->


## -description

Specifies the button styles that can be assigned to an [AppNotificationButton](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton) to provide a consistent experience for common scenarios.

## -enum-fields

### -field Default: 0

The default style.

### -field Success: 1

The style associated with a successful action.

### -field Critical: 2

The style associated with a critical action.

## -remarks

Assign a style to an app notification button by calling [AppNotificationButton.SetButtonStyle](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetButtonStyle(Microsoft.Windows.AppNotifications.Builder.AppNotificationButtonStyle)).

Button styles are only supported for on Windows 10 Build 19041 and later. Call [AppNotificationButton.IsButtonStyleSupported](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.IsButtonStyleSupported) to determine at runtime if button styles are supported on the current device.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples


