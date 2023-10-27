---
-api-id: M:Microsoft.UI.Dispatching.DispatcherQueueController.CreateOnCurrentThread
-api-type: winrt method
---

# Microsoft.UI.Dispatching.DispatcherQueueController.CreateOnCurrentThread

<!--
public static Microsoft.UI.Dispatching.DispatcherQueueController CreateOnCurrentThread ();
-->

## -description

Creates a [DispatcherQueue](dispatcherqueue.md) on the calling thread which will interop with a USER32 message loop.

## -returns

The [DispatcherQueue](dispatcherqueue.md) on the calling thread.

## -remarks

You can access the created **DispatcherQueue** through [DispatcherQueueController.DispatcherQueue](dispatcherqueuecontroller_dispatcherqueue.md).

So that the dispatcher queue can dispatch tasks, the current thread must pump messages. Before the current thread exits, it must call [DispatcherQueueController.ShutdownQueueAsync](./dispatcherqueuecontroller_shutdownqueueasync_542547627.md), and continue pumping messages until the **IAsyncAction** completes; or else call [DispatcherQueueController.ShutdownQueue](./dispatcherqueuecontroller_shutdownqueue_1224442331.md), which doesn't return until the queue is shut down.

## -see-also

## -examples
