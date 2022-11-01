---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetInvokeUri(Windows.Foundation.Uri,System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetInvokeUri(Windows.Foundation.Uri,System.String)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationButton SetInvokeUri (System.Uri protocolUri, string targetAppId);
-->


## -description

Sets the URI that is launched when the app notification button is clicked, with a provided Package Family Name (PFN) for disambiguation.

## -parameters

### -param protocolUri

A **Uri** object specifying the URI to invoke.

### -param targetAppId

A string containing the PFN of the target app, to support cases where multiple apps are registered for a single protocol scheme.

## -returns

Returns the **AppNotificationButton** instance so that additional method calls can be chained.

## -remarks

You can use the URI to launch a web site in the default browser or to launch an app that has a registered URI scheme. For more information on launching apps with URIs see, [Launch an app with a URI](/windows/uwp/launch-resume/launch-app-with-uri).

You can also set the invoke URI for an app notification button with the [AppNotificationButton.InvokeUri](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.InvokeUri) property.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples


