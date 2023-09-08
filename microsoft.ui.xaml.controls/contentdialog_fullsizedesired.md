---
-api-id: P:Microsoft.UI.Xaml.Controls.ContentDialog.FullSizeDesired
-api-type: winrt property
---

<!-- Property syntax
public bool FullSizeDesired { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.ContentDialog.FullSizeDesired

## -description

Gets or sets a value that indicates whether a request is being made to display the dialog full size.

## -xaml-syntax

```xaml
<ContentDialog FullSizeDesired="bool"/>
```

## -property-value

**true** to request that the dialog is displayed full size; otherwise, **false**. The default is **false**.

## -remarks

In a desktop app, a dialog is sized to its content by default. Requesting that it be shown at _full size_ changes the behavior to size the dialog based on set height and width proportions. The dialog does not cover the whole screen.

## -examples

## -see-also
