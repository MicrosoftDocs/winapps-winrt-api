---
-api-id: T:Microsoft.UI.Xaml.Controls.AnimatedIconSource
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.AnimatedIconSource

<!--
public class AnimatedIconSource : Microsoft.UI.Xaml.Controls.IconSource
-->

## -description

Represents a shareable object used to create an icon that displays and controls a visual that can animate in response to user interaction and visual state changes.

## -remarks

> [!NOTE]
> `AnimatedIconSource` is similar to [AnimatedIcon](animatedicon.md). However, because it is not a [FrameworkElement](../microsoft.ui.xaml/frameworkelement.md), it can be shared.

You don't set the state directly on an `AnimatedIconSource`. Instead, set the [AnimatedIcon.State](animatedicon_state.md) attached property on an ancestor element of the `AnimatedIconSource`.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Animated icon](/windows/apps/design/controls/animated-icon).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the AnimatedIcon in action](winui3gallery:/item/AnimatedIcon)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

## -see-also

[Animated icon overview](/windows/apps/design/controls/animated-icon), [AnimatedVisualPlayer](animatedvisualplayer.md), [VisualStateManager](../microsoft.ui.xaml/visualstatemanager.md), [Lottie-Windows](/windows/communitytoolkit/animations/lottie), [IAnimatedVisual](ianimatedvisual.md)
