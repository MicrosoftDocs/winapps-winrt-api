---
-api-id: P:Microsoft.Windows.Storage.Pickers.FolderPicker.SuggestedStartFolder
-api-type: winrt property
---

# Microsoft.Windows.Storage.Pickers.FolderPicker.SuggestedStartFolder

<!--
public string SuggestedStartFolder { get; set; }
-->

## -description

Gets or sets the suggested start folder that the folder picker dialog displays when it opens.

## -property-value

A string representing the path of the suggested start folder.

## -remarks

Once the user has picked from a directory, `SuggestedStartFolder` will be silently ignored. Takes precedence over [SuggestedStartLocation](folderpicker_suggestedstartlocation.md) when both defined. If this folder is not found, falls back to `SuggestedStartLocation`.

## -see-also

[SuggestedStartLocation](folderpicker_suggestedstartlocation.md)

## -examples


