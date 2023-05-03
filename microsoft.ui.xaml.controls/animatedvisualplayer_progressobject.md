---
-api-id: P:Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.ProgressObject
-api-type: winrt property
---

<!-- Property syntax.
public CompositionObject ProgressObject { get; }
-->

# Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer.ProgressObject

## -description

Gets a CompositionObject that is animated along with the progress of the AnimatedVisualPlayer.

## -property-value

A CompositionObject that is animated along with the progress of the AnimatedVisualPlayer.

## -remarks

Supports advanced scenarios where another [CompositionObject](../microsoft.ui.composition/compositionobject.md) is animated at the same rate as the AnimatedVisualPlayer. To bind a property to the progress of this player, use an [ExpressionAnimation](../microsoft.ui.composition/expressionanimation.md) that references a scalar property named "Progress" on this object.

## -see-also

## -examples

