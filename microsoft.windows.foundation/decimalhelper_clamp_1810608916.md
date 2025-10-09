---
-api-id: M:Microsoft.Windows.Foundation.DecimalHelper.Clamp(Microsoft.Windows.Foundation.DecimalValue,Microsoft.Windows.Foundation.DecimalValue,Microsoft.Windows.Foundation.DecimalValue)
-api-type: winrt method
---

# Microsoft.Windows.Foundation.DecimalHelper.Clamp(Microsoft.Windows.Foundation.DecimalValue,Microsoft.Windows.Foundation.DecimalValue,Microsoft.Windows.Foundation.DecimalValue)

<!--
public static Microsoft.Windows.Foundation.DecimalValue Clamp (Microsoft.Windows.Foundation.DecimalValue value, Microsoft.Windows.Foundation.DecimalValue min, Microsoft.Windows.Foundation.DecimalValue max);
-->


## -description

Retrieve a decimal based on the value provided, clamped to the inclusive range of the specified minimum and maximum.

## -parameters

### -param value

The value to clamp.

### -param min

The specified minimum.

### -param max

The specified maximum.

## -returns

If *min* <= *value* <= *max*, then return *value*; otherwise, if *value* < *min*, then return *min*; otherwise, if *max* < *value*, then return *max*.

## -remarks

## -see-also

## -examples
