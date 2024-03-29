---
-api-id: E:Microsoft.UI.Xaml.DependencyObjectCollection.VectorChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.Collections.VectorChangedEventHandler VectorChanged<Microsoft.UI.Xaml.DependencyObject>
-->

# Microsoft.UI.Xaml.DependencyObjectCollection.VectorChanged

## -description

Occurs when the contents of the collection changes.

## -remarks

This event is named `VectorChanged` for all languages, but for C# and Microsoft Visual Basic the implemented collection type is [IList<T>](/dotnet/api/system.collections.generic.ilist-1).

The type of change that was applied to the collection is communicated as a [CollectionChange](/uwp/api/windows.foundation.collections.collectionchange) value in the event data, with a collection index for where in the collection the change occurred. Because it reports per-index, multiple `VectorChanged` events can originate from the same collection at the same time.

## -examples

## -see-also

[IVectorChangedEventArgs](/uwp/api/windows.foundation.collections.ivectorchangedeventargs)
