---
-api-id: P:Microsoft.UI.Xaml.FrameworkElement.FocusVisualSecondaryBrush
-api-type: winrt property
---

<!-- Property syntax
public Microsoft.UI.Xaml.Media.Brush FocusVisualSecondaryBrush { get;  set; }
-->

# Microsoft.UI.Xaml.FrameworkElement.FocusVisualSecondaryBrush

## -description

Gets or sets the brush used to draw the inner border of a `HighVisibility` or `Reveal` focus visual for a [FrameworkElement](frameworkelement.md).

## -property-value

The brush used to draw the inner border of a [HighVisibility](focusvisualkind.md) focus visual.

## -remarks

The default colors are dependent on the [RequestedTheme](application_requestedtheme.md). Typically, the outer (primary) color is solid black, or equivalent, and the inner (secondary) color is solid white, or equivalent.

[HighVisibility](focusvisualkind.md) and [Reveal](focusvisualkind.md) focus visuals are rendered with an outer (primary) and inner (secondary) border.

For more info, see [High Visibility Focus Visuals](/windows/apps/design/input/guidelines-for-visualfeedback#high-visibility-focus-visuals) and [Reveal focus](/windows/apps/design/style/reveal-focus).

## -examples

```xaml
<!-- Specify a color directly -->
<Button Content="Button"
        FocusVisualPrimaryBrush="DarkRed"
        FocusVisualSecondaryBrush="Pink"/>

<!-- Use theme resources -->
<Button Content="Button"
        FocusVisualPrimaryBrush="{ThemeResource SystemBaseHighColor}"
        FocusVisualSecondaryBrush="{ThemeResource SystemAccentColor}"/>
```

## -see-also

[High Visibility Focus Visuals](/windows/apps/design/input/guidelines-for-visualfeedback#high-visibility-focus-visuals), [Reveal focus](/windows/apps/design/style/reveal-focus), [FocusVisualPrimaryBrush](frameworkelement_focusvisualprimarybrush.md), [FocusVisualPrimaryThickness](frameworkelement_focusvisualprimarythickness.md), [FocusVisualSecondaryThickness](frameworkelement_focusvisualsecondarythickness.md)
