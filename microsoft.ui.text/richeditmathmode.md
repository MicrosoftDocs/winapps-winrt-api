---
-api-id: T:Microsoft.UI.Text.RichEditMathMode
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum RichEditMathMode : int 
-->

# Microsoft.UI.Text.RichEditMathMode

## -description

Defines constants that specify whether a [RichEditBox](../microsoft.ui.xaml.controls/richeditbox.md) interprets input as math ([MathML](https://www.w3.org/Math/)) or text.

> [!IMPORTANT]
> The **Microsoft.UI.Text.RichEditMathMode** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -enum-fields

### -field NoMath:0

Input is interpreted as text.

### -field MathOnly:1

Input is interpreted as math.

## -remarks

Math mode enables users to have input automatically recognized and converted to [MathML](https://www.w3.org/Math/) while being received. For example, "4^2" is converted to "4<sup>2</sup>", and "1/2" is converted to "½".

Math mode might change formatting (fonts), context menus, and other aspects of the input.

## -see-also

## -examples
