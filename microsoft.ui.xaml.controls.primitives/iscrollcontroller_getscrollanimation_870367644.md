---
-api-id: M:Microsoft.UI.Xaml.Controls.Primitives.IScrollController.GetScrollAnimation(System.Int32,Windows.Foundation.Numerics.Vector2,Windows.Foundation.Numerics.Vector2,Microsoft.UI.Composition.CompositionAnimation)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.Primitives.IScrollController.GetScrollAnimation(System.Int32,Windows.Foundation.Numerics.Vector2,Windows.Foundation.Numerics.Vector2,Microsoft.UI.Composition.CompositionAnimation)

<!--
public Microsoft.UI.Composition.CompositionAnimation GetScrollAnimation (int correlationId, System.Numerics.Vector2 startPosition, System.Numerics.Vector2 endPosition, Microsoft.UI.Composition.CompositionAnimation defaultAnimation);
-->


## -description

Provides the `IScrollController` with the option of customizing the animation used to perform its scroll request.

## -parameters

### -param correlationId

A correlation ID number used to associate a method call with corresponding events.

### -param startPosition

The start position of the content.

### -param endPosition

The end position of the content.

### -param defaultAnimation

The animation that is applied to the scroll request.

## -returns

The animation to use, if any, or `null`.

## -remarks

This animation returned by this method can be:

- the `defaultAnimation`, either unchanged or modified
- a brand-new custom animation
- `null`.

## -see-also

## -examples


