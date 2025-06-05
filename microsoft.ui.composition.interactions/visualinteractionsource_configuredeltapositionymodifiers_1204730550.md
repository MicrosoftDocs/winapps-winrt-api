---
-api-id: M:Microsoft.UI.Composition.Interactions.VisualInteractionSource.ConfigureDeltaPositionYModifiers(Windows.Foundation.Collections.IIterable{Microsoft.UI.Composition.Interactions.CompositionConditionalValue})
-api-type: winrt method
---

<!-- Method syntax.
public void VisualInteractionSource.ConfigureDeltaPositionYModifiers(IIterable<CompositionConditionalValue> conditionalValues)
-->

# Microsoft.UI.Composition.Interactions.VisualInteractionSource.ConfigureDeltaPositionYModifiers

## -description

Takes an ordered list of [**CompositionConditionalValue**](compositionconditionalvalue.md) objects. In a frame, the first **CompositionConditionalValue** to have its [**Condition**](compositionconditionalvalue_condition.md) property return true replaces the [**DeltaPosition**](visualinteractionsource_deltaposition.md) Y value with the value provided by the [**CompositionConditionalValue.Value**](compositionconditionalvalue_value.md) property. If none evaluate to true, the **DeltaPosition** Y value is not replaced for that frame.

## -parameters

### -param conditionalValues

The collection of replacement values.

## -remarks

## -see-also

## -examples
