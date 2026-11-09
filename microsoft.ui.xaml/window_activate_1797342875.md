---
-api-id: M:Microsoft.UI.Xaml.Window.Activate
-api-type: winrt method
---

<!-- Method syntax
public void Activate()
-->

# Microsoft.UI.Xaml.Window.Activate

## -description

Attempts to activate the application window.

## -remarks

If your app is in the foreground, `Activate` brings the window to the front and gives it input focus. If your app is in the background, `Activate` does not force the window into the foreground. For details about Windows restrictions on setting the foreground window, see [SetForegroundWindow](/windows/win32/api/winuser/nf-winuser-setforegroundwindow).

If you use the default app templates from Microsoft Visual Studio, `Window.Activate` is part of the initial code in the `app.xaml` code-behind file. Specifically, `Activate` is called from the default [OnLaunched](application_onlaunched_1344752508.md) override.

## -examples

## -see-also

[Application](application.md), [OnLaunched](application_onlaunched_1344752508.md), [Activated](window_activated.md), [Windowing overview for WinUI and Windows App SDK](/windows/apps/develop/ui-input/windowing-overview),  [Show multiple windows for your app](/windows/apps/develop/ui-input/multiple-windows)
