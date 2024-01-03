---
-api-id: P:Microsoft.UI.Xaml.Controls.LinedFlowLayout.ItemsStretch
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.LinedFlowLayout.ItemsStretch

<!--
public Microsoft.UI.Xaml.Controls.LinedFlowLayoutItemsStretch ItemsStretch { get; set; }
-->


## -description

Gets or sets a value that indicates how items are sized to fill the available space.

## -property-value

An enumeration value that indicates how items are sized to fill the available space. The default is `None`.

## -remarks

Set this property to `Fill` to have items stretched horizontally to fill the width of the row. Items in the last row are not affected by this property.

This screenshot shows a gallery of photos laid out with the default stretch value of `None`.

:::image type="content" source="images/layout/lined-flow-layout-stretch-none.png" alt-text="An image gallery. Items in the first two rows are not stretched and there is blank space at the end of the rows.":::

This screenshot shows the same gallery of photos laid out with the stretch value of `Fill`.

:::image type="content" source="images/layout/lined-flow-layout-stretch-Fill.png" alt-text="A screenshot of an image gallery. Items in the first two rows are stretched horizontally to take up all available space.":::

## -see-also

## -examples


