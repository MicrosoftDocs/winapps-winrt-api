---
-api-id: T:Microsoft.UI.Composition.IAnimationObject
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IAnimationObject 
-->

# Microsoft.UI.Composition.IAnimationObject

## -description

Represents an object that has properties that can be referenced by an animation.

## -remarks

Implement `IAnimationObject` to let a custom object participate in [ExpressionAnimation](expressionanimation.md)s. It redirects the property on the custom object to the underlying [CompositionObject](compositionobject.md). For more info, see [CompositionAnimation.SetExpressionReferenceParameter](compositionanimation_setexpressionreferenceparameter_554621612.md).

## -see-also

[CompositionAnimation.SetExpressionReferenceParameter](compositionanimation_setexpressionreferenceparameter_554621612.md)

## -examples
