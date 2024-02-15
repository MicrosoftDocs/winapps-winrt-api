---
-api-id: P:Microsoft.UI.Xaml.Controls.SelectorBar.SelectedItem
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.SelectorBar.SelectedItem

<!--
public Microsoft.UI.Xaml.Controls.SelectorBarItem SelectedItem { get; set; }
-->

## -description

Gets or sets the currently selected item.

## -property-value

The selected `SelectorBarItem` in the `Items` list. The default is `null`.

## -remarks

When the `SelectorBar` control gets focus and its `SelectedItem` is `null`, `SelectedItem` is automatically set to the first focusable instance in the `Items` list, if any, and the `SelectionChanged` event is raised.

If `SelectedItem` is set to `null` while the `SelectorBar` has focus, the `SelectorBar` will have no item selected but does stay focused.

If the selected `SelectorBarItem` is removed from the `Items` list, the `SelectedItem` property is automatically set to `null`.

If you set `SelectedItem` to an element that is not in the `Items` collection, or before the element is added to the collection, an error occurs.

## -see-also

## -examples


