---
-api-id: M:Microsoft.UI.Xaml.Hosting.WindowsXamlManager.InitializeForCurrentThread
-api-type: winrt method
---

# Microsoft.UI.Xaml.Hosting.WindowsXamlManager.InitializeForCurrentThread

<!--
public static Microsoft.UI.Xaml.Hosting.WindowsXamlManager InitializeForCurrentThread ();
-->

## -description

Initializes the WinUI XAML framework in a non-Windows App SDK (WASDK) desktop application (for example, a WPF or Windows Forms application) on the current thread.

## -returns

An object that contains a reference to the WinUI XAML framework.

## -remarks

Call this method to initialize the internal WinUI XAML framework for the current thread in a desktop application in which you want to host [Microsoft.UI.Xaml.UIElement](../microsoft.ui.xaml/uielement.md) objects in a [DesktopWindowXamlSource](desktopwindowxamlsource.md). You need to explicitly call this method only if your application creates the **Windows.UI.Xaml.UIElement** objects before it creates the **DesktopWindowXamlSource** object that will host them. Your application should typically call this method when the parent UI object that hosts the **DesktopWindowXamlSource** is instantiated.

If you create a **DesktopWindowXamlSource** object before you create the **Windows.UI.Xaml.UIElement** objects that will be hosted in it, you don’t need to call this method. In this scenario, the WinUI XAML framework will be initialized for you when you instantiate the **DesktopWindowXamlSource** object.

This method returns a [WindowsXamlManager](windowsxamlmanager.md) object that contains a reference to the WinUI XAML framework. You can create as many **WindowsXamlManager** objects as you want on a given thread. However, because each object holds a reference to the WinUI XAML framework, you should [Close](desktopwindowxamlsource_close_811482585.md) (**Dispose** in .NET) the objects to ensure that XAML resources are eventually released.

## -see-also

## -examples
