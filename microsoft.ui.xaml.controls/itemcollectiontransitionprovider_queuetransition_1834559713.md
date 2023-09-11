---
-api-id: M:Microsoft.UI.Xaml.Controls.ItemCollectionTransitionProvider.QueueTransition(Microsoft.UI.Xaml.Controls.ItemCollectionTransition)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.ItemCollectionTransitionProvider.QueueTransition(Microsoft.UI.Xaml.Controls.ItemCollectionTransition)

<!--
public void QueueTransition (Microsoft.UI.Xaml.Controls.ItemCollectionTransition transition);
-->


## -description

Prepares a transition animation to be started by a call to [StartTransitions](itemcollectiontransitionprovider_starttransitions_657762047.md).

## -parameters

### -param transition

The transition to be animated.

## -remarks

This method is called on an [ItemCollectionTransitionProvider](itemcollectiontransitionprovider.md) object when a `UIElement` for a corresponding data object wants an operation to be animated. It adds a [CompositionTarget.Rendering](../microsoft.ui.xaml.media/compositiontarget_rendering.md) event handler if one does not already exist, which will call [StartTransitions](itemcollectiontransitionprovider_starttransitions_657762047.md) to actually set up the transition animations to be run.

## -see-also

## -examples


