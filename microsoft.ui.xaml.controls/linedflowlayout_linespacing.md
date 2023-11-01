---
-api-id: P:Microsoft.UI.Xaml.Controls.LinedFlowLayout.LineSpacing
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.LinedFlowLayout.LineSpacing

<!--
public double LineSpacing { get; set; }
-->


## -description

Gets or sets the vertical space between items.

## -property-value

The space (in pixels) between items on the vertical axis. Default is 0.0.

## -remarks

Set this property to specify the vertical spacing between lines.

## -see-also

## -examples

```xaml
<ItemsView ItemsSource="{x:Bind Photos}">
    <ItemsView.Layout>
        <LinedFlowLayout LineSpacing="10"/>
    </ItemsView.Layout>
</ItemsView>
```
