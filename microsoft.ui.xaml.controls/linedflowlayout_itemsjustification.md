---
-api-id: P:Microsoft.UI.Xaml.Controls.LinedFlowLayout.ItemsJustification
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.LinedFlowLayout.ItemsJustification

<!--
public Microsoft.UI.Xaml.Controls.LinedFlowLayoutItemsJustification ItemsJustification { get; set; }
-->


## -description

Gets or sets a value that indicates how items are aligned on the horizontal axis.

## -property-value

An enumeration value that indicates how items are aligned. The default is `Start`.

## -remarks

This diagram shows the effects of each [LinedFlowLayoutItemsJustification](linedflowlayoutitemsjustification.md) enum value on the horizontal arrangement of items.

:::image type="content" source="images/layout/lined-flow-layout-justification.png" alt-text="The lined flow layout items justification enum page contains descriptions of each value shown in this diagram.":::

These screenshots show an example of each value applied to an image gallery.

:::row:::
   :::column span="":::
      `Start`
      :::image type="content" source="images/layout/lined-flow-layout-justification-start.png" alt-text="Items are aligned with the start of the line, with extra space at the end. Spacing between items does not change.":::
   :::column-end:::
   :::column span="":::
      `Center`
      :::image type="content" source="images/layout/lined-flow-layout-justification-center.png" alt-text="Items are aligned in the center of the line, with extra space at the start and end. Spacing between items does not change.":::
   :::column-end:::
   :::column span="":::
      `End`
      :::image type="content" source="images/layout/lined-flow-layout-justification-end.png" alt-text="Items are aligned with the end of the line, with extra space at the start. Spacing between items does not change.":::
   :::column-end:::
:::row-end:::
:::row:::
   :::column span="":::
      `SpaceAround`
      :::image type="content" source="images/layout/lined-flow-layout-justification-spacearound.png" alt-text="Items are aligned so that extra space is added evenly before and after each item.":::
   :::column-end:::
   :::column span="":::
      `SpaceBetween`
      :::image type="content" source="images/layout/lined-flow-layout-justification-spacebetween.png" alt-text="Items are aligned so that extra space is added evenly between adjacent items. No space is added at the start or end.":::
   :::column-end:::
   :::column span="":::
      `SpaceEvenly`
      :::image type="content" source="images/layout/lined-flow-layout-justification-spaceevenly.png" alt-text="Items are aligned so that extra space is added evenly before and after each item.":::
   :::column-end:::
:::row-end:::

## -see-also

## -examples


