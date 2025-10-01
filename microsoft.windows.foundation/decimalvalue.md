---
-api-id: T:Microsoft.Windows.Foundation.DecimalValue
-api-type: winrt struct
---

# Microsoft.Windows.Foundation.DecimalValue

<!--
public struct DecimalValue
-->


## -description

A Windows Runtime (WinRT) representation with the identical memory layout and encoding of the Win32 [DECIMAL](/windows/win32/api/wtypes/ns-wtypes-decimal-r1) structure. The Win32 DECIMAL structure's definition is valid for COM, but not for WinRT (making this equivalent structure necessary).

## -struct-fields

### -field Hi32

### -field Lo64

### -field Reserved

### -field Scale

Allowed values: 0-28.

### -field Sign

Allowed values: 0x80 = negative, 0x00 = zero or positive.

## -remarks

## -see-also

## -examples
