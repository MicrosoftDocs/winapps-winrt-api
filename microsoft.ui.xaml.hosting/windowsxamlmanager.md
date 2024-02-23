---
-api-id: T:Microsoft.UI.Xaml.Hosting.WindowsXamlManager
-api-type: winrt class
---

# Microsoft.UI.Xaml.Hosting.WindowsXamlManager

<!--
public sealed class WindowsXamlManager : System.IDisposable
-->

## -description

Represents the WinUI XAML framework in a non-Windows App SDK (WASDK) desktop application (for example, a WPF or Windows Forms application).

## -remarks

**WindowsXamlManager** is part of the *Windows App SDK XAML hosting API*. This API enables non-WASDK desktop applications to host any control that derives from [Microsoft.UI.Xaml.UIElement](../microsoft.ui.xaml/uielement.md) in a UI element that is associated with a window handle (HWND). This API can be used by desktop applications built using WPF, Windows Forms, and the Windows API (Win32).

### Changes from WinAppSDK 1.4 to WinAppSDK 1.5

| WinAppSDK 1.4 | WinAppSDK 1.5 and later |
|---------|---------|
| The XAML runtime shuts down asynchronously on a thread when all the `WindowsXamlManager` and [DesktopWindowXamlSource](desktopwindowxamlsource.md) objects on that thread have been closed or destroyed, or the [DispatcherQueue](../microsoft.ui.dispatching/dispatcherqueue.md) running on that thread is shut down. | The XAML runtime shuts down on a thread only when the [DispatcherQueue](../microsoft.ui.dispatching/dispatcherqueue.md) on the thread shuts down. |
| [WindowsXamlManager.InitializeForCurrentThread](windowsxamlmanager_initializeforcurrentthread_14911797.md) returns a new object each time it is called. | [WindowsXamlManager.InitializeForCurrentThread](windowsxamlmanager_initializeforcurrentthread_14911797.md) returns the same `WindowsXamlManager` instance until the [DispatcherQueue](../microsoft.ui.dispatching/dispatcherqueue.md) on the thread shuts down. |

## -see-also

[Using the WinRT XAML hosting API in a C++ desktop (Win32) app](/windows/apps/desktop/modernize/using-the-xaml-hosting-api)

## -examples
