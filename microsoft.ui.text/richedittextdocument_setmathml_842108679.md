---
-api-id: M:Microsoft.UI.Text.RichEditTextDocument.SetMathML(System.String)
-api-type: winrt method
---

# Microsoft.UI.Text.RichEditTextDocument.SetMathML(System.String)

<!--
public void SetMathML (string value);
-->

## -description

Updates the [**RichEditBox**](../microsoft.ui.xaml.controls/richeditbox.md) content with the specified Mathematical Markup Language ([MathML](https://www.w3.org/Math/)) formatted string.

## -parameters

### -param value

A MathML formatted string.

## -remarks

This method overwrites the existing content of RichEditBox.

Before calling SetMathML, applications must enable math mode by calling [SetMathMode](richedittextdocument_setmathmode_1534987059.md). This method throws an E_INVALIDARG error if the RichEditBox is not set to math mode.

This method throws an E_INVALIDARG error if *value* is not a properly formatted MathML string (the current content of the RichEditBox is also cleared).

## -see-also

[GetMathML(System.String@)](richedittextdocument_getmathml_852704083.md), [GetMathMode](richedittextdocument_getmathmode_502369603.md), [SetMathMode(Microsoft.UI.Text.RichEditMathMode)](richedittextdocument_setmathmode_1534987059.md)

## -examples

Passing the string in the example below in SetMathML will render to the RichEditBox as a math expression:

```xml
<mml:math xmlns:mml="http://www.w3.org/1998/Math/MathML" display="block">
    <mml:msup>
        <mml:mrow>
            <mml:mi mathcolor="#000000">x</mml:mi>
        </mml:mrow>
        <mml:mrow>
            <mml:mn mathcolor="#000000">3</mml:mn>
        </mml:mrow>
    </mml:msup>
    <mml:mo mathcolor="#000000">+</mml:mo>
    <mml:mi mathcolor="#000000">y</mml:mi>
    <mml:mo mathcolor="#000000">&#x3E;</mml:mo>
    <mml:mn mathcolor="#000000">5</mml:mn>
</mml:math>
```

The example above will render as a rich text formatted representation of `x³ + y > 5`.

Use GetMathML API to get MathML content for existing text in a math mode enabled RichEditBox.
