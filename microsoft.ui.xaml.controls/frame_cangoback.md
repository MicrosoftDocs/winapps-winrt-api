---
-api-id: P:Microsoft.UI.Xaml.Controls.Frame.CanGoBack
-api-type: winrt property
---

<!-- Property syntax
public bool CanGoBack { get; }
-->

# Microsoft.UI.Xaml.Controls.Frame.CanGoBack

## -description

Gets a value that indicates whether there is at least one entry in back navigation history.

## -property-value

`true` if there is at least one entry in back navigation history; `false` if there are no entries in back navigation history or the [Frame](frame.md) does not own its own navigation history.

## -remarks

You should check that the `CanGoBack` property is `true` before you call [GoBack](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.frame.goback). If you call `GoBack` while `CanGoBack` is `false`, an exception is thrown.

## -examples

```csharp
if (contentFrame.CanGoBack)
{
    contentFrame.GoBack();
}
```

## -see-also

[CanGoForward](frame_cangoforward.md), [GoBack](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.frame.goback)
