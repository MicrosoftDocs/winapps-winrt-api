---
-api-id: M:Microsoft.UI.Xaml.Controls.AnimatedVisuals.AnimatedFindVisualSource.TryCreateAnimatedVisual(Microsoft.UI.Composition.Compositor,System.Object@)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.AnimatedVisuals.AnimatedFindVisualSource.TryCreateAnimatedVisual(Microsoft.UI.Composition.Compositor,System.Object@)

<!--
public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual (Microsoft.UI.Composition.Compositor compositor, out object diagnostics);
-->


## -description

Attempts to create an instance of an `AnimatedFindVisualSource` object for an [AnimatedIcon](../microsoft.ui.xaml.controls/AnimatedIcon.md).

## -parameters

### -param compositor

The [Compositor](../microsoft.ui.composition/compositor.md) used to create objects for the animated visual.

### -param diagnostics

Diagnostics information about the [IAnimatedVisualSource](../microsoft.ui.xaml.controls/ianimatedvisualsource.md) result. The type and contents of the object depend on the [IAnimatedVisualSource](../microsoft.ui.xaml.controls/ianimatedvisualsource.md) implementation.

This parameter is optional.

## -returns

An [IAnimatedVisual](../microsoft.ui.xaml.controls/ianimatedvisual.md), or `null`.

## -remarks

## -see-also

[IAnimatedVisualSource](../microsoft.ui.xaml.controls/ianimatedvisualsource.md), [Animated icons guidance](/windows/apps/design/controls/animated-icon)

## -examples


