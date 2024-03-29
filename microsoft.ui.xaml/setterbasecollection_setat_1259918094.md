---
-api-id: M:Microsoft.UI.Xaml.SetterBaseCollection.SetAt(System.UInt32,Microsoft.UI.Xaml.SetterBase)
-api-type: winrt method
---

<!-- Method syntax
public void SetAt(System.UInt32 index, Microsoft.UI.Xaml.SetterBase value)
-->

# Microsoft.UI.Xaml.SetterBaseCollection.SetAt

## -description

Sets the value at the specified index to the [SetterBase](setterbase.md) value specified.

## -parameters

### -param index

The index at which to set the value.

### -param value

The value to set.

## -remarks

[InsertAt](setterbasecollection_insertat_977777534.md) expands the collection and moves all subsequent index items by one. In contrast, `SetAt` replaces the item at the index, and the collection count remains the same.

> [!NOTE]
> The equivalent Microsoft .NET API is [Item](/dotnet/api/system.collections.objectmodel.collection-1.item) (the indexer).

## -examples

## -see-also

[Item](/dotnet/api/system.collections.objectmodel.collection-1.item)
