---
-api-id: P:Microsoft.UI.Xaml.Controls.TextBox.TextWrapping
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.TextWrapping TextWrapping { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.TextBox.TextWrapping

## -description
Gets or sets how line breaking occurs if a line of text extends beyond the available width of the text box.

## -xaml-syntax
```xaml
<TextBlock TextWrapping="Wrap"/>
-or-
<TextBlock TextWrapping="NoWrap"/>
```


## -property-value
One of the [TextWrapping](../microsoft.ui.xaml/textwrapping.md) values. The default is **NoWrap**.

## -remarks
[TextBox](textbox.md) and [RichEditBox](richeditbox.md) don't support the **WrapWholeWords** value for their **TextWrapping** properties. If you try to use **WrapWholeWords** as a value for TextBox.TextWrapping or [RichEditBox.TextWrapping](richeditbox_textwrapping.md), an exception is thrown.

## -examples
The following example shows how you can use the TextWrapping property in XAML.



[!code-xaml[ScrollBarXAML](../microsoft.ui.xaml.controls.primitives/code/TextBoxSnippet2/csharp/Page.xaml#SnippetScrollBarXAML)]

## -see-also
