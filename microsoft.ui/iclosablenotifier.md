---
-api-id: T:Microsoft.UI.IClosableNotifier
-api-type: winrt interface
---

# Microsoft.UI.IClosableNotifier

<!--
public interface IClosableNotifier
-->


## -description

When implemented in a WinRT runtime class, provides notification that an object has been closed (disposed).

## -remarks

The purpose of this interface is to provide a reliable notification when the underlying object is closed (disposed) and also a way to check if the object is closed.

Typically, an object would need to know when another WinRT object is closed if it depends on that WinRT object to satisfy its functionality. If the WinRT object it depends on is closed, you can perform cleanup operations and/or unregister from events.

### Object state when events are raised

When the the `Closed` or `FrameworkClosed` event is processed, the underlying WinRT object is already closed. If you attempt to access the object's properties (except `IsClosed`) or methods, `RO_E_CLOSED` is returned after this point. The only operations that are allowed are unsubscribing from events and checking the `IsClosed` property on the object.

### Order of events

The `Closed` and `FrameworkClosed` events are raised in pairs. First the `FrameworkClosed` event is raised to give frameworks a chance to clean up their state, then the `Closed` event is raised to also give application code a chance to clean up.

Frameworks respond to the first event so that they can prepare for an application to call into the framework after the object is closed. For example, a framework may `null`-out internal state so that applications that try to use that state will receive an appropriate error rather than trying to operate on an invalid state.

### Possible ways a WinRT object can be closed

- If the WinRT object is bound to a certain thread, it is typically closed when the thread exits.
- If the WinRT object implements `IClosable.Close`, external code can explicitly request that it be closed.
- If the last strong reference to the object has been released, the object can be closed.

### No sender or args for the event

If the `Closed` and `FrameworkClosed` events are raised on a WinRT object that has been disposed and doesn't have any more strong references holding it in memory, then the *sender* and event args parameters of a [TypedEventHandler](/uwp/api/windows.foundation.typedeventhandler-2) would be `null`. In order to support this case, these events do not provide the *sender* or event args and the [ClosableNotifierHandler](closablenotifierhandler.md) does not take any parameters. The subscriber to the events is responsible for knowing to which WinRT object it is subscribed to.

## -see-also

## -examples


