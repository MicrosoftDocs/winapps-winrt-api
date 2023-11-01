---
-api-id: P:Microsoft.UI.Xaml.Controls.LinedFlowLayout.MinItemSpacing
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.LinedFlowLayout.MinItemSpacing

<!--
public double MinItemSpacing { get; set; }
-->


## -description

Gets or sets the minimum space between items on the horizontal axis.

## -property-value

The minimum space (in pixels) between items on the horizontal axis. The default is 0.0.

## -remarks

The spacing may exceed this minimum value when [ItemsStretch](linedflowlayout_itemsstretch.md) is set to `None` and [ItemsJustification](linedflowlayout_itemsjustification.md) is set to `SpaceEvenly`, `SpaceAround`, or `SpaceBetween`.

## -see-also

## -examples

```xaml
<ItemsView ItemsSource="{x:Bind Photos}">
    <ItemsView.Layout>
        <LinedFlowLayout MinItemSpacing="6"/>
    </ItemsView.Layout>
</ItemsView>
```
