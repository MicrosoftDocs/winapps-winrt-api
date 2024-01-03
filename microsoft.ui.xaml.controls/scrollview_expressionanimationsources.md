---
-api-id: P:Microsoft.UI.Xaml.Controls.ScrollView.ExpressionAnimationSources
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.ScrollView.ExpressionAnimationSources

<!--
public Microsoft.UI.Composition.CompositionPropertySet ExpressionAnimationSources { get; }
-->

## -description

Gets a `CompositionPropertySet` of scrolling related property values.

## -property-value

A `CompositionPropertySet` of scrolling related property values.

## -remarks

The returned CompositionPropertySet instance can be used to drive Composition animations and includes these properties:

- Extent: Represents the content size (unaffected by the ZoomFactor, i.e. at ZoomFactor 1.0).
- Viewport: Represents the viewport size.
- Offset: Represents the content offset in the XAML layout engine. This offset may not be (0, 0) when element anchoring is turned on.
- Position: Represents an animated Vector2 built using the underlying InteractionTracker's Position.X and Position.Y components.
- MinPosition: Represents a Vector2 built using the underlying InteractionTracker's MinPosition.X and MinPosition.Y components.
- MaxPosition: Represents a Vector2 built using the underlying InteractionTracker's MaxPosition.X and MaxPosition.Y components.
- ZoomFactor: Represents an animated Scalar built using the underlying InteractionTracker's Scale component.

## -see-also

## -examples
