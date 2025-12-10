---
-api-id: M:Microsoft.UI.Composition.Interactions.VisualInteractionSource.ConfigureDeltaPositionXModifiers(Windows.Foundation.Collections.IIterable{Microsoft.UI.Composition.Interactions.CompositionConditionalValue})
-api-type: winrt method
---

<!-- Method syntax.
public void VisualInteractionSource.ConfigureDeltaPositionXModifiers(IIterable<CompositionConditionalValue> conditionalValues)
-->

# Microsoft.UI.Composition.Interactions.VisualInteractionSource.ConfigureDeltaPositionXModifiers

## -description

Takes an ordered list of [CompositionConditionalValue](compositionconditionalvalue.md) objects. In a frame, the first `CompositionConditionalValue` to have its [Condition](compositionconditionalvalue_condition.md) property return true replaces the [DeltaPosition](visualinteractionsource_deltaposition.md)  value with the value provided by the [CompositionConditionalValue.Value](compositionconditionalvalue_value.md) property. If none evaluate to true, the `DeltaPosition` value is not replaced for that frame.

## -parameters

### -param conditionalValues

The collection of replacement values.

## -remarks

## -see-also

## -examples
