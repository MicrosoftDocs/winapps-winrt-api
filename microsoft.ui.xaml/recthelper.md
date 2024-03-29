---
-api-id: T:Microsoft.UI.Xaml.RectHelper
-api-type: winrt class
---

<!-- Class syntax.
public class RectHelper : Microsoft.UI.Xaml.IRectHelper
-->

# Microsoft.UI.Xaml.RectHelper

## -description

Provides helper methods to evaluate or set [Rect](/uwp/api/windows.foundation.rect) values. C# code should use members of [Rect](/dotnet/api/windows.foundation.rect) instead.

## -remarks

[Rect](/uwp/api/windows.foundation.rect) is a Windows Runtime structure that represents a rectangle's dimensions with an origin.

`RectHelper` is one of several **Helper** classes that are intended to provide utility methods for Windows Runtime structure values. C# code can use members of [Rect](/dotnet/api/windows.foundation.rect) instead, because utility members are available directly on the structure due to .NET runtime support. C++ code can only access the data values on [Rect](/uwp/api/windows.foundation.rect), for example `Left`. For C++ developers, approximately the same utility features that a C# developer could use directly on [Rect](/uwp/api/windows.foundation.rect) are available in a static form on the `RectHelper` class.

## -examples

## -see-also

[Rect](/uwp/api/windows.foundation.rect)
