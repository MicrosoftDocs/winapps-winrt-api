---
-api-id: T:Microsoft.UI.Xaml.Controls.WrapGrid
-api-type: winrt class
---

<!-- Class syntax.
public class WrapGrid : Windows.UI.Xaml.Controls.Primitives.OrientedVirtualizingPanel, Windows.UI.Xaml.Controls.IWrapGrid
-->

# Microsoft.UI.Xaml.Controls.WrapGrid

## -description

Positions child elements sequentially from left to right or top to bottom. When elements extend beyond the container edge, elements are positioned in the next row or column. Can only be used to display items in an [ItemsControl](itemscontrol.md). See Remarks.

## -xaml-syntax

```xaml
<WrapGrid ...>
  oneOrMoreUIElements
</WrapGrid>
```

## -remarks

> [!IMPORTANT]
> [ItemsWrapGrid](itemswrapgrid.md) is used as the default [ItemsPanel](itemscontrol_itemspanel.md) for [GridView](gridview.md). If you modify the [ItemsPanel](itemscontrol_itemspanel.md), we recommend you use [ItemsStackPanel](itemsstackpanel.md) or [ItemsWrapGrid](itemswrapgrid.md) instead of [VirtualizingStackPanel](virtualizingstackpanel.md) or WrapGrid.

WrapGrid can only be used to display items in an [ItemsControl](itemscontrol.md).

The content of a WrapGrid is virtualized. This can improve performance when you work with large data sets. For more info, see [Optimize ListView and GridView](/windows/uwp/debug-test-perf/optimize-gridview-and-listview).

In a WrapGrid, elements are arranged in rows or columns that automatically wrap to a new row or column when the [MaximumRowsOrColumns](wrapgrid_maximumrowsorcolumns.md) value is reached. The [Orientation](wrapgrid_orientation.md) property specifies whether the grid adds its items in rows or columns before wrapping.

When the value is **Vertical**, the grid adds items in columns from top to bottom, then wraps from left to right, like this:

<table>
   <tr><td>Item 1</td><td>Item 4</td><td>Item 7</td></tr>
   <tr><td>Item 2</td><td>Item 5</td><td>Item 8</td></tr>
   <tr><td>Item 3</td><td>Item 6</td><td>Item 9</td></tr>
</table>

When the value is **Horizontal**, the grid adds items in rows from left to right, then wraps from top to bottom, like this:

<table>
   <tr><td>Item 1</td><td>Item 2</td><td>Item 3</td></tr>
   <tr><td>Item 4</td><td>Item 5</td><td>Item 6</td></tr>
   <tr><td>Item 7</td><td>Item 8</td><td>Item 9</td></tr>
</table>

## -examples

## -see-also
[OrientedVirtualizingPanel](../microsoft.ui.xaml.controls.primitives/orientedvirtualizingpanel.md), [IScrollSnapPointsInfo](../microsoft.ui.xaml.controls.primitives/iscrollsnappointsinfo.md), [ItemsControl.ItemsPanel](itemscontrol_itemspanel.md), [ItemsPanelTemplate](itemspaneltemplate.md), [List view and grid view](/windows/apps/design/controls/listview-and-gridview)
