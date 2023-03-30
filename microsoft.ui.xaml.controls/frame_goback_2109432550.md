---
-api-id: M:Microsoft.UI.Xaml.Controls.Frame.GoBack(Microsoft.UI.Xaml.Media.Animation.NavigationTransitionInfo)
-api-type: winrt method
---

<!-- Method syntax
public void GoBack(Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo transitionInfoOverride)
-->

# Microsoft.UI.Xaml.Controls.Frame.GoBack

## -description

Navigates to the most recent item in back navigation history, if a [Frame](frame.md) manages its own navigation history, and specifies the animated transition to use.

## -parameters

### -param transitionInfoOverride

Info about the animated transition to use.

## -remarks

You should check that the [CanGoBack](frame_cangoback.md) property is `true` before you call `GoBack`. If you call `GoBack` while `CanGoBack` is `false`, an exception is thrown.

## -examples

```csharp
if (contentFrame.CanGoBack)
{
    contentFrame.GoBack(new SlideNavigationTransitionInfo());
}
```

## -see-also

[CanGoBack](frame_cangoback.md), [GoForward](frame_goforward_1537152893.md)
