---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddArgument(System.String,System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddArgument(System.String,System.String)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder AddArgument (string key, string value);
-->


## -description

Adds an argument composed of a key/value pair to the XML payload for an app notification. 

## -parameters

### -param key

A string containing the key of the argument.

### -param value

A string containing the value of the argument.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

App notification arguments added with this method are passed to the activated application when the user clicks on the notification. You can add multiple arguments to each notification. Retrieve the arguments added with this method by accessing the [AppNotificationActivatedEventArgs.Arguments](/windows/windows-app-sdk/api/winrt/microsoft.windows.appnotifications.appnotificationactivatedeventargs.arguments) property.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example shows the usage of **AddArgument** to add a key/value argument to an app notification.

```csharp
var notification = new AppNotificationBuilder()
    .AddArgument("conversationId", "9813")
    .AddText("Photos from our trip")
    .AddText("Check out these pictures of our trip!")
    .BuildNotification();

AppNotificationManager.Default.Show(notification);
```

The resulting XML payload:

```xml
<toast launch='conversationId=9813'>
    <visual>
        <binding template='ToastGeneric'>
            <text>Photos from our trip</text>
            <text>Check out these pictures of our trip!</text>
        </binding>
    </visual>
</toast>
```




