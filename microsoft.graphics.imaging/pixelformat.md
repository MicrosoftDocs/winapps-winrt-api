---
-api-id: T:Microsoft.Graphics.Imaging.PixelFormat
-api-type: winrt enum
---

# Microsoft.Graphics.Imaging.PixelFormat

<!--
public enum PixelFormat
-->

## -description

Specifies the types of binary layouts for the underlying bitmap data.

## -enum-fields

### -field Undefined: 0

Binary format is undefined.

### -field Rgb24: 1

The binary format is 24 bits per pixel; 8 bits each are used for the red, green, and blue components.

### -field Argb32: 2

The binary format 32 bits per pixel; 8 bits each are used for the alpha, red, green, and blue components.

### -field Rgba32: 3

The binary format is 32 bits per pixel; 8 bits each are used for the red, green, blue, and alpha components. The color components are stored in red, green, blue, and alpha order.

### -field Bgra32: 4

The binary format is 32 bits per pixel; 8 bits each are used for the blue, green, red, and alpha components. The color components are stored in blue, green, red, and alpha order.

### -field Gray8: 5

The binary format is 16 bits per pixel. The color information specifies 65536 shades of gray.

## -remarks

## -see-also

## -examples
