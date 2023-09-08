---
-api-id: T:Microsoft.UI.Xaml.Controls.ItemsViewSelectionMode
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.ItemsViewSelectionMode

<!--
public enum ItemsViewSelectionMode
-->


## -description

Defines constants that specify the selection mode of an `ItemsView`.

## -enum-fields

### -field None: 0

Item selection is disabled, whether it is through user interaction or programmatically.

### -field Single: 1

One or zero items can be selected.

### -field Multiple: 2

Zero, one, or more items can be selected.

### -field Extended: 3

Zero, one, or more items can be selected. Multiple selection requires the use of Ctrl or Shift modifier keys.

## -remarks

This table describes how each mode behaves with and without modifier keys.

| **Name** | **Behavior** |
| -- | -- |
| Single | **With no modifier keys:** A user can select a single item using the space bar, mouse click, or touch tap.<br/>**While pressing Ctrl:** A user can toggle the selection if a single item by using the space bar, mouse click, or touch tap. Using the arrow keys, a user can move focus independently of selection. |
| Multiple | **With no modifier keys:** A user can toggle the selection of a single item using the space bar, mouse click, or touch tap. <br/>**While pressing Ctrl:** Using the arrow keys, a user can move focus independently of selection.<br/>**While pressing Shift:** A user can select multiple items using a mouse click or touch tap. |
| Extended | **With no modifier keys:** A user can select a single item using the space bar, mouse click, or touch tap. Any previous selections are cleared.<br/>**While pressing Ctrl:** A user can toggle the selection of a single item by using the space bar, mouse click, or touch tap. Using the arrow keys, a user can move focus independently of selection.<br/>**While pressing Shift:** A user can select multiple items using a mouse click or touch tap. |

## -see-also

## -examples


