---
-api-id: P:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.InvokeUri
-api-type: winrt property
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.InvokeUri

<!--
public System.Uri InvokeUri { get; set; }
-->


## -description

Gets or sets the URI that is launched when the app notification button is clicked.

## -property-value

A **Uri** object specifying the URI to invoke.

## -remarks

You can use the URI to launch a web site in the default browser or to launch an app that has a registered URI scheme. For more information on launching apps with URIs see, [Launch an app with a URI](/windows/uwp/launch-resume/launch-app-with-uri).

You can also set the invoke URI for an app notification button by calling [AppNotificationButton.SetInvokeUri](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.SetInvokeUri(Windows.Foundation.Uri,System.String)).

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example shows the usage of this property to set the invoke URI for an app notification button.

```csharp
var button = new AppNotificationButton("Launch URI")
    .AddArgument("action", "info");
button.InvokeUri = new Uri("https://learn.microsoft.com");

var builder = new AppNotificationBuilder()
    .AddText("Notification text.")
    .AddButton(button);

AppNotificationManager.Default.Show(builder.BuildNotification());
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
        </binding>
    </visual>
    <actions>
        <action content='' arguments='https://learn.microsoft.com/' activationType='protocol'/>
    </actions>
</toast>
```


