---
-api-id: P:Microsoft.UI.Xaml.Application.DispatcherShutdownMode
-api-type: winrt property
---

# Microsoft.UI.Xaml.Application.DispatcherShutdownMode

<!--
public Microsoft.UI.Xaml.DispatcherShutdownMode DispatcherShutdownMode { get; set; }
-->

## -description

Gets or sets a value that specifies whether the DispatcherQueue event loop exits when all XAML windows on a thread are closed.

## -property-value

An enumeration value that specifies whether the DispatcherQueue event loop exits when all XAML windows on a thread are closed. See Remarks for default behavior.

## -remarks

This is a per-thread property. When you set it, the property will only change for the current thread. It is possible to have different values for this property on different threads in your application.

You can set this property at any time. The XAML runtime reads the property each time the last window on any thread is closed.

When the [Application.Start](application_start_1265583819.md) method is called (as it is at startup for WinUI Desktop apps), the XAML runtime sets `DispatcherShutdownMode` to `OnLastWindowClose` for the current thread.  This causes the [DispatcherQueue](../microsoft.ui.dispatching/dispatcherqueue.md)'s event loop to exit when all the XAML windows on the thread are closed.

In a WinUI Desktop app, you might want your code to keep running even after all the XAML windows on the thread have closed. To accomplish this, you can set this property to `OnExplicitShutdown`. Then, after all the XAML windows have closed, the thread will keep running. In this state, you can still schedule work on the [DispatcherQueue](../microsoft.ui.dispatching/dispatcherqueue.md), run work on other threads, and display new XAML windows.

If the application does not call [Application.Start](application_start_1265583819.md) (as is typically the case for [XAML Islands](/windows/apps/desktop/modernize/xaml-islands)-based applications), this property will default to `OnExplicitShutdown`. In this state, the XAML runtime doesn't take any action to exit the event loop when the XAML windows are closed.

When you use `OnExplicitShutdown`, you'll need to exit the event loop yourself when you're ready for the event loop on that thread to exit. To properly exit the event loop, call [DispatcherQueue.EnqueueEventLoopExit](../microsoft.ui.dispatching/dispatcherqueue_enqueueeventloopexit_600852989.md). Alternatively, you can call [Application.Exit](application_exit_1158854104.md), which also causes the XAML runtime to call [PostQuitMessage](/windows/win32/api/winuser/nf-winuser-postquitmessage).

## -see-also

[XAML Islands](/windows/apps/desktop/modernize/xaml-islands), [DispatcherQueue](../microsoft.ui.dispatching/dispatcherqueue.md)

## -examples
