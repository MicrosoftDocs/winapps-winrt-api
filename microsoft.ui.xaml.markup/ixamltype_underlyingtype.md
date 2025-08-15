---
-api-id: P:Microsoft.UI.Xaml.Markup.IXamlType.UnderlyingType
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Interop.TypeName UnderlyingType { get; }
-->

# Microsoft.UI.Xaml.Markup.IXamlType.UnderlyingType

## -description
Gets information for the backing type.

## -property-value
The backing type, as a type reference.

## -remarks
> [!NOTE]
> If you are programming using a Microsoft .NET language (C#), the [TypeName](/uwp/api/windows.ui.xaml.interop.typename) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). When programming using C#, it is common to use the `typeof` operator to get references to the [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) of a type.
>
> If you're using [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/index) you can use the `winrt::xaml_typename<T>()` helper function to create a `TypeName` object. See [winrt::xaml_typename function template](/uwp/cpp-ref-for-winrt/xaml-typename) for more details, and a code example.

## -examples

## -see-also
[TypeName](/uwp/api/windows.ui.xaml.interop.typename)
