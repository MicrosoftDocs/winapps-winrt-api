---
-api-id: E:Microsoft.UI.Xaml.Hosting.WindowsXamlManager.XamlShutdownCompletedOnThread
-api-type: winrt event
---

# Microsoft.UI.Xaml.Hosting.WindowsXamlManager.XamlShutdownCompletedOnThread

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Hosting.WindowsXamlManager,Microsoft.UI.Xaml.Hosting.XamlShutdownCompletedOnThreadEventArgs> XamlShutdownCompletedOnThread;
-->

## -description

Occurs when the XAML runtime has finished its shutdown process on the current thread.

## -remarks

Shutdown of the XAML runtime is tied to the shutdown sequence of the [DispatcherQueue](../microsoft.ui.dispatching/dispatcherqueue.md) running on the thread. For more info, see the [DispatcherQueue documentation](/windows/apps/develop/dispatcherqueue).

When a [DispatcherQueue](../microsoft.ui.dispatching/dispatcherqueue.md) on a thread that uses XAML is shutdown, these events are raised in order:

* The [DispatcherQueue.ShutdownStarting](../microsoft.ui.dispatching/dispatcherqueue_shutdownstarting.md) event is raised. Intended for apps to handle.
* The [DispatcherQueue.FrameworkShutdownStarting](../microsoft.ui.dispatching/dispatcherqueue_frameworkshutdownstarting.md) event is raised. Intended for frameworks to handle.
  * The **WindowsXamlManager.XamlShutdownCompletedOnThread** event is raised in response to **FrameworkShutdownStarting**. Intended for apps to handle.
* The [DispacherQueue.FrameworkShutdownCompleted](../microsoft.ui.dispatching/dispatcherqueue_frameworkshutdowncompleted.md) event is raised. The **DispatcherQueue** is not available for new work at this point.
* The [DispacherQueue.ShutdownCompleted](../microsoft.ui.dispatching/dispatcherqueue_shutdowncompleted.md) event is raised. The **DispatcherQueue** is not available for new work at this point.

At the time the **WindowsXamlManager.XamlShutdownCompletedOnThread** event is raised:

* XAML has unloaded all the live XAML objects and raised the [Unloaded](../microsoft.ui.xaml/frameworkelement_unloaded.md) event for each object.
* XAML no longer has any state associated with the current thread. [WindowsXamlManager.GetForCurrentThread](windowsxamlmanager_getforcurrentthread_1771949562.md) returns `null` at this time.
* The [DispatcherQueue](../microsoft.ui.dispatching/dispatcherqueue.md) on the current thread is still available and usable. It is in its shutdown sequence, so note the [ShutdownStarting](../microsoft.ui.dispatching/dispatcherqueue_shutdownstarting.md) event has already been raised and will not be raised again.

> [!NOTE]
> Even if you call [Close](windowsxamlmanager_close_811482585.md) on the **WindowsXamlManager** object or release all your references to it, this event will still be raised.

## -examples

This example demonstrates how you might subscribe to the event to clean up your objects when XAML is no longer running on the thread.

In this example you have some different types of objects you want to clean up as the app shuts down. XAML has some indirect references to some of these objects (for example, "Model" objects like in an Model-View-ViewModel app), so you don't want to destroy these until XAML is finished with its work. You also have some objects that are getting cleaned up in another process, and you want to wait for those as well.

So, you use the **XamlShutdownCompletedOnThread** event and its deferral to organize the shutdown process. When this event is raised, you know XAML is done using your objects on this thread. You can also take a deferral so that shutdown won't complete until your remote operations are finished.

```cpp
WindowsXamlManager manager = WindowsXamlManager::GetForCurrentThread();
manager.XamlShutdownCompletedOnThread([](
    const WindowsXamlManager& sender,
    const XamlShutdownCompletedOnThreadEventArgs& args) -> IAsyncAction
    {
        // Once we get this deferral, the DispatcherQueue shutdown process
        // won't continue until Complete is called.
        // Until we call deferral.Complete(), we can still use the 
        // DispatcherQueue and give it new work.
        auto deferral = args.GetDispatcherQueueDeferral();

        // Now that XAML has shutdown, we can clean up any of our objects
        // that XAML might have been using.
        CleanupUIThreadObjects();

        // Capture the UI thread context.
        winrt::apartment_context ui_thread;

        // We can also do cleanup work that might take a while. For example, 
        // we can wait for work in other processes to finish.
        co_await CleanupRemoteObjects();

        // Switch back to the UI thread, in case we have any UI-thread work left to do.
        // It will still be running because we took the deferral.
        co_await ui_thread;

        // Done! Shutdown may continue.
        deferral.Complete();
    });
```

## -see-also

