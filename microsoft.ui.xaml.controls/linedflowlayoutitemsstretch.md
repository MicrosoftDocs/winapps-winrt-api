---
-api-id: T:Microsoft.UI.Xaml.Controls.LinedFlowLayoutItemsStretch
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.LinedFlowLayoutItemsStretch

<!--
public enum LinedFlowLayoutItemsStretch
-->


## -description

Defines constants that specify how items are sized to fill the available space in a [LinedFlowLayout](linedflowlayout.md).

## -enum-fields

### -field None: 0

The item retains its natural size. Use of extra space is determined by the [ItemsJustification](linedflowlayout_itemsjustification.md) property.

### -field Fill: 1

The item is sized to fill the available space in the non-scrolling direction. Item size in the scrolling direction is not changed.

## -remarks

This screenshot shows a gallery of photos laid out with the default stretch value of `None`.

:::image type="content" source="images/layout/lined-flow-layout-stretch-none.png" alt-text="An image gallery. Items in the first two rows are not stretched and there is blank space at the end of the rows.":::

This screenshot shows the same gallery of photos laid out with the stretch value of `Fill`.

:::image type="content" source="images/layout/lined-flow-layout-stretch-Fill.png" alt-text="A screenshot of an image gallery. Items in the first two rows are stretched horizontally to take up all available space.":::

## -see-also

## -examples


