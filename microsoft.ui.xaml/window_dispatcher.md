---
-api-id: P:Microsoft.UI.Xaml.Window.Dispatcher
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Core.CoreDispatcher Dispatcher { get; }
-->

# Microsoft.UI.Xaml.Window.Dispatcher

## -description

[Deprecated] Always returns `null`.

## -property-value

Always `null`.

## -remarks

> [!IMPORTANT]
> `Window.Dispatcher` may be altered or unavailable in future releases. Use [Window.DispatcherQueue](window_dispatcherqueue.md) instead.

> [!NOTE]
> The XAML Window class has several properties that were carried over from the UWP [Windows.UI.Xaml.Window](/uwp/api/windows.ui.xaml.window) class, but are not supported in WinUI apps. These properties always have a `null` value and are not used in WinUI apps. For more info, see [Windowing functionality migration](/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/guides/windowing).

## -examples

## -see-also

[Windowing functionality migration](/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/guides/windowing)
