---
-api-id: M:Microsoft.UI.Composition.Interactions.VisualInteractionSource.ConfigureCenterPointXModifiers(Windows.Foundation.Collections.IIterable{Microsoft.UI.Composition.Interactions.CompositionConditionalValue})
-api-type: winrt method
---

<!-- Method syntax.
public void VisualInteractionSource.ConfigureCenterPointXModifiers(IIterable<CompositionConditionalValue> conditionalValues)
-->

# Microsoft.UI.Composition.Interactions.VisualInteractionSource.ConfigureCenterPointXModifiers

## -description

Takes an ordered list of [CompositionConditionalValue](compositionconditionalvalue.md) objects. In a frame, the first `CompositionConditionalValue` to have its [Condition](compositionconditionalvalue_condition.md) property return true replaces the [Composition.Visual.CenterPoint](../microsoft.ui.composition/visual_centerpoint.md) X value with the value provided by the [CompositionConditionalValue.Value](compositionconditionalvalue_value.md) property. If none evaluate to true, the `Composition.Visual.CenterPoint` X value is not replaced for that frame.

## -parameters

### -param conditionalValues

The collection of replacement values.

## -remarks

## -see-also

## -examples
