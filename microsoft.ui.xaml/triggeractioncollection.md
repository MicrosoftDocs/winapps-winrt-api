---
-api-id: T:Microsoft.UI.Xaml.TriggerActionCollection
-api-type: winrt class
---

<!-- Class syntax.
public class TriggerActionCollection : Windows.Foundation.Collections.IIterable<Microsoft.UI.Xaml.TriggerAction>, Windows.Foundation.Collections.IVector<Microsoft.UI.Xaml.TriggerAction>
-->

# Microsoft.UI.Xaml.TriggerActionCollection

## -description

Represents a collection of [BeginStoryboard](../microsoft.ui.xaml.media.animation/beginstoryboard.md) objects.

## -xaml-syntax

```xaml
<EventTrigger>
  oneOrMoreBeginStoryboards
</EventTrigger>
```

## -remarks

<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C#

A `TriggerActionCollection` is enumerable, so you can use language-specific syntax such as `foreach` in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<BeginStoryboard>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator), cast to [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1) with a [BeginStoryboard](../microsoft.ui.xaml.media.animation/beginstoryboard.md) constraint.

<!--End NET note for IEnumerable support-->

## -examples

## -see-also

[IVector&lt;T&gt;](/uwp/api/windows.foundation.collections.ivector-1), [IIterable&lt;T&gt;](/uwp/api/windows.foundation.collections.iiterable-1), [IList<T>](/dotnet/api/system.collections.generic.ilist-1)
