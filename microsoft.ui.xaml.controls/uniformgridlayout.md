---
-api-id: T:Microsoft.UI.Xaml.Controls.UniformGridLayout
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.UniformGridLayout

<!--
public class UniformGridLayout : Microsoft.UI.Xaml.Controls.VirtualizingLayout
-->

## -description

Positions elements sequentially from left to right or top to bottom in a wrapping layout.

## -remarks

Items are layed out in order from left-to-right when the [Orientation](uniformgridlayout_orientation.md) is `Horizontal`, and layed out top-to-bottom when the [Orientation](uniformgridlayout_orientation.md) is `Vertical`.

Every item in a UniformGridLayout is sized equally.

UniformGridLayout supports virtualization when attached to a host that supports virtualization.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [ItemsRepeater](/windows/apps/design/controls/items-repeater).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the ItemsRepeater in action](winui3gallery:/item/ItemsRepeater)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

The following example shows how to set the [ItemsRepeater.Layout](itemsrepeater_layout.md) property to a UniformGridLayout.

```xaml
<!--
    xmlns:muxc="using:Microsoft.UI.Xaml.Controls"
-->
...
<muxc:ItemsRepeater ItemsSource="{x:Bind Items}"
                    ItemTemplate="{StaticResource MyTemplate}">
    <muxc:ItemsRepeater.Layout>
        <muxc:UniformGridLayout MinItemWidth="200"
                                MinColumnSpacing="28"
                                ItemsJustification="SpaceAround"/>
    </muxc:ItemsRepeater.Layout>
</muxc:ItemsRepeater>
```

## -see-also

[UniformGridLayoutItemsJustification](uniformgridlayoutitemsjustification.md), [UniformGridLayoutItemsStretch](uniformgridlayoutitemsstretch.md), [UniformGridLayout overview](/windows/apps/design/controls/items-repeater#uniformgridlayout)
