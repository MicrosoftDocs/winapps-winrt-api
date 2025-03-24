---
-api-id: M:Microsoft.UI.Text.RichEditTextDocument.SetMathMode(Microsoft.UI.Text.RichEditMathMode)
-api-type: winrt method
---

# Microsoft.UI.Text.RichEditTextDocument.SetMathMode(Microsoft.UI.Text.RichEditMathMode)

<!--
public void SetMathMode (Microsoft.UI.Text.RichEditMathMode mode);
-->

## -description

Configures a [RichEditBox](../microsoft.ui.xaml.controls/richeditbox.md) to interpret input based on the specified math mode.

## -parameters

### -param mode

Specifies whether a **RichEditBox** interprets input as Mathematical Markup Language ([MathML](https://www.w3.org/Math/)) or text.

## -remarks

By default, the **RichEditBox** control does not interpret input as math. Setting *mode* to `MathOnly` enables [UnicodeMath](https://www.unicode.org/notes/tn28/UTN28-PlainTextMath-v3.1.pdf) input to be automatically recognized and converted to MathML in real time. For example, entering `4^2` converts to `4²`, and `1/2` converts to `½`. See the [WinUI 3 Gallery app](https://apps.microsoft.com/detail/9p3jfpwwdzrc) for more examples.

Changing the math mode of the **RichEditBox** clears both the current content and the Undo stack.

In `MathOnly` mode, the **RichEditBox** uses the [Cambria Math font family](/typography/font-list/cambria-math).

In `MathOnly` mode, the various GetText and SetText methods can still be used (with limited options).

## -see-also

[GetMathMode](richedittextdocument_getmathmode_502369603.md), [GetMathML(System.String@)](richedittextdocument_getmathml_852704083.md), [SetMathML(System.String)](richedittextdocument_setmathml_842108679.md)

## -examples
