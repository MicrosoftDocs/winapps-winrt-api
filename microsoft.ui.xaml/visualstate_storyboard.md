---
-api-id: P:Microsoft.UI.Xaml.VisualState.Storyboard
-api-type: winrt property
---

<!-- Property syntax
public Microsoft.UI.Xaml.Media.Animation.Storyboard Storyboard { get; set; }
-->

# Microsoft.UI.Xaml.VisualState.Storyboard

## -description

Gets or sets a [Storyboard](../microsoft.ui.xaml.media.animation/storyboard.md) that defines state-specific property values and appearance of the control when it is using this visual state.

## -xaml-syntax

```xaml
<VisualState>
  singleStoryboard
</VisualState>
```

## -xaml-values
<dl><dt>singleStoryboard</dt><dd>singleStoryboardA single Storyboard object element, which declares the animation storyboard to use for this state.</dd>
</dl>
## -property-value
A [Storyboard](../microsoft.ui.xaml.media.animation/storyboard.md) that defines the property changes to apply to the control when this [VisualState](visualstate.md) is used as the current visual state.

## -remarks

The value of the [Storyboard](../microsoft.ui.xaml.media.animation/storyboard.md) property is either `null` or a single `Storyboard` object. A `Storyboard` is like a container for animations; it can contain one or more animation definitions. Each such animation can target a specific dependency property on a specific named target. The named target must be an element in the control template that has a [Name](frameworkelement_name.md) or [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) value defined in the template itself. The dependency property must be a property that exists in that object's object model, or an attached property. To target animations, you use the [Storyboard.TargetName](../microsoft.ui.xaml.media.animation/storyboard_targetname.md) and [Storyboard.TargetProperty](../microsoft.ui.xaml.media.animation/storyboard_targetproperty.md) attached properties. For more info on how to define animations with XAML syntax, and the types of animations you can use, see [Storyboarded animations](/windows/apps/design/motion/storyboarded-animations).

Animations that affect layout are potentially dependent animations, which can have performance consequences for users of your control when the control loads a [VisualState](visualstate.md).

## -examples

This example creates a simple [ControlTemplate](../microsoft.ui.xaml.controls/controltemplate.md) for a [Button](../microsoft.ui.xaml.controls/button.md) that contains one [Grid](../microsoft.ui.xaml.controls/grid.md). The [VisualState](visualstate.md) with the [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) value of "PointerOver" has a [Storyboard](../microsoft.ui.xaml.media.animation/storyboard.md) that changes the color of the button content (a `Grid`) from green to red when the user puts the pointer over the `Button`. The [VisualState](visualstate.md) with the [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) value of "Normal" is included so that when the user moves the pointer off the button, the `Grid` background returns to green.

[!code-xaml[11](../microsoft.ui.xaml.data/code/StylingTemplatingOverview/csharp/ButtonStages.xaml#Snippet11)]

## -see-also

[Storyboard](../microsoft.ui.xaml.media.animation/storyboard.md), [Storyboarded animations](/windows/apps/design/motion/storyboarded-animations), [XAML Control templates](/windows/apps/design/style/xaml-control-templates), [XAML control and app styling sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20control%20and%20app%20styling%20sample/C%23)
