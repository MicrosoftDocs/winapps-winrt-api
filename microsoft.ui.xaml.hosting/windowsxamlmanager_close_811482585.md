---
-api-id: M:Microsoft.UI.Xaml.Hosting.WindowsXamlManager.Close
-api-type: winrt method
---

# Microsoft.UI.Xaml.Hosting.WindowsXamlManager.Close

<!--
// This member is not implemented in C#
-->

## -description

Closes and asynchronously releases any resources used by this [WindowsXamlManager](windowsxamlmanager.md).

## -remarks

Ensure that all asynchronous work has completed before exiting the thread on which the **WindowsXamlManager** was initialized. Some ways to do this include:

- Calling [DispatcherQueueController.ShutdownQueueAsync](../microsoft.ui.dispatching/dispatcherqueuecontroller_shutdownqueueasync_542547627.md) and awaiting its completion.
- Running the top-level message pump until `PeekMessage` returns `FALSE`.

## -see-also

## -examples
