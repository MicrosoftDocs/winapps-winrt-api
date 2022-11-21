---
-api-id: P:Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox.Title
-api-type: winrt property
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox.Title

<!--
public string Title { get; set; }
-->


## -description

Gets or sets the title for an app notification combo box.

## -property-value

A string containing the title of the combo box.

## -remarks

You can also set the title with the [AppNotificationComboBox.SetTitle](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationComboBox.SetTitle(System.String)) property.

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates the use of this property to set the title for the app notification combo box.

```csharp
var comboBox = new AppNotificationComboBox("combobox_id");
comboBox.Title = "Select an item:";
comboBox.Items = new Dictionary<string, string> { { "id_one", "Item one" }, { "id_two", "Item two" } };
comboBox.SelectedItem = "id_one";

var notification = new AppNotificationBuilder()
    .AddText("Notification text.")
    .AddComboBox(comboBox)
    .BuildNotification();

AppNotificationManager.Default.Show(notification);
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


