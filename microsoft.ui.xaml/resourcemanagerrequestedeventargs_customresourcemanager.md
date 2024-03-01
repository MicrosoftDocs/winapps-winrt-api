---
-api-id: P:Microsoft.UI.Xaml.ResourceManagerRequestedEventArgs.CustomResourceManager
-api-type: winrt property
---

# Microsoft.UI.Xaml.ResourceManagerRequestedEventArgs.CustomResourceManager

<!--
public Microsoft.Windows.ApplicationModel.Resources.IResourceManager CustomResourceManager { get; set; }
-->

## -description

Gets or sets the custom `IResourceManager` instance to be used by WinUI to resolve MRT resources for the current thread.

## -property-value

A custom `IResourceManager` instance to be used by WinUI to resolve MRT resources for the current thread, or `null` to use the default `ResourceManager`. The default is `null`.

## -remarks

If you leave the value `null` then the default `ResourceManager` created by the framework is used.

## -see-also

[Manage resources with MRT Core](/windows/apps/windows-app-sdk/mrtcore/mrtcore-overview), [IResourceManager](/microsoft.windows.applicationmodel.resources/iresourcemanager.md), [ResourceManager](/microsoft.windows.applicationmodel.resources/resourcemanager.md), [Application.ResourceManagerRequested](application_resourcemanagerrequested.md)

## -examples
