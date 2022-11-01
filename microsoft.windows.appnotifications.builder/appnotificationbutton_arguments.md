---
-api-id: P:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.Arguments
-api-type: winrt property
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.Arguments

<!--
public System.Collections.Generic.IDictionary<string,string> Arguments { get; set; }
-->


## -description

Gets or sets the arguments associated with the **AppNotificationButton**.

## -property-value

A dictionary of key/value pairs representing the app notification button arguments.

## -remarks

App notification button arguments added with this method are passed to the activated application when the user clicks on the button. You can add multiple arguments to each button. You can retrieve the arguments added with this method, or add multiple arguments in one call, by accessing the [AppNotificationActivatedEventArgs.Arguments](xref:Microsoft.Windows.AppNotifications.AppNotificationActivatedEventArgs.Arguments) property.

You can also add individual arguments by calling [AppNotificationButton.AddArgument](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.AddArgument(System.String,System.String)).

For guidance on using the **AppNotificationBuilder** APIs to create the UI forapp notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example shows the usage of this property to add arguments to an app notification button.

```csharp
var args = new Dictionary<string, string>() { { "action", "reply" }, { "arg2", "value" } };

var button = new AppNotificationButton("Reply");
button.Arguments = args;

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
        <action content='Reply' arguments='action=reply;arg2=value'/><
    /actions>
</toast>
```
