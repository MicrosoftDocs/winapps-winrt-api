---
-api-id: P:Microsoft.UI.Xaml.Controls.LinedFlowLayout.LineHeight
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.LinedFlowLayout.LineHeight

<!--
public double LineHeight { get; set; }
-->


## -description

Gets or sets the lines fixed height.

## -property-value

The common height of all lines, and therefore of all items. The default is `Double.NaN`.

## -remarks

Set this property to specify an explicit height value for all lines in the layout.

When the default [Double.NaN](/dotnet/api/system.double.nan) value is used, the `LinedFlowLayout` uses the desired height (`UIElement.DesiredSize.Height`) of the item at index 0 as a fallback value. This means that the first item in the collection dictates how tall all lines are going to be.

In a collection of images, for example, if the natural desired size of the first [Image](image.md) is 250 x 150 pixels, all lines will be 150 pixels tall, and the [ActualLineHeight](linedflowlayout_actuallineheight.md) property returns 150. Images, except the first one, may be expanded or shrunk (according to their [Stretch](image_stretch.md) property) to fit the `ActualLineHeight` of 150.

## -see-also

[ActualLineHeight](linedflowlayout_actuallineheight.md)

## -examples

```xaml
<ItemsView ItemsSource="{x:Bind Photos}">
    <ItemsView.Layout>
        <LinedFlowLayout LineHeight="100"/>
    </ItemsView.Layout>
</ItemsView>
```
