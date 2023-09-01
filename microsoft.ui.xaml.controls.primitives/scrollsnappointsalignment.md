---
-api-id: T:Microsoft.UI.Xaml.Controls.Primitives.ScrollSnapPointsAlignment
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.Primitives.ScrollSnapPointsAlignment

<!--
public enum ScrollSnapPointsAlignment
-->


## -description

Defines constants that specify options for snap point alignment relative to a viewport edge. Which edge depends on the orientation of the object where the alignment is applied.

## -enum-fields

### -field Near: 0

Use snap points grouped closer to the orientation edge.

### -field Center: 1

Use snap points that are centered in the orientation.

### -field Far: 2

Use snap points grouped farther from the orientation edge.

## -remarks

For a vertically oriented element, `Near` is the top and `Far` is the bottom. For a horizontally oriented element, `Near` is left and `Far` is right.

To learn more about the swipe gesture and panning, see the "Panning behaviors" section of [Guidelines for panning](/windows/uwp/input-and-devices/guidelines-for-panning).

## -see-also

## -examples


