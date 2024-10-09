---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddComboBox(Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddComboBox(Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder AddComboBox (Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox value);
-->


## -description

Adds a combo box to the XML payload for an app notification. 

## -parameters

### -param value

An [AppNotificationComboBox](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox) object representing the combo box to be added to the notification.

## -returns

Returns the **AppNotificationBuilder** instance so that additional method calls can be chained.

## -remarks

Up to five input controls can be added to a single notification.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates adding a combo box to an app notification.

```csharp
var notification = new AppNotificationBuilder()
    .AddText("Can you attend?")
    .AddComboBox(new AppNotificationComboBox("ComboBox")
        .AddItem("yes", "Going")
        .AddItem("maybe", "Maybe")
        .AddItem("no", "Decline")
        .SetSelectedItem("yes"))
    .BuildNotification();

AppNotificationManager.Default.Show(notification);
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Can you attend?</text>
        </binding>
    </visual>
    <actions>
        <input id='ComboBox' type='selection' defaultInput='yes'>
            <selection id='maybe' content='Maybe'/><selection id='no' content='Decline'/>
            <selection id='yes' content='Going'/>
        </input>
    </actions>
</toast>
```
