---
-api-id: M:Microsoft.UI.Xaml.Controls.Frame.GoBack
-api-type: winrt method
---

<!-- Method syntax
public void GoBack()
-->

# Microsoft.UI.Xaml.Controls.Frame.GoBack

## -description

Navigates to the most recent item in back navigation history, if a [Frame](frame.md) manages its own navigation history.

## -remarks

You should check that the [CanGoBack](frame_cangoback.md) property is `true` before you call `GoBack`. If you call `GoBack` while `CanGoBack` is `false`, an exception is thrown.

## -examples

```csharp
if (contentFrame.CanGoBack)
{
    contentFrame.GoBack();
}
```

## -see-also
