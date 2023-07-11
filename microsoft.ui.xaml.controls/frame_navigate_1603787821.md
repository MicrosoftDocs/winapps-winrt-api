---
-api-id: M:Microsoft.UI.Xaml.Controls.Frame.Navigate(Windows.UI.Xaml.Interop.TypeName,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public bool Navigate(Windows.UI.Xaml.Interop.TypeName sourcePageType, System.Object parameter)
-->

# Microsoft.UI.Xaml.Controls.Frame.Navigate

## -description

Causes the [Frame](frame.md) to load content represented by the specified [Page](page.md), also passing a parameter to be interpreted by the target of the navigation.

## -parameters

### -param sourcePageType

The page to navigate to, specified as a type reference to its partial class type. (A type reference is given as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET, or a [TypeName](/uwp/api/windows.ui.xaml.interop.typename) helper struct for C++).

### -param parameter

The navigation parameter to pass to the target page.

## -returns

`false` if a [NavigationFailed](frame_navigationfailed.md) event handler has set [Handled](../microsoft.ui.xaml.navigation/navigationfailedeventargs_handled.md) to `true`; otherwise, `true`. See Remarks for more info.

## -remarks

## -examples

## -see-also
