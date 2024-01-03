---
-api-id: P:Microsoft.UI.Xaml.Controls.ContentDialog.SecondaryButtonText
-api-type: winrt property
---

<!-- Property syntax
public string SecondaryButtonText { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ContentDialog.SecondaryButtonText

## -description

Gets or sets the text to be displayed on the secondary button.

## -xaml-syntax

```xaml
<ContentDialog SecondaryButtonText="string"/>
```

## -property-value

The text to display on the secondary button. To hide this button, set the text to `null` or an empty string. The default is an empty string.

## -remarks

ContentDialog has a built-in secondary button that you can use by setting this property to a non-empty string. The secondary button is hidden when this property is set to an empty string or `null`.

Invoking the secondary button closes the dialog with a return value of `ContentDialogResult.Secondary`. It also raises the [SecondaryButtonClick](contentdialog_secondarybuttonclick.md) event, which you can optionally handle, and invokes any [SecondaryButtonCommand](contentdialog_secondarybuttoncommand.md) that is set.

## -examples

## -see-also

[SecondaryButtonClick](contentdialog_secondarybuttonclick.md), [SecondaryButtonCommand](contentdialog_secondarybuttoncommand.md), [SecondaryButtonStyle](contentdialog_secondarybuttonstyle.md), [IsSecondaryButtonEnabled](contentdialog_issecondarybuttonenabled.md)
