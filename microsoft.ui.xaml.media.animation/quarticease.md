---
-api-id: T:Microsoft.UI.Xaml.Media.Animation.QuarticEase
-api-type: winrt class
---

<!-- Class syntax.
public class QuarticEase : Windows.UI.Xaml.Media.Animation.EasingFunctionBase, Windows.UI.Xaml.Media.Animation.IQuarticEase
-->

# Microsoft.UI.Xaml.Media.Animation.QuarticEase

## -description
Represents an easing function that creates an animation that accelerates and/or decelerates using the formula *f* (*t*) = *t*<sup>4</sup>.

## -xaml-syntax
```xaml
<QuarticEase .../>
```


## -remarks
QuarticEase has the same behavior as does a [PowerEase](powerease.md) with [Power](powerease_power.md) value of 4. When [EasingMode](easingfunctionbase_easingmode.md) is **EaseIn** (the default), this easing function starts slow, remains fairly slow for most of the duration, and accelerates rapidly near the end of the duration time.

An easing function can be applied to the **EasingFunction** properties of **From**/**To**/**By** animations, or to the **EasingFunction** properties of key-frame types used for the **Easing** variants of key-frame animations. For more info, see [Key-frame animations and easing function animations](/windows/apps/design/motion/key-frame-and-easing-function-animations).

## -examples
This XAML example applies a QuarticEase easing function to a [DoubleAnimation](doubleanimation.md) to create a decelerating animation.

[!code-xaml[QuarticEase](../microsoft.ui.xaml.media.animation/code/QuarticEase/csharp/Page.xaml#SnippetQuarticEase)]

[!code-csharp[QuarticEase_code](../microsoft.ui.xaml.media.animation/code/QuarticEase/csharp/Page.xaml.cs#SnippetQuarticEase_code)]

## -see-also
[Storyboarded animations](/windows/apps/design/motion/storyboarded-animations), [Key-frame animations and easing function animations](/windows/apps/design/motion/key-frame-and-easing-function-animations), [PowerEase](powerease.md), [BackEase](backease.md), [BounceEase](bounceease.md), [CircleEase](circleease.md), [CubicEase](cubicease.md), [ElasticEase](elasticease.md), [ExponentialEase](exponentialease.md), [QuadraticEase](quadraticease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md), [QuinticEase](quinticease.md), [SineEase](sineease.md)
