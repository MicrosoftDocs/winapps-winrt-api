---
-api-id: P:Microsoft.UI.Xaml.Controls.AnimatedIcon.FallbackIconSource
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.AnimatedIcon.FallbackIconSource

<!--
public Microsoft.UI.Xaml.Controls.IconSource FallbackIconSource { get; set; }
-->

## -description

Gets or sets the static icon to use when the animated icon cannot run.

## -property-value

The static icon to use when the animated icon cannot run. The default is `null`.

## -remarks

The fallback icon can be any icon type that inherits from [IconSource](iconsource.md), including [BitmapIconSource](bitmapiconsource.md), [FontIconSource](fonticonsource.md), [ImageIconSource](imageiconsource.md), [PathIconSource](pathiconsource.md), and [SymbolIconSource](symboliconsource.md).

## -see-also

[Animated icon overview](/windows/apps/design/controls/animated-icon), [AnimatedIcon](animatedicon.md)

## -examples

```xaml
<!-- 
xmlns:animatedvisuals="using:Microsoft.UI.Xaml.Controls.AnimatedVisuals"
-->

<AnimatedIcon>
    <animatedvisuals:AnimatedBackVisualSource/>

    <AnimatedIcon.FallbackIconSource>
        <SymbolIconSource Symbol="Back"/>
    </AnimatedIcon.FallbackIconSource>
</AnimatedIcon>
```
