---
-api-id: T:Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox
-api-type: winrt class
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox

<!--
public sealed class AppNotificationComboBox
-->


## -description

Represents a combo box that is displayed on an app notification.

## -remarks

Add a combo box to the XML payload for an app notification by calling [AppNotificationBuilder.AddComboBox](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddComboBox(Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox)). Up to 5 inputs may be added to a single app notification.

## -see-also

## -examples

The following example demonstrates adding a combo box to the XML payload for an app notification. 


```csharp
var builder = new AppNotificationBuilder()
                .AddText("Notification text.")
                .AddComboBox(new AppNotificationComboBox("combobox_id")
                    .SetTitle("Select an item:")
                    .AddItem("id_one", "Item one")
                    .AddItem("id_two", "Item two")
                    .SetSelectedItem("id_one"));


AppNotificationManager.Default.Show(builder.BuildNotification());
```

The resulting XML payload if the urgent scenario is supported:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Notification text.</text>
        </binding>
    </visual>
    <actions>
        <input id='combobox_id' type='selection' title='Select an item:' defaultInput='id_one'>
            <selection id='id_one' content='Item one'/>
            <selection id='id_two' content='Item two'/>
        </input>
    </actions>
</toast>
```

