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

Whereas the [Windows.ApplicationModel.AppInstance.GetInstances](/uwp/api/windows.applicationmodel.appinstance.getinstances) method in the Windows OS only returns app instances that have explicitly registered for multi-instance redirection using the [FindOrRegisterInstanceForKey](/uwp/api/windows.applicationmodel.appinstance.findorregisterinstanceforkey) method, this method in the Windows App SDK returns a list of all running app instances that have called any [AppInstance](appinstance.md) method. Typically, an app instance will call [AppInstance.GetCurrent](appinstance_getcurrent_1996055397.md), and this does two things: it adds the current instance to the list that will get returned by the **GetInstances** method, and it returns the current instance.

## -see-also

## -examples


