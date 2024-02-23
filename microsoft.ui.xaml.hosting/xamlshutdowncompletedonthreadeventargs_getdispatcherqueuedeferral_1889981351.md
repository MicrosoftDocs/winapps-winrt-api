---
-api-id: M:Microsoft.UI.Xaml.Hosting.XamlShutdownCompletedOnThreadEventArgs.GetDispatcherQueueDeferral
-api-type: winrt method
---

# Microsoft.UI.Xaml.Hosting.XamlShutdownCompletedOnThreadEventArgs.GetDispatcherQueueDeferral

<!--
public Windows.Foundation.Deferral GetDispatcherQueueDeferral ();
-->

## -description

Gets a `Deferral` object that lets you delay completion of the shutdown until your operations are complete.

## -returns

A `Deferral` object that lets you delay completion of the shutdown until your operations are complete.

## -remarks

If you call this method, you must follow it with a call to the [Complete](/uwp/api/windows.foundation.deferral.complete) method on the [Deferral](/uwp/api/windows.foundation.deferral) object when you're ready for the DispatcherQueue's shutdown sequence to continue.

## -see-also

[WindowsXamlManager.XamlShutdownCompletedOnThread](windowsxamlmanager_xamlshutdowncompletedonthread.md)

## -examples


