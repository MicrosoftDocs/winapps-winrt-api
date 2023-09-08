---
-api-id: M:Microsoft.UI.Input.InputFocusController.TrySetFocus
-api-type: winrt method
---

# Microsoft.UI.Input.InputFocusController.TrySetFocus

<!--
public bool TrySetFocus ();
-->

## -description

Attempts to set focus to the [ContentIsland](../microsoft.ui.content/contentisland.md) associated with the InputFocusController.

## -returns

True, if focus was set successfully; otherwise, false.

## -remarks

Due to other message processing requirements, focus might move from the [ContentIsland](../microsoft.ui.content/contentisland.md) by the time this request is processed.

A user might also move focus before this request is processed.

Processing this request can raise [GotFocus](inputfocuscontroller_gotfocus.md) and [LostFocus](inputfocuscontroller_lostfocus.md) events in quick succession.

## -see-also

## -examples

The following example shows how to indicate focus is on a TextBox within a [ContentIsland](../microsoft.ui.content/contentisland.md) based on pointer input.

```csharp
void OnClick(PointerPoint clickLocation) 
{
    if (IsWithinBoundsOfTextBox(clickLocation))
    {
        InputFocusController focusController = InputFocusController.GetForIsland(myIsland);

        if (!focusController.HasFocus)
        {
            bool nowHasFocus = focusController.TrySetFocus();

            // Change styling of text box based on whether the Island received focus
            if (nowHasFocus)
            {
                DrawTextBoxBorder();
            }
            else
            {
                RemoveTextBoxBorder();
            }
        }
    }
}
```
