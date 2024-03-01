---
-api-id: E:Microsoft.UI.Xaml.Application.ResourceManagerRequested
-api-type: winrt event
---

# Microsoft.UI.Xaml.Application.ResourceManagerRequested

<!--
public event Windows.Foundation.TypedEventHandler<object,Microsoft.UI.Xaml.ResourceManagerRequestedEventArgs> ResourceManagerRequested;
-->

## -description

Occurs during startup of a new WinUI thread to let you provide a custom `IResourceManager` implementation to be used by the framework for resolving resource URIs.

## -remarks

The WinUI framework instantiates an MRT Core [ResourceManager](/microsoft.windows.applicationmodel.resources/resourcemanager.md) to resolve resource URIs. For more info, see [Manage resources with MRT Core](/windows/apps/windows-app-sdk/mrtcore/mrtcore-overview). If your app needs non-standard behavior not provided by the default `ResourceManager` in order to resolve a particular resource URI, you can provide your own custom implementation of the [IResourceManager](/microsoft.windows.applicationmodel.resources/iresourcemanager.md) interface to use instead of the default `ResourceManager`.

Handle the `ResourceManagerRequested` event to provide the WinUI framework with a custom [IResourceManager](/microsoft.windows.applicationmodel.resources/iresourcemanager.md) to replace the default [ResourceManager](/microsoft.windows.applicationmodel.resources/resourcemanager.md) that the framework creates. In the event handler, instantiate your custom `IResourceManager` and assign it to the [ResourceManagerRequestedEventArgs.CustomResourceManager](resourcemanagerrequestedeventargs_customresourcemanager.md) property. The value of this property is initially `null`, and it is only checked by the framework once per event raise after all registered event handlers have been invoked. If the property value is still `null`, then the framework will use the default `ResourceManager`.

This event is raised once per WinUI thread during initialization. If you use the same `IResourceManager` for multiple threads, then the `IResourceManager` must be thread-safe.

We recommend that you register the event handler in the `App` class constructor so that it is available during initial app launch, as shown here.

```csharp
public App()
{
   this.InitializeComponent();

   ResourceManagerRequested += (_, e) =>
   {
      // CreateResourceManager() is a custom method you
      // create that returns an instance of IResourceManager.
      IResourceManager resourceManager = CreateResourceManager();
      e.ResourceManager = resourceManager;
   };
}
```

## -see-also

[Manage resources with MRT Core](/windows/apps/windows-app-sdk/mrtcore/mrtcore-overview), [IResourceManager](/microsoft.windows.applicationmodel.resources/iresourcemanager.md), [ResourceManager](/microsoft.windows.applicationmodel.resources/resourcemanager.md)

## -examples


