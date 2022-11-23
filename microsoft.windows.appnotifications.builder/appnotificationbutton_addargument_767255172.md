---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.AddArgument(System.String,System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationButton.AddArgument(System.String,System.String)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationButton AddArgument (string key, string value);
-->


## -description

Adds an argument composed of a key/value pair to the XML payload for an app notification button. 

## -parameters

### -param key

A string containing the key of the argument.

### -param value

A string containing the value of the argument.

## -returns

Returns the **AppNotificationButton** instance so that additional method calls can be chained.

## -remarks

App notification button arguments added with this method are passed to the activated application when the user clicks on the button. You can add multiple arguments to each button. You can retrieve the arguments added with this method, or add multiple arguments in one call, by accessing the [AppNotificationActivatedEventArgs.Arguments](xref:Microsoft.Windows.AppNotifications.AppNotificationActivatedEventArgs.Arguments) property.


For guidance on using the **AppNotificationBuilder** APIs to create the UI forapp notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example shows the usage of this method to add arguments to an app notification button.

```csharp
var notification = new AppNotificationBuilder()
    .AddText("Notification text.")
    .AddButton(new AppNotificationButton("Reply")
        .AddArgument("action", "reply"))
    .BuildNotification();

AppNotificationManager.Default.Show(notification);
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
        <action content='Reply' arguments='action=reply'/>
    </actions>
</toast>
```



