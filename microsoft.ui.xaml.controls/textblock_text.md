---
-api-id: P:Microsoft.UI.Xaml.Controls.TextBlock.Text
-api-type: winrt property
---

<!-- Property syntax
public string Text { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.TextBlock.Text

## -description

Gets or sets the text contents of a [TextBlock](textblock.md).

## -xaml-syntax

```xaml
<TextBlock Text="string"/>
- or -
<TextBlock>string</TextBlock>
```

## -property-value

A string that specifies the text contents of this [TextBlock](textblock.md). The default is an empty string.

## -remarks

This property is not nullable. However, if you set this property to `null` (`TextBlock1.Text = null;`) no exception is thrown. Instead, it is automatically set to an empty string ("").

## -examples

## -see-also
