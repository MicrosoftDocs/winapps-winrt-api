---
-api-id: M:Microsoft.UI.Text.RichEditTextDocument.GetMathML(System.String@)
-api-type: winrt method
---

# Microsoft.UI.Text.RichEditTextDocument.GetMathML(System.String@)

<!--
public void GetMathML (out string value);
-->

## -description

Retrieves the content of the [RichEditBox](../microsoft.ui.xaml.controls/richeditbox.md) as a Mathematical Markup Language ([MathML](https://www.w3.org/Math/)) string.

## -parameters

### -param value

A MathML string.

## -remarks

Apps must enable math mode by calling [SetMathMode]((richedittextdocument_setmathmode_1534987059.md)) before calling **GetMathML**. This method throws an E_INVALIDARG error if the **RichEditBox** is not set to math mode.

## -see-also

[SetMathML(System.String)](richedittextdocument_setmathml_842108679.md), [GetMathMode](richedittextdocument_getmathmode_502369603.md), [SetMathMode(Microsoft.UI.Text.RichEditMathMode)](richedittextdocument_setmathmode_1534987059.md)

## -examples
