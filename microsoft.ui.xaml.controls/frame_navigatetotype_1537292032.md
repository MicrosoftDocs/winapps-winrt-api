---
-api-id: M:Microsoft.UI.Xaml.Controls.Frame.NavigateToType(Windows.UI.Xaml.Interop.TypeName,System.Object,Microsoft.UI.Xaml.Navigation.FrameNavigationOptions)
-api-type: winrt method
---

<!-- Method syntax.
public bool Frame.NavigateToType(TypeName sourcePageType, Object parameter, FrameNavigationOptions navigationOptions)
-->

# Microsoft.UI.Xaml.Controls.Frame.NavigateToType

## -description

Causes the [Frame](frame.md) to load content represented by the specified [Page](page.md), also passing a parameter to be interpreted by the target of the navigation.

## -parameters

### -param sourcePageType

The page to navigate to, specified as a type reference to its partial class type. (A type reference is given as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET, or a [TypeName](/uwp/api/windows.ui.xaml.interop.typename) helper struct for C++).

### -param parameter

The navigation parameter to pass to the target page.

### -param navigationOptions

Options for the navigation, including whether it is recorded in the navigation stack and what transition animation is used.

## -returns

`false` if a [NavigationFailed](frame_navigationfailed.md) event handler has set [Handled](../microsoft.ui.xaml.navigation/navigationfailedeventargs_handled.md) to `true`; otherwise, `true`.

## -remarks

You handle the [NavigationFailed](frame_navigationfailed.md) event to respond to navigation failure. You can handle the failure directly in the event handler, or you can set the [NavigationFailedEventArgs.Handled](../microsoft.ui.xaml.navigation/navigationfailedeventargs_handled.md) property to `true` and use the [Navigate](frame_navigate_1557370995.md) method return value to respond to the failure.

> [!TIP]
> If you are programming using a Microsoft .NET language (C# or Microsoft Visual Basic), the [TypeName](/uwp/api/windows.ui.xaml.interop.typename) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). When programming using C#, it is common to use the `typeof` operator to get references to the [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) of a type. In Microsoft Visual Basic, use `GetType`. If you're using [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/index) you can use the `winrt::xaml_typename<T>()` helper function to create a `TypeName` object. See [winrt::xaml_typename function template](/uwp/cpp-ref-for-winrt/xaml-typename) for more details, and a code example.

## -see-also

## -examples
