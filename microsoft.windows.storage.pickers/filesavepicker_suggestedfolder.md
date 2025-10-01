---
-api-id: P:Microsoft.Windows.Storage.Pickers.FileSavePicker.SuggestedFolder
-api-type: winrt property
---

# Microsoft.Windows.Storage.Pickers.FileSavePicker.SuggestedFolder

<!--
public string SuggestedFolder { get; set; }
-->

## -description

The folder that is suggested for the user to save the file.

## -property-value

Gets or sets the suggested folder name for the file picker.

## -remarks

This property is only a suggestion and does not guarantee that the file will be saved in the specified folder. If not specified or the specified path doesn't exist, defaults to the last folder the user visited.

## -see-also

## -examples

The following example demonstrates how to use the **SuggestedFolder** property in a WinUI app:

```cs
var savePicker = new Microsoft.Windows.Storage.Pickers.FileSavePicker(this.AppWindow.Id)
{
    // (Optional) Sets the folder that the file save dialog displays when it opens.
    SuggestedFolder = @"C:\MyFiles"
};
```

```cpp
FileSavePicker savePicker(AppWindow().Id());

// (Optional) Sets the folder that the file save dialog displays when it opens.
savePicker.SuggestedFolder = L"C:\\MyFiles";
```
