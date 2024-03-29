---
-api-id: T:Microsoft.UI.Xaml.PointHelper
-api-type: winrt class
---

<!-- Class syntax.
public class PointHelper : Microsoft.UI.Xaml.IPointHelper
-->

# Microsoft.UI.Xaml.PointHelper

## -description

Provides helper methods to set [Point](/uwp/api/windows.foundation.point) values. C# code should use methods of [Point](/dotnet/api/windows.foundation.point) instead.

## -remarks

[Point](/uwp/api/windows.foundation.point) is a Windows Runtime structure that represents an **X**,**Y** position in a coordinate system. A `Point` is used as a value in many different Windows Runtime APIs.

`PointHelper` is one of several **Helper** classes that are intended to provide utility methods for Windows Runtime structure values. C# code can use members of [Point](/dotnet/api/windows.foundation.point) instead, because utility members are available directly on the structure due to .NET runtime support. C++ code can only access the **X** and **Y** data values on [Point](/uwp/api/windows.foundation.point). For C++ developers, approximately the same utility features that a C# developer could use directly on [Point](/uwp/api/windows.foundation.point) are available in a static form on the `PointHelper` class.

## -examples

## -see-also

[Point](/uwp/api/windows.foundation.point), [Handle pointer input](/windows/apps/design/input/handle-pointer-input)
