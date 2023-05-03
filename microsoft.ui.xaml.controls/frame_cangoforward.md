---
-api-id: P:Microsoft.UI.Xaml.Controls.Frame.CanGoForward
-api-type: winrt property
---

<!-- Property syntax
public bool CanGoForward { get; }
-->

# Microsoft.UI.Xaml.Controls.Frame.CanGoForward

## -description

Gets a value that indicates whether there is at least one entry in forward navigation history.

## -property-value

`true` if there is at least one entry in forward navigation history; `false` if there are no entries in forward navigation history or the [Frame](frame.md) does not own its own navigation history.

## -remarks

You should check that the `CanGoForward` property is `true` before you call [GoForward](frame_goforward_1537152893.md). If you call `GoForward` while `CanGoForward` is `false`, an exception is thrown.

## -examples

```csharp
if (contentFrame.CanGoForward)
{
    contentFrame.GoForward();
}
```

## -see-also

[CanGoBack](frame_cangoback.md), [GoForward](frame_goforward_1537152893.md)
