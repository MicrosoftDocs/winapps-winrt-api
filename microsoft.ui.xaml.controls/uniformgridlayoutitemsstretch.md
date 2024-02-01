---
-api-id: T:Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsStretch
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.UniformGridLayoutItemsStretch

<!--
public enum UniformGridLayoutItemsStretch
-->

## -description

Defines constants that specify how items are sized to fill the available space in a [UniformGridLayout](uniformgridlayout.md).

## -enum-fields

### -field Fill

The item is sized to fill the available space in the non-scrolling direction. Item size in the scrolling direction is not changed.

### -field None

The item retains its natural size. Use of extra space is determined by the [ItemsJustification](uniformgridlayout_itemsjustification.md) property.

### -field Uniform

The item is sized to both fill the available space in the non-scrolling direction and maintain its aspect ratio.

## -remarks

This enumeration provides values for the [UniformGrid.ItemsStretch](uniformgridlayout_itemsstretch.md) property.

## -see-also

[UniformGridLayout](uniformgridlayout.md), [UniformGrid.ItemsStretch](uniformgridlayout_itemsstretch.md)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [ItemsRepeater](/windows/apps/design/controls/items-repeater).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the ItemsRepeater in action](winui3gallery:/item/ItemsRepeater)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).
