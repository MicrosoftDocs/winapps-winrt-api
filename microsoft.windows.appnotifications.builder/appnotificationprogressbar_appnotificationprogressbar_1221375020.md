---
-api-id: M:Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.#ctor
-api-type: winrt constructor
---

# Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar.#ctor

<!--
public AppNotificationProgressBar ();
-->


## -description

Initializes a new instance of the [AppNotificationProgressBar](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar) class.

## -remarks

Add a progress bar to the XML payload for an app notification by calling [AppNotificationBuilder.AddProgressBar](xref:Microsoft.Windows.AppNotifications.Builder.AppNotificationBuilder.AddProgressBar(Microsoft.Windows.AppNotifications.Builder.AppNotificationProgressBar)). 

For guidance on using the **AppNotificationBuilder** APIs to create the UI for app notifications, see [App notification content](/windows/apps/design/shell/tiles-and-notifications/adaptive-interactive-toasts).

For reference information about the XML schema for app notifications, see [App notification content schema](/windows/apps/design/shell/tiles-and-notifications/toast-schema).

## -see-also

## -examples

The following example demonstrates adding a progress bar to the XML payload for an app notification. 

```csharp
var notification = new AppNotificationBuilder()
    .AddText("Downloading your weekly playlist...")
    .AddProgressBar(new AppNotificationProgressBar()
        .BindTitle()
        .BindStatus()
        .BindValue()
        .BindValueStringOverride())
        .SetTag(tagName)
        .SetGroup(groupName)
    .BuildNotification();

var data = new AppNotificationProgressData (sequenceNumber /* Sequence number */);
data.Title = "Retreiving files"; // Binds to {progressTitle} in xml payload
data.Value = (double) currentFile / totalFiles; // Binds to {progressValue} in xml payload
data.ValueStringOverride = String.Format("{0}/{1} files", currentFile, totalFiles); // Binds to {progressValueString} in xml payload
data.Status = "Downloading..."; // Binds to {progressStatus} in xml payload

notification.Progress = data;

AppNotificationManager.Default.Show(notification);
```

The resulting XML payload:

```xml
<toast>
    <visual>
        <binding template='ToastGeneric'>
            <text>Downloading your weekly playlist...</text>
            <progress title='{progressTitle}' status='{progressStatus}' value='{progressValue}' valueStringOverride='{progressValueString}'/>
        </binding>
    </visual>
</toast>
```

Update the bound values by calling [AppNotificationManager.UpdateAsync](xref:Microsoft.Windows.AppNotifications.AppNotificationManager.UpdateAsync(Microsoft.Windows.AppNotifications.AppNotificationProgressData,System.String)) and specifying the tag, and optionally the group, of the tag you want to update.

```csharp
private async Task UpdateProgressBar()
{
    var data = new AppNotificationProgressData(sequenceNumber /* Sequence number */);
    data.Title = "Retreiving files"; // Binds to {progressTitle} in xml payload
    data.Value = (double)currentFile / totalFiles; // Binds to {progressValue} in xml payload
    data.ValueStringOverride = String.Format("{0}/{1} files", currentFile, totalFiles); // Binds to {progressValueString} in xml payload
    data.Status = (currentFile < totalFiles) ? "Downloading..." : "Complete!"; // Binds to {progressStatus} in xml payload

    await AppNotificationManager.Default.UpdateAsync(data, tagName, groupName);
}
```

