---
-api-id: M:Microsoft.UI.Dispatching.DispatcherQueue.RunEventLoop
-api-type: winrt method
---

# Microsoft.UI.Dispatching.DispatcherQueue.RunEventLoop

<!--
public void RunEventLoop ();
-->


## -description

Runs a message loop until either [EnqueueEventLoopExit](./dispatcherqueue_enqueueeventloopexit_600852989.md) or [PostQuitMessage](/windows/win32/api/winuser/nf-winuser-postquitmessage) is called. Also handles raising the [ShutdownStarting](./dispatcherqueue_shutdownstarting.md)/[ShutdownCompleted](./dispatcherqueue_shutdowncompleted.md) and [FrameworkShutdownStarting](./dispatcherqueue_frameworkshutdownstarting.md)/[FrameworkShutdownCompleted](./dispatcherqueue_frameworkshutdowncompleted.md) events.

## -remarks

## -see-also

## -examples
