---
-api-id: M:Microsoft.UI.Xaml.RectHelper.GetIsEmpty(Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public bool GetIsEmpty(Windows.Foundation.Rect target)
-->

# Microsoft.UI.Xaml.RectHelper.GetIsEmpty

## -description

 Returns whether a specified [Rect](/uwp/api/windows.foundation.rect) is equivalent to an [Empty](recthelper_empty.md) [Rect](/uwp/api/windows.foundation.rect). C# code should use [Rect.IsEmpty](/dotnet/api/windows.foundation.rect.isempty) instead.

## -parameters

### -param target

The [Rect](/uwp/api/windows.foundation.rect) to evaluate.

## -returns

 `true` if the specified [Rect](/uwp/api/windows.foundation.rect) is equivalent to an [Empty](recthelper_empty.md) [Rect](/uwp/api/windows.foundation.rect); otherwise, `false`.

## -remarks

Do not use this method to test for zero area; a rectangle with zero area is not necessarily the [Empty](recthelper_empty.md) rectangle. For more information, see the [Empty](recthelper_empty.md) property.

## -examples

## -see-also
