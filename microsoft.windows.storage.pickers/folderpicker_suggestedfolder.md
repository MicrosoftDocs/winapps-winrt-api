---
-api-id: P:Microsoft.Windows.Storage.Pickers.FolderPicker.SuggestedFolder
-api-type: winrt property
---

# Microsoft.Windows.Storage.Pickers.FolderPicker.SuggestedFolder

<!--
public string SuggestedFolder { get; set; }
-->

## -description

Gets or sets the folder that the folder picker dialog always tries to display when it opens.    

## -property-value

A string representing the path of the suggested folder.

## -remarks

The picker doesn't override `SuggestedFolder` with the last picked folder. If you don't specify `SuggestedFolder`, or if the specified path doesn't exist, the picker defaults to the last folder the user picked. On first launch of the picker, `SuggestedFolder` takes precedence over the [SuggestedStartFolder](folderpicker_suggestedstartfolder.md) if both are set.

## -see-also

[SuggestedStartFolder](folderpicker_suggestedstartfolder.md)

## -examples


