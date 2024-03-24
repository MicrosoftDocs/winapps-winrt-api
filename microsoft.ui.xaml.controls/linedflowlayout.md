---
-api-id: T:Microsoft.UI.Xaml.Controls.LinedFlowLayout
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.LinedFlowLayout

<!--
public class LinedFlowLayout : Microsoft.UI.Xaml.Controls.VirtualizingLayout
-->


## -description

Represents a control that positions elements sequentially from left to right, then top to bottom, in a wrapping layout, using the same height for all elements.

## -remarks

The LinedFlowLayout positions elements sequentially from left to right, then top to bottom, in a wrapping layout. Use this layout to display an item collection where the items have a fixed height but a variable width. We recommend it for image based collections. This layout also has built-in animations that play when the collection has items added or removed, and when the view is resized.

To use a LinedFlowLayout, set it as a value for the [ItemsView.Layout](itemsview_layout.md) or [ItemsRepeater.Layout](itemsrepeater_layout.md) properties.

Here's an [ItemsView](itemsview.md) control that shows a collection of photos in a lined flow layout.

```xaml
<ItemsView Width="500" Height="400" HorizontalAlignment="Left"
           ItemTemplate="{StaticResource LinedFlowLayoutItemTemplate}">
    <ItemsView.Layout>
        <LinedFlowLayout ItemsStretch="Fill" 
                         LineHeight="160" 
                         LineSpacing="5"
                         MinItemSpacing="5"/>
    </ItemsView.Layout>
</ItemsView>
```

:::image type="content" source="images/layout/itemsview-lined-flow.png" alt-text="A collection of photos shown in a lined flow layout where each item is the same height, but the width varies based on the original size of the aspect ratio of the photo.":::

LinedFlowLayout provides properties to control:

- the size and spacing of items ([LineHeight](linedflowlayout_lineheight.md), [LineSpacing](linedflowlayout_linespacing.md), [MinItemSpacing](linedflowlayout_minitemspacing.md))
- the arrangement of items ([ItemsJustification](linedflowlayout_itemsjustification.md), [ItemsStretch](linedflowlayout_itemsstretch.md))

## -see-also

[ItemsView](itemsview.md), [ItemsRepeater](itemsrepeater.md), [StackLayout](stacklayout.md), [UniformGridLayout](uniformgridlayout.md)

## -examples


