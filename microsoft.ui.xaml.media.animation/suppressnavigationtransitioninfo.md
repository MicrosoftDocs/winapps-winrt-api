---
-api-id: T:Microsoft.UI.Xaml.Media.Animation.SuppressNavigationTransitionInfo
-api-type: winrt class
---

<!-- Class syntax.
public class SuppressNavigationTransitionInfo : Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo, Windows.UI.Xaml.Media.Animation.ISuppressNavigationTransitionInfo
-->

# Microsoft.UI.Xaml.Media.Animation.SuppressNavigationTransitionInfo

## -description
Specifies that animations are suppressed during navigation.

## -remarks

## -examples
You can use SuppressNavigationTransitionInfo in the place of other [NavigationTransitionInfo](navigationtransitioninfo.md) subtypes when you want to avoid playing any animation during navigation.

```csharp
// Navigate to your first page without a transition 
Frame.Navigate(typeof(MainPage), null, new SuppressNavigationTransitionInfo()); 

```

## -see-also
[NavigationTransitionInfo](navigationtransitioninfo.md), [Frame.Navigate](../microsoft.ui.xaml.controls/frame_navigate_1557370995.md)
