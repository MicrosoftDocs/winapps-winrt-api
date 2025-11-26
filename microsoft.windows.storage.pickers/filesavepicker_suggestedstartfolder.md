---
-api-id: P:Microsoft.Windows.Storage.Pickers.FileSavePicker.SuggestedStartFolder
-api-type: winrt property
---

# Microsoft.Windows.Storage.Pickers.FileSavePicker.SuggestedStartFolder

<!--
public string SuggestedStartFolder { get; set; }
-->

## -description

Gets or sets the suggested start folder that the file save picker dialog displays when it opens.

## -property-value

A string representing the path of the suggested start folder.

## -remarks

Once the user picks from a directory, the file save picker silently ignores `SuggestedStartFolder`. If you define both `SuggestedStartFolder` and [SuggestedStartLocation](filesavepicker_suggestedstartlocation.md), `SuggestedStartFolder` takes precedence. If the folder isn't found, the file save picker falls back to [SuggestedStartLocation](filesavepicker_suggestedstartlocation.md).

## -see-also

[SuggestedStartLocation](filesavepicker_suggestedstartlocation.md)

## -examples
