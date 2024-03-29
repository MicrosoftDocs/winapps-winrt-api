---
-api-id: T:Microsoft.UI.Xaml.GridLengthHelper
-api-type: winrt class
---

<!-- Class syntax.
public class GridLengthHelper : Microsoft.UI.Xaml.IGridLengthHelper
-->

# Microsoft.UI.Xaml.GridLengthHelper

## -description

Provides helper methods to evaluate or set [GridLength](gridlength.md) values. C# code should use methods of [GridLength](/dotnet/api/windows.ui.xaml.gridlength) instead.

## -remarks

[GridLength](gridlength.md) is a Windows Runtime structure that represents a factor for available-space measurements in rows or columns of a [Grid](../microsoft.ui.xaml.controls/grid.md).

`GridLengthHelper` is one of several **Helper** classes that are intended to provide utility methods for Windows Runtime structure values. C# code can use members of [GridLength](/dotnet/api/windows.ui.xaml.gridlength) instead, because utility members are available directly on the structure due to .NET runtime support. C++ code can only access the **Value** data value on `GridLength`. For C++ developers, approximately the same utility features that a C# developer could use directly on `GridLength` are available in a static form on the `GridLengthHelper` class.

## -examples

## -see-also

[Grid](../microsoft.ui.xaml.controls/grid.md), GridLength, [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
