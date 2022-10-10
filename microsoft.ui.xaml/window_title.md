---
-api-id: P:Microsoft.UI.Xaml.Window.Title
-api-type: winrt property
---

# Microsoft.UI.Xaml.Window.Title

<!--
public string Title { get; set; }
-->

## -description

Gets or sets a string used for the window title.

## -property-value

The string used for the window title.

## -remarks

For more information, see [Title bar customization](/windows/apps/develop/title-bar?tabs=winui3#title-1)

By default, the title bar shows the app's display name as the window title. The display name is set in the `Package.appxmanifest` file. To replace the title with custom text, set the `Window.Title` property to a text value, as shown in the Examples.

In addition to the title bar, this string is used in other system UI such as the application switcher (Alt-Tab).

In a Desktop app this is a wrapper for [SetWindowText](/windows/win32/api/winuser/nf-winuser-setwindowtextw).

If [ExtendsContentIntoTitleBar](window_extendscontentintotitlebar.md) is set to `true`, this value is not displayed by the title bar.

## -examples

> [!CAUTION]
> `Title` shows in the XAML IntelliSense for `Window`, but setting it in XAML causes an error. Set this property in code instead.

```csharp
public MainWindow()
{
    InitializeComponent();
    Title = "App title";
}
```

## -see-also

[Title bar customization](/windows/apps/develop/title-bar?tabs=winui3), [SetTitleBar(Microsoft.UI.Xaml.UIElement)](window_settitlebar_1494775390.md)
