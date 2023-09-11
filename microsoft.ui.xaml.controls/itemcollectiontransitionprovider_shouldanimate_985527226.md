---
-api-id: M:Microsoft.UI.Xaml.Controls.ItemCollectionTransitionProvider.ShouldAnimate(Microsoft.UI.Xaml.Controls.ItemCollectionTransition)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Controls.ItemCollectionTransitionProvider.ShouldAnimate(Microsoft.UI.Xaml.Controls.ItemCollectionTransition)

<!--
public bool ShouldAnimate (Microsoft.UI.Xaml.Controls.ItemCollectionTransition transition);
-->


## -description

Retrieves a value that indicates whether or not this transition should be animated.

## -parameters

### -param transition

The transition that might be animated.

## -returns

`true` if the transition should be animated; otherwise, `false`.

## -remarks

This method is called on an [ItemCollectionTransitionProvider](itemcollectiontransitionprovider.md) object when the state of a `UIElement`'s data object in a collection has changed in a way that might cause it to be animated. It delegates its implementation to the [ShouldAnimateCore](itemcollectiontransitionprovider_shouldanimatecore_14508869.md) method, which you should override in a derived class.

## -see-also

## -examples


