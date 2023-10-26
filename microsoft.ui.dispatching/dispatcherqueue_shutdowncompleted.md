---
-api-id: E:Microsoft.UI.Dispatching.DispatcherQueue.ShutdownCompleted
-api-type: winrt event
---

# Microsoft.UI.Dispatching.DispatcherQueue.ShutdownCompleted

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Dispatching.DispatcherQueue,object> ShutdownCompleted;
-->

## -description

Raised when either [ShutdownQueue](./dispatcherqueuecontroller_shutdownqueue_1224442331.md) or [ShutdownQueueAsync](./dispatcherqueuecontroller_shutdownqueueasync_542547627.md) is called. For a full list of the events raised, and in what order, see the Remarks for [ShutdownQueueAsync](./dispatcherqueuecontroller_shutdownqueueasync_542547627.md).

## -remarks

The **ShutdownCompleted** event is raised from the event loop thread *after* the event loop has exited. You can use the handler for this event to clean up any state maintained by partner components that were maintained on the dedicated thread.

## -see-also

[ShutdownQueueAsync](./dispatcherqueuecontroller_shutdownqueueasync_542547627.md), [DispatcherQueue.TryEnqueue](./dispatcherqueue_tryenqueue_530434839.md)

## -examples

```csharp
_dispatcherQueue.ShutdownStarting += (s, e) =>
{
    // Queue is shutting down, do this last operation to  
    // update state before the dispatcher loop exits
    _queue.TryEnqueue(
        () =>
        {
            // clean up state
        });
};
```
