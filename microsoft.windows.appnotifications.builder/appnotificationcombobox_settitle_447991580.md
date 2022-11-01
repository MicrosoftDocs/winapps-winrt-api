---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox.SetTitle(System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox.SetTitle(System.String)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox SetTitle (string value);
-->


## -description

Sets the title for an app notification combo box.

## -parameters

### -param value

A string containing the title of the combo box.

## -returns

Returns the **AppNotificationComboBox** instance so that additional method calls can be chained.

## -remarks

You can also set the title with the [AppNotificationComboBox.Title](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox.Title) property.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates the use of this method to set the selected title for the app notification combo box.

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


