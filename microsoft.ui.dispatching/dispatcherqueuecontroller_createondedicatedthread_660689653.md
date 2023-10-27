---
-api-id: M:Microsoft.UI.Dispatching.DispatcherQueueController.CreateOnDedicatedThread
-api-type: winrt method
---

# Microsoft.UI.Dispatching.DispatcherQueueController.CreateOnDedicatedThread

<!--
public static Microsoft.UI.Dispatching.DispatcherQueueController CreateOnDedicatedThread ();
-->

## -description

Creates a [DispatcherQueue](dispatcherqueue.md) that you can use to run tasks on a dedicated thread.

## -returns

The [DispatcherQueue](dispatcherqueue.md) that you can use to run tasks on a dedicated thread.

## -remarks

You can access the created **DispatcherQueue** via [DispatcherQueueController.DispatcherQueue](./dispatcherqueuecontroller_dispatcherqueue.md).

The created **DispatcherQueue** continues running on its dedicated thread until explicitly shut down. To avoid thread and memory leaks, when you're finished with the **DispatcherQueue** call [DispatcherQueueController.ShutdownQueue](./dispatcherqueuecontroller_shutdownqueue_1224442331.md) or [DispatcherQueueController.ShutdownQueueAsync](./dispatcherqueuecontroller_shutdownqueueasync_542547627.md).

## -see-also

## -examples
