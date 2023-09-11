---
-api-id: T:Microsoft.UI.Input.InputKeyboardSource
-api-type: winrt class
---

# Microsoft.UI.Input.InputKeyboardSource

<!--
public static class InputKeyboardSource
-->

## -description

Processes keyboard input for the current thread.

## -remarks

## -see-also

## -examples

The following example shows how to respond to an Esc key press from a [ContentIsland](../microsoft.ui.content/contentisland.md).

```csharp

class RespondToKeyDown
{
    InputKeyboardSource myInputKeyboardSource;

    public RespondToKeyDown(Microsoft.UI.Content.ContentIsland island)
    {
        myInputKeyboardSource = InputKeyboardSource.GetForIsland(island);
        myInputKeyboardSource.KeyDown += OnKeyDown;
    }

    void OnKeyDown(
        InputKeyboardSource sender,
        InputKeyboardSourceEventArgs args)
    {
        if (args.VirtualKey == Windows.System.VirtualKey.Escape)
        {
            System.Diagnostics.Debug.WriteLine("Escape key was pressed.");
            CancelCurrentOperation();
            args.Handled = true;
        }
    }
}
```
