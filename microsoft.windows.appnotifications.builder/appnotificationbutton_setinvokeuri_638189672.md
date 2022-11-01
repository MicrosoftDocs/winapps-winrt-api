---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetInvokeUri(Windows.Foundation.Uri)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetInvokeUri(Windows.Foundation.Uri)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationButton SetInvokeUri (System.Uri protocolUri);
-->


## -description

Sets the URI that is launched when the app notification button is clicked.

## -parameters

### -param protocolUri

A **Uri** object specifying the URI to invoke.

## -returns

Returns the **AppNotificationButton** instance so that additional method calls can be chained.

## -remarks

You can use the URI to launch a web site in the default browser or to launch an app that has a registered URI scheme. For more information on launching apps with URIs see, [Launch an app with a URI](/windows/uwp/launch-resume/launch-app-with-uri).

You can also set the invoke URI for an app notification button with the [AppNotificationButton.InvokeUri](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.InvokeUri) property.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples


