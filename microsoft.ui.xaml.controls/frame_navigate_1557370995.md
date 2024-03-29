---
-api-id: M:Microsoft.UI.Xaml.Controls.Frame.Navigate(Windows.UI.Xaml.Interop.TypeName,System.Object,Microsoft.UI.Xaml.Media.Animation.NavigationTransitionInfo)
-api-type: winrt method
---

<!-- Method syntax
public bool Navigate(Windows.UI.Xaml.Interop.TypeName sourcePageType, System.Object parameter, Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo infoOverride)
-->

# Microsoft.UI.Xaml.Controls.Frame.Navigate

## -description

Causes the [Frame](frame.md) to load content represented by the specified [Page](page.md)-derived data type, also passing a parameter to be interpreted by the target of the navigation, and a value indicating the animated transition to use.

## -parameters

### -param sourcePageType

The page to navigate to, specified as a type reference to its partial class type. (A type reference is given as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) for Microsoft .NET, or a [TypeName](/uwp/api/windows.ui.xaml.interop.typename) helper struct for C++).

### -param parameter

The navigation parameter to pass to the target page; must have a basic type (string, char, numeric, or [GUID](/windows/win32/api/guiddef/ns-guiddef-guid)) to support parameter serialization using [GetNavigationState](frame_getnavigationstate_1352043812.md).

### -param infoOverride

Info about the animated transition.

## -returns

`false` if a [NavigationFailed](frame_navigationfailed.md) event handler has set [Handled](../microsoft.ui.xaml.navigation/navigationfailedeventargs_handled.md) to `true`; otherwise, `true`. See Remarks for more info.

## -remarks

You handle the [NavigationFailed](frame_navigationfailed.md) event to respond to navigation failure. You can handle the failure directly in the event handler, or you can set the [NavigationFailedEventArgs.Handled](../microsoft.ui.xaml.navigation/navigationfailedeventargs_handled.md) property to `true` and use the [Navigate](frame_navigate_1557370995.md) method return value to respond to the failure.

### Parameter values

You can use [GetNavigationState](frame_getnavigationstate_1352043812.md) to serialize the frame's state, and [SetNavigationState](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.frame.setnavigationstate) to restore it later. To enable frame state serialization using these methods, you must use only basic types for the navigation `parameter`, such as string, char, numeric, and [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) types. Otherwise, `GetNavigationState` will throw an exception.

The `parameter` value can have a complex type if you do not use [GetNavigationState](frame_getnavigationstate_1352043812.md). However, you should still use only basic types in order to avoid excess memory usage caused by the frame’s navigation stack holding a reference to the `parameter`. A preferred approach is to not pass the actual object, but instead pass an identifier that you can use to look up the object in the target landing page. For example, instead of passing a `Customer` object, pass a reference to the `CustomerID`, then look up the `Customer` after the navigation is complete.

> [!TIP]
> If you are programming using a Microsoft .NET language (C# or Microsoft Visual Basic), the [TypeName](/uwp/api/windows.ui.xaml.interop.typename) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). When programming using C#, it is common to use the `typeof` operator to get references to the [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) of a type. In Microsoft Visual Basic, use `GetType`. If you're using [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/index) you can use the `winrt::xaml_typename<T>()` helper function to create a `TypeName` object. See [winrt::xaml_typename function template](/uwp/cpp-ref-for-winrt/xaml-typename) for more details, and a code example.

## -examples

```xaml
<Frame x:Name="myFrame">
    <Frame.ContentTransitions>
        <TransitionCollection>
            <NavigationThemeTransition />
        </TransitionCollection>
    </Frame.ContentTransitions>
</Frame>
```

```csharp
// Play the default animation
myFrame.Navigate(typeof(Page2), null);

// Explicitly play the page refresh animation
myFrame.Navigate(typeof(Page2), null, new EntranceNavigationTransitionInfo());

// Play the drill in animation
myFrame.Navigate(typeof(Page2), null, new DrillInNavigationTransitionInfo());

// Suppress the default animation
myFrame.Navigate(typeof(Page2), null, new SuppressNavigationTransitionInfo());
```

## -see-also

[Page](page.md), [NavigationFailed](frame_navigationfailed.md), [Navigation design basics](/windows/uwp/layout/navigation-basics)
