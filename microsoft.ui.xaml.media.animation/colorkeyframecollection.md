---
-api-id: T:Microsoft.UI.Xaml.Media.Animation.ColorKeyFrameCollection
-api-type: winrt class
---

<!-- Class syntax.
public class ColorKeyFrameCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Media.Animation.ColorKeyFrame>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Media.Animation.ColorKeyFrame>
-->

# Microsoft.UI.Xaml.Media.Animation.ColorKeyFrameCollection

## -description
Represents a collection of [ColorKeyFrame](colorkeyframe.md) objects that can be individually accessed by index. ColorKeyFrameCollection is the value of the [ColorAnimationUsingKeyFrames.KeyFrames](coloranimationusingkeyframes_keyframes.md) property.

## -remarks
<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A ColorKeyFrameCollection is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<ColorKeyFrame>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [ColorKeyFrame](colorkeyframe.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[ColorAnimationUsingKeyFrames.KeyFrames](coloranimationusingkeyframes_keyframes.md), [IList<T>](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true), [IVector&lt;T&gt;](/uwp/api/windows.foundation.collections.ivector-1), [IIterable&lt;T&gt;](/uwp/api/windows.foundation.collections.iiterable-1)
