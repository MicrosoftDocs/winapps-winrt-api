---
-api-id: P:Microsoft.Windows.Storage.Pickers.FileOpenPicker.FileTypeChoices
-api-type: winrt property
---

# Microsoft.Windows.Storage.Pickers.FileOpenPicker.FileTypeChoices

<!--
public System.Collections.Generic.IDictionary<string,System.Collections.Generic.IList<string>> FileTypeChoices { get; }
-->

## -description

A dictionary that groups file types into labeled choices that the file open picker dialog presents to the user.

## -property-value

A dictionary of type `IDictionary<string, IList<string>>`, where each key is a label representing a group of file types (for example, "Image Files"), and the corresponding value is a list of file extensions (for example, ".jpg", ".png") associated with that label.

## -remarks

`FileTypeChoices` takes precedence over [FileTypeFilter](fileopenpicker_filetypefilter.md) when both defined.

## -see-also

## -examples
