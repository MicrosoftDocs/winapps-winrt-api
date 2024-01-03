---
-api-id: M:Microsoft.UI.Xaml.Controls.LinedFlowLayout.InvalidateItemsInfo
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.LinedFlowLayout.InvalidateItemsInfo

<!--
public void InvalidateItemsInfo ();
-->


## -description

Causes the `LinedFlowLayout` to do a reflow of its items.

## -remarks

Any potential item sizing information previously collected through the [ItemsInfoRequested](linedflowlayout_itemsinforequested.md) event is discarded as part of the reflow of items. That event is then raised to retrieve the latest item sizing information given the current scrolling viewport position.

## -see-also

## -examples


