---
-api-id: M:Microsoft.UI.Composition.Interactions.VisualInteractionSource.TryRedirectForManipulation(Microsoft.UI.Input.Experimental.ExpPointerPoint)
-api-type: winrt method
---

# Microsoft.UI.Composition.Interactions.VisualInteractionSource.TryRedirectForManipulation(Microsoft.UI.Input.Experimental.ExpPointerPoint)

<!--
public void TryRedirectForManipulation (Microsoft.UI.Input.Experimental.ExpPointerPoint pointerPoint);
-->

## -description

Attempts to send configured manipulations for the given pointer stream to the [InteractionTracker](interactiontracker.md), not the app's UI thread, starting at the given [ExpPointerPoint](../microsoft.ui.input.experimental/exppointerpoint.md).

> [!IMPORTANT]
> This method should only be called with a  [PointerDeviceType](../microsoft.ui.input/pointerdevicetype.md) of Touch.

## -parameters

### -param pointerPoint

The input point.

## -remarks

## -see-also

[TryRedirectForManipulation(Microsoft.UI.Input.PointerPoint)](visualinteractionsource_tryredirectformanipulation_505381116.md)

## -examples


