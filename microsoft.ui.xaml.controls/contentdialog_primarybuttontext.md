---
-api-id: P:Microsoft.UI.Xaml.Controls.ContentDialog.PrimaryButtonText
-api-type: winrt property
---

<!-- Property syntax
public string PrimaryButtonText { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ContentDialog.PrimaryButtonText

## -description

Gets or sets the text to display on the primary button.

## -xaml-syntax

```xaml
<ContentDialog PrimaryButtonText="string"/>
```

## -property-value

The text to display on the primary button. To hide this button, set the text to `null` or an empty string. The default is an empty string.

## -remarks

ContentDialog has a built-in primary button that you can use by setting this property to a non-empty string. The primary button is hidden when this property is set to an empty string or `null`.

Invoking the primary button closes the dialog with a return value of `ContentDialogResult.Primary`. It also raises the [PrimaryButtonClick](contentdialog_primarybuttonclick.md) event, which you can optionally handle, and invokes any [PrimaryButtonCommand](contentdialog_primarybuttoncommand.md) that is set.

## -examples

## -see-also

[PrimaryButtonClick](contentdialog_primarybuttonclick.md), [PrimaryButtonCommand](contentdialog_primarybuttoncommand.md), [PrimaryButtonStyle](contentdialog_primarybuttonstyle.md), [IsPrimaryButtonEnabled](contentdialog_isprimarybuttonenabled.md)
