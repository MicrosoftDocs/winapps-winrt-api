---
-api-id: M:Microsoft.UI.Xaml.SizeHelper.GetIsEmpty(Windows.Foundation.Size)
-api-type: winrt method
---

<!-- Method syntax
public bool GetIsEmpty(Windows.Foundation.Size target)
-->

# Microsoft.UI.Xaml.SizeHelper.GetIsEmpty

## -description

 Returns whether a specified [Size](/uwp/api/windows.foundation.size) is equivalent to an [Empty](sizehelper_empty.md) `Size`. C# code should use [Size.IsEmpty](/dotnet/api/windows.foundation.size.isempty) instead.

## -parameters

### -param target

The [Size](/uwp/api/windows.foundation.size) to evaluate.

## -returns

 `true` if the specified [Size](/uwp/api/windows.foundation.size) is equivalent to an [Empty](sizehelper_empty.md) `Size`; otherwise, `false`.

## -remarks

Do not use this method to test for zero area; a size with zero area is not necessarily the [Empty](sizehelper_empty.md) size. For more information, see the [Empty](sizehelper_empty.md) property.

## -examples

## -see-also

[Size.IsEmpty](/dotnet/api/windows.foundation.size.isempty)
