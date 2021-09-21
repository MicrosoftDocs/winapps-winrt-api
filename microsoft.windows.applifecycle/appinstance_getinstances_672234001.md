---
-api-id: M:Microsoft.Windows.AppLifecycle.AppInstance.GetInstances
-api-type: winrt method
---

# Microsoft.Windows.AppLifecycle.AppInstance.GetInstances

<!--
public static System.Collections.Generic.IList<Microsoft.Windows.AppLifecycle.AppInstance> GetInstances ();
-->


## -description

Retrieves a collection of all running instances of the app.

## -returns

The collection of all running instances of the app.

## -remarks

Whereas the [GetInstances](/uwp/api/windows.applicationmodel.appinstance.getinstances) method in the Windows OS only returns app instances that have explicitly registered for multi-instance redirection, this method in the Windows App SDK returns a list of all running app instances and does not require explicit registration by the app.

## -see-also

## -examples


