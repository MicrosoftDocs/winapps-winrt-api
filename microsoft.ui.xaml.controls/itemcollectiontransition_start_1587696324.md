---
-api-id: M:Microsoft.UI.Xaml.Controls.ItemCollectionTransition.Start
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.ItemCollectionTransition.Start

<!--
public Microsoft.UI.Xaml.Controls.ItemCollectionTransitionProgress Start ();
-->


## -description

Notifies the `ItemCollectionTransitionProvider` that this transition will be animated.

## -returns

An [ItemCollectionTransitionProgress](itemcollectiontransitionprogress.md) object that can be used to notify when the transition animation is complete.

## -remarks

This method should be called by a class that derives from [ItemCollectionTransitionProvider](itemcollectiontransitionprovider.md) in its [StartTransitions](itemcollectiontransitionprovider_starttransitions_657762047.md) method. It notifies the `ItemCollectionTransitionProvider` that this transition will be animated. If this method is not called on a `ItemCollectionTransition` by the time `ItemCollectionTransitionProvider.StartTransitions` returns, the `ItemCollectionTransitionProvider` will automatically raise the `TransitionCompleted` event to denote the fact that there are no animations related to this transition for which to wait.

## -see-also

[ItemCollectionTransitionProgress.Complete](itemcollectiontransitionprogress_complete_1807836922.md)

## -examples


