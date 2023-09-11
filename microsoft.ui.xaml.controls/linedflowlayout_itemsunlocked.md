---
-api-id: E:Microsoft.UI.Xaml.Controls.LinedFlowLayout.ItemsUnlocked
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.LinedFlowLayout.ItemsUnlocked

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.LinedFlowLayout,object> ItemsUnlocked;
-->


## -description

Occurs whenever items that had been locked into specific lines through [LockItemToLine](linedflowlayout_lockitemtoline_1703557441.md) method calls are unlocked again.

## -remarks

Locked items become unlocked again and trigger this event when:

- the available width for the `LinedFlowLayout` changed.
- the `ItemsSource` data source has changed. For example an item is added, removed or resized.
- the `ActualLineHeight` property changed.

## -see-also

## -examples


