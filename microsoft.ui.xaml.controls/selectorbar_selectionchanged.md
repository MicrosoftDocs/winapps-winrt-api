---
-api-id: E:Microsoft.UI.Xaml.Controls.SelectorBar.SelectionChanged
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.SelectorBar.SelectionChanged

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.SelectorBar,Microsoft.UI.Xaml.Controls.SelectorBarSelectionChangedEventArgs> SelectionChanged;
-->

## -description

Occurs when the `SelectorBar` selection changes; that is, when the `SelectedItem` property has changed.

## -remarks

This event is raised when an item is selected, which can happen in one of these ways:

- The `Tapped` event through mouse or touch
- Programmatic selection through the `SelectorBar.SelectedItem` property
- Tabbed focus changes (and a new item is selected)
- Left or right navigation within the `SelectorBar`
- UI Automation

## -see-also

## -examples
