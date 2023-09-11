---
-api-id: M:Microsoft.UI.Xaml.Controls.ItemCollectionTransitionProvider.StartTransitions(Windows.Foundation.Collections.IVector{Microsoft.UI.Xaml.Controls.ItemCollectionTransition})
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.ItemCollectionTransitionProvider.StartTransitions(Windows.Foundation.Collections.IVector{Microsoft.UI.Xaml.Controls.ItemCollectionTransition})

<!--
protected virtual void StartTransitions (System.Collections.Generic.IList<Microsoft.UI.Xaml.Controls.ItemCollectionTransition> transitions);
-->


## -description

Starts the queued transition animations.

## -parameters

### -param transitions

The collection of transitions for which to start animations.

## -remarks

This method is called by the [CompositionTarget.Rendering](../microsoft.ui.xaml.media/compositiontarget_rendering.md) event handler set up by the [QueueTransition](itemcollectiontransitionprovider_queuetransition_1834559713.md) method. It sets up the animations for all of the transitions on which `QueueTransition` was called. You should override this method in a derived class. The default implementation does nothing if not overridden.

## -see-also

## -examples


