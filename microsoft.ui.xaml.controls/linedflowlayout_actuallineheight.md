---
-api-id: P:Microsoft.UI.Xaml.Controls.LinedFlowLayout.ActualLineHeight
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.LinedFlowLayout.ActualLineHeight

<!--
public double ActualLineHeight { get; }
-->


## -description

Gets effective fixed height of the lines.

## -property-value

The effective fixed height of the lines.

## -remarks

The `LineHeight` property may be set to its default `NaN` value, therefore, you can use the `ActualLineHeight` property get the effective height of the lines. That fallback value is based on the desired size (`UIElement.DesiredSize`) of the item at index 0.

Returns 0.0 when the `LinedFlowLayout`'s consuming `ItemsRepeater` has not been loaded or has not yet been involved in a layout pass that renders the UI.

## -see-also

## -examples


