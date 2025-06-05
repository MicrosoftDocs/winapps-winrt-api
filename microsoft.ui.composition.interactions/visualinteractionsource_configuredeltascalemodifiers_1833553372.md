---
-api-id: M:Microsoft.UI.Composition.Interactions.VisualInteractionSource.ConfigureDeltaScaleModifiers(Windows.Foundation.Collections.IIterable{Microsoft.UI.Composition.Interactions.CompositionConditionalValue})
-api-type: winrt method
---

<!-- Method syntax.
public void VisualInteractionSource.ConfigureDeltaScaleModifiers(IIterable<CompositionConditionalValue> conditionalValues)
-->

# Microsoft.UI.Composition.Interactions.VisualInteractionSource.ConfigureDeltaScaleModifiers

## -description

Takes an ordered list of [**CompositionConditionalValue**](compositionconditionalvalue.md) objects. In a frame, the first **CompositionConditionalValue** to have its [**Condition**](compositionconditionalvalue_condition.md) property return true replaces the [**DeltaScale**](visualinteractionsource_deltascale.md) value with the value provided by the [**CompositionConditionalValue.Value**](compositionconditionalvalue_value.md) property. If none evaluate to true, the **DeltaScale** is not replaced for that frame.

## -parameters

### -param conditionalValues

## -remarks

## -see-also

## -examples
