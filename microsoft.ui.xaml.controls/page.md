---
-api-id: T:Microsoft.UI.Xaml.Controls.Page
-api-type: winrt class
---

<!-- Class syntax.
public class Page : Windows.UI.Xaml.Controls.UserControl, Windows.UI.Xaml.Controls.IPage, Windows.UI.Xaml.Controls.IPageOverrides
-->

# Microsoft.UI.Xaml.Controls.Page

## -description

Represents content that a [Frame](frame.md) control can navigate to.

## -xaml-syntax

```xaml
<Page .../>
-or-
<Page ...>
  singleRootElement
</Page>
```

## -remarks

The `Page` class encapsulates content that the [Frame](frame.md) control can navigate to. You will generally create your own page types that derive from the `Page` class, and use `Page` (or a custom type) as the root element for the XAML-declared content. You can create new pages using the **Add | New Item** menu option for your project in Microsoft Visual Studio. This creates a XAML file where the root is a `Page` element with an [x:Class attribute](/windows/uwp/xaml-platform/x-class-attribute) that joins it to the code-behind class that derives from `Page`. This example shows how this looks for a page called `MainPage`.

```xaml
<Page
    x:Class="App1.MainPage"
    ... >
   ...
</Page>
```

```csharp
namespace App1
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
    }
}
```

> [!TIP]
> Visual Studio includes a template for a blank page that you can populate with content. To accelerate app creation, you can use [Template Studio for WinUI](https://github.com/microsoft/TemplateStudio#template-studio). It provides a number of app page templates you can use to add common UI pages into your new app, such as layouts like list/detail or web view, or pages that implement common patterns like app settings.

### Layout

`Page` is a [UserControl](usercontrol.md), therefore you can declare a single XAML object element as [Content](usercontrol_content.md) for the `Page`. Most pages contain more than one UI element in total. You typically use a panel or items control as the immediate child of a `Page`, so that you can have the page contain and compose multiple elements of a UI. For more info, see [Layouts with XAML](/windows/apps/design/layout/layouts-with-xaml) and [Windows app silhouettes](/windows/apps/design/basics/app-silhouette).

### Navigation

Create as many pages as you need to present the content in your app, and then navigate to those pages by calling the [Frame.Navigate](frame_navigate_1557370995.md) method and passing in a type reference for the page to navigate to. By type reference, we mean an instance of a class that identifies a type in the type system, for the language you are using. For Microsoft .NET that type is [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true), and you can get a [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) reference from a page class' name by using the operators `typeof` (C#) or `GetType` (Visual Basic). For C++, use [TypeName](/uwp/api/windows.ui.xaml.interop.typename). For more info, see [TypeName](/uwp/api/windows.ui.xaml.interop.typename) and [winrt::xaml_typename function template](/uwp/cpp-ref-for-winrt/xaml-typename).

Through [Frame.Navigate](frame_navigate_1557370995.md), you can also pass in a parameter object to initialize the page to a particular state. The parameter object is loosely typed but serialization of navigation history only works for basic types (see Remarks in [Frame.Navigate(Type, Object)](frame_navigate_1603787821.md)). Pages that are navigated to as part of an activation generally pass data from the activation. Other navigation scenarios such as search result pages also have expectations of what info will be contained in the parameter.

This example shows what the `Frame.Navigate` call looks like.

```csharp
rootFrame.Navigate(typeof(MainPage), args.Arguments);
```

```cppwinrt
rootFrame.Navigate(xaml_typename<Bookstore::MainPage>(), box_value(e.Arguments()));
```

By default, each navigation creates a new instance of the specific `Page` (or subclass) requested, and disposes the previous `Page` instance. This happens even when navigating back to a previously visited page or when the new page type is the same as the previous page type. Apps that involve frequent navigation to the same pages can cache and reuse the page instances to make navigation more efficient. To do this, set the [Frame.CacheSize](frame_cachesize.md) property to specify how many pages to cache. For each page type that you want to cache, you must also set the [NavigationCacheMode](page_navigationcachemode.md) property to either `Enabled` or `Required`. Pages with a `Required` cache mode are cached regardless of the [CacheSize](frame_cachesize.md) value, and do not count against the [CacheSize](frame_cachesize.md) total.

You can override the page [OnNavigatedTo](page_onnavigatedto_1316593960.md), [OnNavigatingFrom](page_onnavigatingfrom_1820075439.md), and [OnNavigatedFrom](page_onnavigatedfrom_1545714785.md) methods to perform tasks such as initializing and saving the page state. [OnNavigatingFrom](page_onnavigatingfrom_1820075439.md) can be used to cancel a navigation by setting the [Cancel](../microsoft.ui.xaml.navigation/navigatingcanceleventargs_cancel.md) property in the event data from your handler.

For more info, see [Implement navigation between two pages](/windows/apps/design/basics/navigate-between-two-pages).

## -examples

These steps outline how to add a **Page** to a WinUI 3 project, and navigate to it. For a more complete walkthrough, see [Implement navigation between two pages](/windows/apps/design/basics/navigate-between-two-pages).

1. In Visual Studio, create a new C# project from the **Blank App, Packaged (WinUI 3 in Desktop)** project template. Remove any example code that's included in the template from the MainWindow.xaml and MainWindow.xaml.cs files.

1. Add a new item to the project (**WinUI** > **Blank Page (WinUI 3)**) named `MainPage.xaml`.

1. Then, in `App.xaml.cs`, edit the [OnLaunched](../microsoft.ui.xaml/application_onlaunched_1344752508.md) method override so that it looks like the code listing below. The code shows how the content of the app's main window is set to a new [Frame](frame.md), which is then navigated to the **MainPage** that you just added.

```csharp
protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
{
    m_window = new MainWindow();

    // Create a Frame to act as the navigation context.
    Frame rootFrame = new Frame();

    rootFrame.NavigationFailed += OnNavigationFailed;

    // Place the frame in the current Window
    m_window.Content = rootFrame;

    rootFrame.Navigate(typeof(MainPage), args.Arguments);

    m_window.Activate();
}
```

## -see-also

[Frame](frame.md), [UserControl](usercontrol.md), [Navigation design basics](/windows/apps/design/basics/navigation-basics), [Implement navigation between two pages](/windows/apps/design/basics/navigate-between-two-pages)
