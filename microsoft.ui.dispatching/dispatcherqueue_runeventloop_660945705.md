---
-api-id: M:Microsoft.UI.Dispatching.DispatcherQueue.RunEventLoop(Microsoft.UI.Dispatching.DispatcherRunOptions,Microsoft.UI.Dispatching.DispatcherExitDeferral)
-api-type: winrt method
---

# Microsoft.UI.Dispatching.DispatcherQueue.RunEventLoop(Microsoft.UI.Dispatching.DispatcherRunOptions,Microsoft.UI.Dispatching.DispatcherExitDeferral)

<!--
public void RunEventLoop (Microsoft.UI.Dispatching.DispatcherRunOptions options, Microsoft.UI.Dispatching.DispatcherExitDeferral deferral);
-->


## -description

Runs a message loop until either [EnqueueEventLoopExit](./dispatcherqueue_enqueueeventloopexit_600852989.md) or [PostQuitMessage](/windows/win32/api/winuser/nf-winuser-postquitmessage) is called. Also handles raising the [ShutdownStarting](./dispatcherqueue_shutdownstarting.md)/[ShutdownCompleted](./dispatcherqueue_shutdowncompleted.md) and [FrameworkShutdownStarting](./dispatcherqueue_frameworkshutdownstarting.md)/[FrameworkShutdownCompleted](./dispatcherqueue_frameworkshutdowncompleted.md) events.

## -parameters

### -param options

Options for related to the quit message.

### -param deferral

A deferral object, used to defer exit.

## -remarks

## -see-also

## -examples
