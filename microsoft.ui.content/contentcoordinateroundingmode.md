---
-api-id: T:Microsoft.UI.Content.ContentCoordinateRoundingMode
-api-type: winrt enum
---

# Microsoft.UI.Content.ContentCoordinateRoundingMode

<!--
public enum ContentCoordinateRoundingMode
-->

## -description

Specifies the rounding methods used for converting screen coordinates (float to integer).

## -enum-fields

### -field Auto: 0

Use the current floating-point unit (FPU) setting. Default.

### -field Floor: 1

Rounds down to the largest integer less than or equal to the provided floating point number.

### -field Round: 2

Rounds up or down, depending on the value of the provided floating point number.

### -field Ceiling: 3

Rounds up to the smallest integer greater than or equal to the provided floating point number.

## -remarks

## -see-also

[ContentCoordinateConverter.ConvertLocalToScreen](/windows/windows-app-sdk/api/winrt/microsoft.ui.content.contentcoordinateconverter.convertlocaltoscreen(windows-foundation-point()-microsoft-ui-content-contentcoordinateroundingmode))

## -examples
