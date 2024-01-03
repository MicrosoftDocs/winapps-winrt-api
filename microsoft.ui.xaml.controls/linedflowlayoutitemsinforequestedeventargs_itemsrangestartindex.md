---
-api-id: P:Microsoft.UI.Xaml.Controls.LinedFlowLayoutItemsInfoRequestedEventArgs.ItemsRangeStartIndex
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.LinedFlowLayoutItemsInfoRequestedEventArgs.ItemsRangeStartIndex

<!--
public int ItemsRangeStartIndex { get; set; }
-->


## -description

Gets or sets the start of the item range with sizing information.

## -property-value

The index of the first item for which sizing information is requested.

## -remarks

The requested range starts at index `ItemsRangeStartIndex` and ends at index `ItemsRangeStartIndex` + `ItemsRangeRequestedLength` - 1.

If sizing information is available for a larger range than the requested one, this property can be updated with a smaller value that indicates the actual start of the provided range. The new value must be greater than or equal to 0.

## -see-also

## -examples


