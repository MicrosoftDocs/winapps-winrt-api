---
-api-id: P:Microsoft.UI.Xaml.Controls.TextBlock.IsColorFontEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsColorFontEnabled { get;  set; }
-->

# Microsoft.UI.Xaml.Controls.TextBlock.IsColorFontEnabled

## -description
Gets or sets a value that determines whether font glyphs that contain color layers, such as Segoe UI Emoji, are rendered in color.

## -xaml-syntax
```xaml
<TextBlock IsColorFontEnabled="bool" />
```


## -property-value
**true** if color glyphs show in color; otherwise, **false**. The default is **true**.

## -remarks

A font can include multiple colored layers for each glyph. For example, the Segoe UI Emoji font defines color versions of the Emoticon and other Emoji characters. By default, the `IsColorFontEnabled` property is **true** and fonts with these additional layers are rendered in color.

Some glyphs in multi-color fonts have different layout metrics when rendered in color.

## -examples

## -see-also
