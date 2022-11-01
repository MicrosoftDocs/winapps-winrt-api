---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox.AddItem(System.String,System.String)
-api-type: winrt method
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox.AddItem(System.String,System.String)

<!--
public Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox AddItem (string id, string content);
-->


## -description

Adds an item to an **AppNotificationComboBox**.

## -parameters

### -param id

The id associated with the combo box item.

### -param content

The text content for the combo box item.

## -returns

Returns the **AppNotificationComboBox** instance so that additional method calls can be chained.

## -remarks

You can also set the items for an app notification combo box with the [AppNotificationComboBox.Items](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox.Items) property.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates the use of this method to add items to the app notification combo box.

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

