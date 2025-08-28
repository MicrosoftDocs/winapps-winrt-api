---
-api-id: P:Microsoft.UI.Xaml.Window.Current
-api-type: winrt property
---

<!-- Property syntax
public Microsoft.UI.Xaml.Window Current { get; }
-->

# Microsoft.UI.Xaml.Window.Current

## -description

Always returns `null`.

## -property-value

Always `null`.

## -remarks

As an alternative to `Window.Current`, you can track instances of Window in your app code. For more info, see the following articles.

- If your app has a single window: [Windowing overview for WinUI and Windows App SDK](/windows/apps/develop/ui-input/windowing-overview#track-the-current-window).
- If your app has multiple windows: [Show multiple windows for your app](/windows/apps/develop/ui-input/multiple-windows#track-instances-of-window).

> [!NOTE]
> The XAML Window class has several properties that were carried over from the UWP [Windows.UI.Xaml.Window](/uwp/api/windows.ui.xaml.window) class, but are not supported in WinUI apps. These properties always have a `null` value and are not used in WinUI apps. For more info, see [Windowing functionality migration](/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/guides/windowing).

## -examples

## -see-also

[Windowing functionality migration](/windows/apps/windows-app-sdk/migrate-to-windows-app-sdk/guides/windowing)
