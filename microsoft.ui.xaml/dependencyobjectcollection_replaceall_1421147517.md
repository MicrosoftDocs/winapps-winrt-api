---
-api-id: M:Microsoft.UI.Xaml.DependencyObjectCollection.ReplaceAll(Microsoft.UI.Xaml.DependencyObject[])
-api-type: winrt method
---

<!-- Method syntax
public void ReplaceAll(Microsoft.UI.Xaml.DependencyObject[] items)
-->

# Microsoft.UI.Xaml.DependencyObjectCollection.ReplaceAll

## -description

Initially clears the collection, then inserts the provided array as new items.

## -parameters

### -param items

The new collection items.

## -remarks

For implementations that track a _changed_ event, which this collection does do with `VectorChanged`, the initial reset fires an event, but the items added do not fire discrete per-item events.

## -examples

## -see-also
