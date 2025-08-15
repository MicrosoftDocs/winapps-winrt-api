---
-api-id: T:Microsoft.UI.Xaml.DispatcherShutdownMode
-api-type: winrt enum
---

# Microsoft.UI.Xaml.DispatcherShutdownMode

<!--
public enum DispatcherShutdownMode
-->

## -description

Defines constants that specify how an application will shut down.

## -enum-fields

### -field OnLastWindowClose: 0

When the last XAML [Window](window.md) object on the thread is closed, the [DispatcherQueue.RunEventLoop](../microsoft.ui.dispatching/dispatcherqueue_runeventloop_1569604009.md) call or message pump on the thread will exit. (The XAML runtime calls [PostQuitMessage](/windows/win32/api/winuser/nf-winuser-postquitmessage).)

### -field OnExplicitShutdown: 1

When the last XAML [Window](window.md) object on the thread is closed, the XAML runtime will not take any action to stop the event loop or message pump. (The XAML runtime does not call [PostQuitMessage](/windows/win32/api/winuser/nf-winuser-postquitmessage).)

## -remarks

This enum provides values for the [Application.DispatcherShutdownMode](application_dispatchershutdownmode.md) property.

## -see-also

[Application.DispatcherShutdownMode](application_dispatchershutdownmode.md)

## -examples
