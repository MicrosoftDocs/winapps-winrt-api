---
-api-id: M:Microsoft.UI.Composition.CompositionObject.StartAnimation(System.String,Microsoft.UI.Composition.CompositionAnimation,Microsoft.UI.Composition.AnimationController)
-api-type: winrt method
---

# Microsoft.UI.Composition.CompositionObject.StartAnimation(System.String,Microsoft.UI.Composition.CompositionAnimation,Microsoft.UI.Composition.AnimationController)

<!--
public void StartAnimation (string propertyName, Microsoft.UI.Composition.CompositionAnimation animation, Microsoft.UI.Composition.AnimationController animationController);
-->

## -description

Connects an animation with the specified property of the object and starts the animation.

## -parameters

### -param propertyName

The property to associate the animation with.

### -param animation

The animation to associate with the specified property.

### -param animationController

The animation controller to associate with the animation.

## -remarks

The `animationController` parameter lets you bind multiple animations to a single controller's [Progress](animationcontroller_progress.md) property, which requires fewer ExpressionAnimation objects than binding multiple animator's `Progress` properties to a CompositionObject property.

## -see-also

## -examples


