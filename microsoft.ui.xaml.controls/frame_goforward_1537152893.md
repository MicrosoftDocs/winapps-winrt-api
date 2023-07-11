---
-api-id: M:Microsoft.UI.Xaml.Controls.Frame.GoForward
-api-type: winrt method
---

<!-- Method syntax
public void GoForward()
-->

# Microsoft.UI.Xaml.Controls.Frame.GoForward

## -description

Navigates to the most recent item in forward navigation history, if a [Frame](frame.md) manages its own navigation history.

## -remarks

You should check that the [CanGoForward](frame_cangoforward.md) property is `true` before you call `GoForward`. If you call `GoForward` while `CanGoForward` is `false`, an exception is thrown.

## -examples

```csharp
if (contentFrame.CanGoForward)
{
    contentFrame.GoForward();
}
```

## -see-also

[CanGoForward](frame_cangoforward.md), [GoBack](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.frame.goback)
