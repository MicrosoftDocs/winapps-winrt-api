---
-api-id: P:Microsoft.Windows.Storage.Pickers.FileOpenPicker.SuggestedStartFolder
-api-type: winrt property
---

# Microsoft.Windows.Storage.Pickers.FileOpenPicker.SuggestedStartFolder

<!--
public string SuggestedStartFolder { get; set; }
-->

## -description

Gets or sets the suggested start folder that the file open picker dialog displays when it opens.

## -property-value

A string representing the path of the suggested start folder.

## -remarks

Once the user picks a directory, the picker ignores `SuggestedStartFolder`. If you set both `SuggestedStartFolder` and [SuggestedStartLocation](fileopenpicker_suggestedstartlocation.md), the picker uses `SuggestedStartFolder`. If the folder isn't found, the picker falls back to [SuggestedStartLocation](fileopenpicker_suggestedstartlocation.md).

## -see-also

[SuggestedStartLocation](fileopenpicker_suggestedstartlocation.md)

## -examples
