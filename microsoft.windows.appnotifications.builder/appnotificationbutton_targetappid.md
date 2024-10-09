---
-api-id: P:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.TargetAppId
-api-type: winrt property
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.TargetAppId

<!--
public string TargetAppId { get; set; }
-->


## -description

Gets or sets the Package Family Name (PFN) for the app to be launched when the app notification button is clicked.

## -property-value

A string containing the PFN of the target app.

## -remarks

You should set either the [InvokeUri](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.InvokeUri) or the **TargetAppId**, but not both. If you do set both, the system will use the **TargetAppId**.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples


