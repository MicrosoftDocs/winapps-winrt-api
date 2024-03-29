---
-api-id: T:Microsoft.UI.Xaml.DependencyObjectCollection
-api-type: winrt class
---

<!-- Class syntax.
public class DependencyObjectCollection : Microsoft.UI.Xaml.DependencyObject, Windows.Foundation.Collections.IIterable<Microsoft.UI.Xaml.DependencyObject>, Windows.Foundation.Collections.IObservableVector<Microsoft.UI.Xaml.DependencyObject>, Windows.Foundation.Collections.IVector<Microsoft.UI.Xaml.DependencyObject>
-->

# Microsoft.UI.Xaml.DependencyObjectCollection

## -description

Implements a practical collection class that can contain [DependencyObject](dependencyobject.md) items.

## -remarks

The purpose of the `DependencyObjectCollection` class is mainly to support the tooling and portability of behaviors. Behaviors are a technique for defining certain basic interactions of a UI element entirely in XAML, without requiring an event handler and code-behind.

If you're interested in implementing a business object class that supports collection-changed notifications you should use `ObservableCollection` or one of the interface patterns that supports changed events. For more info see [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth).

<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A `DependencyObjectCollection` is enumerable, so you can use language-specific syntax such as `foreach` in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<DependencyObject>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator), cast to [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1) with a [DependencyObject](dependencyobject.md) constraint.

<!--End NET note for IEnumerable support-->

## -examples

## -see-also

[DependencyObject](dependencyobject.md), [IObservableVector(DependencyObject)](/uwp/api/windows.foundation.collections.iobservablevector-1), [IVector(DependencyObject)](/uwp/api/windows.foundation.collections.ivector-1), [IIterable(DependencyObject)](/uwp/api/windows.foundation.collections.iiterable-1), [IList<T>](/dotnet/api/system.collections.generic.ilist-1)
