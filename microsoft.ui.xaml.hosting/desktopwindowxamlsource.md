---
-api-id: T:Microsoft.UI.Xaml.Hosting.DesktopWindowXamlSource
-api-type: winrt class
---

# Microsoft.UI.Xaml.Hosting.DesktopWindowXamlSource

<!--
public class DesktopWindowXamlSource : System.IDisposable
-->

## -description

Enables a desktop application to host WinUI controls in any UI element that is associated with a window handle (HWND).

## -remarks

**DesktopWindowXamlSource** is the primary class in the *Windows App SDK (WASDK) XAML hosting API*. This API enables non-WASDK desktop applications to host any control that derives from [Microsoft.UI.Xaml.UIElement](../microsoft.ui.xaml/uielement.md) in a UI element that is associated with a window handle (HWND). This API can be used by desktop applications built using WPF, Windows Forms, and the Windows API (Win32).

If you create a **DesktopWindowXamlSource** object before you create the **UIElement** objects that will be hosted in it, the framework for hosting **UIElement** content ensures all the objects are initialized to the same thread. If you create the **UIElement** objects before you create the **DesktopWindowXamlSource** object in which they will be hosted, you must call [Microsoft.UI.Xaml.Hosting.WindowsXamlManager.InitializeForCurrentThread](windowsxamlmanager_initializeforcurrentthread_14911797.md) before you instantiate the **UIElement** objects.

Because **DesktopWindowXamlSource** derives from [IClosable](/uwp/api/windows.foundation.iclosable), we recommended that you [Close](desktopwindowxamlsource_close_811482585.md) (**Dispose** in .NET) the object when you're finished with it.

## -see-also

[Using the WinRT XAML hosting API in a C++ desktop (Win32) app](/windows/apps/desktop/modernize/using-the-xaml-hosting-api)

## -examples

This sample shows how to add a WASDK island with XAML content to a Win32 app (the Windows App SDK runtime must be installed for the app to run).

[Simple Island App](https://github.com/microsoft/WindowsAppSDK-Samples/tree/main/Samples/Islands)
