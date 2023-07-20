---
-api-id: P:Microsoft.UI.Xaml.Controls.ContentDialog.DefaultButton
-api-type: winrt property
---

<!-- Property syntax.
public ContentDialogButton DefaultButton { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ContentDialog.DefaultButton

## -description

Gets or sets a value that indicates which button on the dialog is the default action.

## -property-value

A value of the enumeration. The default is `None`.

## -remarks

You may optionally choose to differentiate one of the three buttons as the default button.

When you specify a default button:

- The button receives the Accent Button visual treatment.
- The button receives focus automatically when the dialog is opened unless the dialog's content contains a UI element that receives focus instead.
- The button responds to the ENTER key automatically when it has focus.
  - When the user presses the ENTER key on the keyboard, the click event or command associated with the default button is invoked and the [ContentDialogResult](contentdialogresult.md) returns the value associated with the default button.
  - If the user has placed focus on a control that handles ENTER, the default button does not respond to presses of the ENTER key.

## -see-also

[CloseButtonClick](contentdialog_closebuttonclick.md), [CloseButtonCommand](contentdialog_closebuttoncommand.md), [PrimaryButtonClick](contentdialog_primarybuttonclick.md), [PrimaryButtonCommand](contentdialog_primarybuttoncommand.md), [SecondaryButtonClick](contentdialog_secondarybuttonclick.md), [SecondaryButtonCommand](contentdialog_secondarybuttoncommand.md)

## -examples
