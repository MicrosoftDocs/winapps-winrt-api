---
-api-id: E:Microsoft.UI.Dispatching.DispatcherQueue.ShutdownStarting
-api-type: winrt event
---

# Microsoft.UI.Dispatching.DispatcherQueue.ShutdownStarting

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Dispatching.DispatcherQueue,Microsoft.UI.Dispatching.DispatcherQueueShutdownStartingEventArgs> ShutdownStarting;
-->

## -description

Raised when either [ShutdownQueue](./dispatcherqueuecontroller_shutdownqueue_1224442331.md) or [ShutdownQueueAsync](./dispatcherqueuecontroller_shutdownqueueasync_542547627.md) is called. For a full list of the events raised, and in what order, see the Remarks for [ShutdownQueueAsync](./dispatcherqueuecontroller_shutdownqueueasync_542547627.md).

## -remarks

The **ShutdownStarting** event is raised from the event loop thread *before* the event loop exits. The handler for this event can take a deferral, and can continue to post work until the deferral completes. Once the deferral completes, the **DispatcherQueue** no longer accepts work, and [DispatcherQueue.TryEnqueue](./dispatcherqueue_tryenqueue_530434839.md) returns `false`.

## -see-also

## -examples

```csharp
// Invoked after the DispatcherQueue event loop exits.
_dispatcherQueue.ShutdownCompleted += (s, e) =>
{
    // clean up state
};
```
