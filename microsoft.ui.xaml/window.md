---
-api-id: T:Microsoft.UI.Xaml.Window
-api-type: winrt class
---

<!-- Class syntax.
public class Window : Microsoft.UI.Xaml.IWindow, Microsoft.UI.Xaml.IWindow2
-->

# Microsoft.UI.Xaml.Window

## -description

Represents the window of the current [Application](application.md).

## -remarks

You can create more than one `Window` per thread in your apps. See [Create a new Window](#create-a-new-window) in [Examples](#-examples).

`Window` implements [IWindowNative](/windows/apps/winui/reference/iwindownative) to enable interop through the Window's HWND ([WindowHandle](/windows/apps/winui/reference/iwindownative-windowhandle)).

Typically, `Window` is used to set a [UIElement](uielement.md) to the [Content](window_content.md) that represents the app UI. This is usually done as part of app activation (for example in the [OnLaunched](application_onlaunched_1344752508.md) override) and allows you to change the window content throughout the lifetime of the window.

Ensure you call [Activate](window_activate_1797342875.md) on any `Window` used on initial activation. If you use the default app templates from Microsoft Visual Studio, [Window.Activate](window_activate_1797342875.md) is included in the app.xaml code-behind file.

## -see-also

[IWindowNative](/windows/apps/winui/reference/iwindownative), [Handle app activation](/windows/uwp/launch-resume/activate-an-app), [CoreWindow](/uwp/api/windows.ui.core.corewindow), [CoreApplicationView](/uwp/api/Windows.ApplicationModel.Core.CoreApplicationView), [ApplicationView](/uwp/api/Windows.UI.ViewManagement.ApplicationView)

## -examples

### OnLaunched

The following code example shows the [OnLaunched](application_onlaunched_1344752508.md) method override generated for the **WinUI in Desktop** template in Microsoft Visual Studio. This code demonstrates typical usage of the [Activate](window_activate_1797342875.md) method on `Window`.

``` csharp
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            m_window = new MainWindow();
            m_window.Activate();
        }

        private Window m_window;
```

### Create a new Window

In your apps you can create each Window explicitly. Creating more than one Window requires the 1.0.1 update to WindowsAppSDK, and is limited to a single thread.

```csharp
var window = new Window();
window.Content = new TextBlock() { Text = "Hello" };
window.Activate();
```

You can also define a new Window in markup:

```xaml
<Window 
    x:Class="MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
    <TextBlock>Hello</TextBlock>
</Window>
```

with corresponding code-behind:

```c#
public partial class MainWindow : Window
{
  public MainWindow()
  {
    InitializeComponent();
  }
}

...
var window = new MainWindow();
window.Activate();
```
