---
-api-id: M:Microsoft.UI.Xaml.Navigation.PageStackEntry.#ctor(Windows.UI.Xaml.Interop.TypeName,System.Object,Microsoft.UI.Xaml.Media.Animation.NavigationTransitionInfo)
-api-type: winrt constructor
---

<!-- Method syntax
public PageStackEntry(Windows.UI.Xaml.Interop.TypeName sourcePageType, System.Object parameter, Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo navigationTransitionInfo)
-->

# Microsoft.UI.Xaml.Navigation.PageStackEntry.PageStackEntry

## -description
Initializes a new instance of the [PageStackEntry](pagestackentry.md) class.

## -parameters
### -param sourcePageType
The type of page associated with the navigation entry, as a type reference.

### -param parameter
The navigation parameter associated with the navigation entry.

### -param navigationTransitionInfo
Info about the animated transition associated with the navigation entry.

## -remarks
> [!NOTE]
> If you are programming using a Microsoft .NET language (C#), the [TypeName](/uwp/api/windows.ui.xaml.interop.typename) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). When programming using C#, it is common to use the `typeof` operator to get references to the [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) of a type.
>
> If you're using [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/index) you can use the `winrt::xaml_typename<T>()` helper function to create a `TypeName` object. See [winrt::xaml_typename function template](/uwp/cpp-ref-for-winrt/xaml-typename) for more details, and a code example.

## -examples

## -see-also
[BackStack](../microsoft.ui.xaml.controls/frame_backstack.md), [ForwardStack](../microsoft.ui.xaml.controls/frame_forwardstack.md), [XAML Navigation sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/XamlNavigation)
