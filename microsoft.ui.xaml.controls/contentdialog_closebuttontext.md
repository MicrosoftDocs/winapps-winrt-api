---
-api-id: P:Microsoft.UI.Xaml.Controls.ContentDialog.CloseButtonText
-api-type: winrt property
---

<!-- Property syntax.
public string CloseButtonText { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ContentDialog.CloseButtonText

## -description

Gets or sets the text to display on the close button.

## -xaml-syntax

```xaml
<ContentDialog CloseButtonText="string"/>
```

## -property-value

The text to display on the close button. To hide this button, set the text to `null` or an empty string. The default is an empty string.

## -remarks

Every dialog should contain a safe, nondestructive action button that enables the user to confidently exit the dialog.

ContentDialog has a built-in close button that you can use by setting this property to a non-empty string. The close button is hidden when this property is set to an empty string or `null`.

The built-in close button lets you create the right user experience for all inputs including mouse, keyboard, touch, and Xbox controller. The dialog will close when:

- the user clicks or taps on the close button.
- the user presses the system back button.
- the user presses the ESC button on keyboard.
- the user presses Xbox controller B.

Invoking the close button returns `ContentDialogResult.None`, raises the [CloseButtonClick](contentdialog_closebuttonclick.md) event, which you can optionally handle, and invokes any [CloseButtonCommand](contentdialog_closebuttoncommand.md) that is set.

## -examples

## -see-also

[CloseButtonClick](contentdialog_closebuttonclick.md), [CloseButtonCommand](contentdialog_closebuttoncommand.md), [CloseButtonStyle](contentdialog_closebuttonstyle.md)
