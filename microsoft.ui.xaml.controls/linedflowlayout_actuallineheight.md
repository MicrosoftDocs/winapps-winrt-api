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

If the [LineHeight](linedflowlayout_lineheight.md) property is set to its default `Double.NaN` value, the line height is based on the desired size (`UIElement.DesiredSize`) of the item at index 0. In this case, you can use the `ActualLineHeight` property to get the effective height of the lines.

 LinedFlowLayout is used with the [ItemsView.Layout](itemsview_layout.md) or [ItemsRepeater.Layout](itemsrepeater_layout.md) properties. When the control for which this LinedFlowLayout provides layout has not been loaded or has not yet been involved in a layout pass that renders the UI, this property value is 0.0.

## -see-also

## -examples


