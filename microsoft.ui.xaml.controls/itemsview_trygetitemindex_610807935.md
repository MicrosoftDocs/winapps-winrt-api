---
-api-id: M:Microsoft.UI.Xaml.Controls.ItemsView.TryGetItemIndex(System.Double,System.Double,System.Int32@)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.ItemsView.TryGetItemIndex(System.Double,System.Double,System.Int32@)

<!--
public bool TryGetItemIndex (double horizontalViewportRatio, double verticalViewportRatio, out int index);
-->


## -description

Retrieves the index of the closest item to a position relative to the top-left corner of the `ItemsView`.

## -parameters

### -param horizontalViewportRatio

A value that determines whether an item with its left or right edge closest to the viewport ratio point is returned.

### -param verticalViewportRatio

A value that determines whether an item with its top or bottom edge closest to the viewport ratio point is returned.

### -param index

The index of the closest item; or, -1 if the index was not found.

## -returns

`true` if the index was found. `false` if the control's inner `ItemsRepeater` or `ScrollView` part is not set, or the data source's `ItemsSource` is empty; the `index` out parameter is set to -1 in those cases.

## -remarks

This method returns `false` when the control's inner `ItemsRepeater` or `ScrollView` part is not set, or the data source's `ItemsSource` is empty. The index out parameter is set to -1 in those cases. Otherwise, the index is set to a value greater or equal to 0 and returns `true`.

The `TryGetItemIndex` method can be called in an `ItemsView.Loaded` event handler or any later time so that the inner control template parts are loaded.

The input parameters are interpreted as follows:

| **Argument value** | **Effect** |
|-|-|
| horizontalViewportRatio <= 0.5 | Return item with left edge closest to viewport ratio point. |
| horizontalViewportRatio > 0.5  | Return item with right edge closest to viewport ratio point. |
| verticalViewportRatio <= 0.5   | Return item with top edge closest to viewport ratio point.    |
| verticalViewportRatio > 0.5    | Return item with bottom edge closest to viewport ratio point. |

## -see-also

## -examples


