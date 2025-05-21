---
-api-id: M:Microsoft.UI.Xaml.Controls.INavigate.Navigate(Windows.UI.Xaml.Interop.TypeName)
-api-type: winrt method
---

<!-- Method syntax
public bool Navigate(Windows.UI.Xaml.Interop.TypeName sourcePageType)
-->

# Microsoft.UI.Xaml.Controls.INavigate.Navigate

## -description
Causes the navigation host to load content that is specified by a type reference.

## -parameters
### -param sourcePageType
A type reference for the content to load.

## -returns
**true** if the navigation host can navigate according to its settings; otherwise, **false**. 
<!--TBW clarify the asynch, that  you probably do not get false just because you specified a source that does not exist, you need async events to tell that.-->

## -remarks
The [INavigate](inavigate.md) interface is mainly infrastructure. It's not expected that typical UWP app will implement this interface.

> [!IMPORTANT]
> If you are programming using a Microsoft .NET language (C#), the [TypeName](/uwp/api/windows.ui.xaml.interop.typename) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). When programming using C#, it is common to use the `typeof` operator to get references to the [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) of a type.
>
> If you're using [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/index) you can use the `winrt::xaml_typename<T>()` helper function to create a `TypeName` object. See [winrt::xaml_typename function template](/uwp/cpp-ref-for-winrt/xaml-typename) for more details, and a code example.

## -examples

## -see-also
[Frame.Navigate](frame_navigate_1557370995.md), [HyperlinkButton](hyperlinkbutton.md), [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true)
