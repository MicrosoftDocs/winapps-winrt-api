---
-api-id: T:Microsoft.Graphics.Display.DisplayAdvancedColorKind
-api-type: winrt enum
---

# Microsoft.Graphics.Display.DisplayAdvancedColorKind

<!--
public enum DisplayAdvancedColorKind
-->

## -description

Describes the kind of Advanced Color that the display supports.

## -enum-fields

### -field StandardDynamicRange:0

The display supports only standard dynamic range. In this case, it's safe to assume that operating system (OS) composition is being done using an RGB:8 surface encoded as sRGB gamma. The actual wire signaling is usually done using sRGB.

### -field WideColorGamut:1

The display supports Wide Color Gamut. In this case, it's safe to assume that OS composition is being done using an RGB:FP16 surface encoded as scRGB gamma. The actual wire signaling is usually done using sRGB.

### -field HighDynamicRange:2

The display supports high dynamic range. In this case, it's safe to assume that OS composition is being done using an RGB:FP16 surface encoded as scRGB gamma. The actual wire signaling is usually done using ST2084. 

## -remarks

## -see-also

## -examples
