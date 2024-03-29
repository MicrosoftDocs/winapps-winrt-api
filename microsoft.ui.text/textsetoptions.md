---
-api-id: T:Microsoft.UI.Text.TextSetOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Text.TextSetOptions : uint
-->

# TextSetOptions

## -description

Specifies options for setting the text in a text range.

## -enum-fields

### -field None:0

No text setting option is specified.

### -field UnicodeBidi:1

Use the Unicode bidirectional algorithm.

### -field Unlink:8

Don't include text as part of a hyperlink.

### -field Unhide:16

Don't insert as hidden text.

### -field CheckTextLimit:32

Obey the current text limit instead of increasing the limit to fit.

### -field FormatRtf:8192

Treat input text as Rich Text Format (RTF) (the Rich Text Format (RTF) text will be validated).

### -field ApplyRtfDocumentDefaults:16384

Apply the Rich Text Format (RTF) default settings for the document. Rich Text Format (RTF) often contains document default properties. These properties are typically ignored when inserting Rich Text Format (RTF) (as distinguished from opening an Rich Text Format (RTF) file).

## -remarks

## -examples

## -see-also

[RichEditTextDocument.LoadFromStream](richedittextdocument_loadfromstream_14396653.md), [RichEditTextDocument.LoadFromStream](richedittextdocument_loadfromstream_14396653.md), [RichEditTextDocument.SetText](richedittextdocument_settext_1800679787.md), [RichEditTextRange.SetText](richedittextrange_settext_1800679787.md), [RichEditTextRange.SetTextViaStream](richedittextrange_settextviastream_634552345.md), [ITextRange.SetText](itextrange_settext_1800679787.md), [ITextRange.SetTextViaStream](itextrange_settextviastream_634552345.md)
