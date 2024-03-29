---
-api-id: T:Microsoft.UI.Xaml.TriggerCollection
-api-type: winrt class
---

<!-- Class syntax.
public class TriggerCollection : Windows.Foundation.Collections.IIterable<Microsoft.UI.Xaml.TriggerBase>, Windows.Foundation.Collections.IVector<Microsoft.UI.Xaml.TriggerBase>
-->

# Microsoft.UI.Xaml.TriggerCollection

## -description

Represents a collection of [EventTrigger](eventtrigger.md) objects.

## -xaml-syntax

```xaml
<object>
  <object.Triggers>
    oneOrMoreEventTriggers
  </object.Triggers>
</object>
```

## -remarks

<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C#

A `TriggerCollection` is enumerable, so you can use language-specific syntax such as `foreach` in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<EventTrigger>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator), cast to [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1) with an [EventTrigger](eventtrigger.md) constraint.

<!--End NET note for IEnumerable support-->

## -examples

## -see-also

[IVector&lt;T&gt;](/uwp/api/windows.foundation.collections.ivector-1), [IIterable&lt;T&gt;](/uwp/api/windows.foundation.collections.iiterable-1), [IList<T>](/dotnet/api/system.collections.generic.ilist-1)
