---
-api-id: M:Microsoft.UI.Xaml.SetterBaseCollection.ReplaceAll(Microsoft.UI.Xaml.SetterBase[])
-api-type: winrt method
---

<!-- Method syntax
public void ReplaceAll(Microsoft.UI.Xaml.SetterBase[] items)
-->

# Microsoft.UI.Xaml.SetterBaseCollection.ReplaceAll

## -description

Initially clears the collection, then inserts the provided array as new items.

## -parameters

### -param items

The new collection items.

## -remarks

For implementations that track a `changed` event, the initial reset fires an event, but the items added do not fire discrete per-item events.

## -examples

## -see-also
