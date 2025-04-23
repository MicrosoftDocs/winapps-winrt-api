---
-api-id: P:Microsoft.UI.Xaml.Navigation.PageStackEntry.SourcePageType
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Interop.TypeName SourcePageType { get; }
-->

# Microsoft.UI.Xaml.Navigation.PageStackEntry.SourcePageType

## -description

Gets the type of page associated with this navigation entry.

## -property-value

The page type of the navigation entry, as a type reference ([System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET, a [TypeName](/uwp/api/windows.ui.xaml.interop.typename) helper struct for C++/WinRT).

## -remarks

> [!NOTE]
> If you are programming using a Microsoft .NET language (C#), the [TypeName](/uwp/api/windows.ui.xaml.interop.typename) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). When programming using C#, it is common to use the `typeof` operator to get references to the [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) of a type.
>
> If you're using [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/index) you can use the `winrt::xaml_typename<T>()` helper function to create a `TypeName` object. See [winrt::xaml_typename function template](/uwp/cpp-ref-for-winrt/xaml-typename) for more details, and a code example.

## -examples

## -see-also

[XAML Navigation sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlNavigation), [Frame.Navigate](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.frame.navigate), [Frame.SourcePageType](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.frame.sourcepagetype)
