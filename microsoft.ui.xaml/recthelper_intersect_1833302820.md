---
-api-id: M:Microsoft.UI.Xaml.RectHelper.Intersect(Windows.Foundation.Rect,Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Rect Intersect(Windows.Foundation.Rect target, Windows.Foundation.Rect rect)
-->

# Microsoft.UI.Xaml.RectHelper.Intersect

## -description

Returns the areas of two specified [Rect](/uwp/api/windows.foundation.rect) values that intersect, as a new [Rect](/uwp/api/windows.foundation.rect). C# code should use [Rect.Intersect](/dotnet/api/windows.foundation.rect.intersect) instead.

## -parameters

### -param target

The first [Rect](/uwp/api/windows.foundation.rect) to check for intersection.

### -param rect

The second [Rect](/uwp/api/windows.foundation.rect) to check for intersection.

## -returns

A [Rect](/uwp/api/windows.foundation.rect) that represents the areas of `target` and `rect` that intersect. Can be an [Empty](recthelper_empty.md) value if there is no intersection.

## -remarks

## -examples

## -see-also
