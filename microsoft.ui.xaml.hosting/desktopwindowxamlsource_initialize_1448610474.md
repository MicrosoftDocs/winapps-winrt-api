---
-api-id: M:Microsoft.UI.Xaml.Hosting.DesktopWindowXamlSource.Initialize(Microsoft.UI.WindowId)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Hosting.DesktopWindowXamlSource.Initialize(Microsoft.UI.WindowId)

<!--
public void Initialize (Microsoft.UI.WindowId parentWindowId);
-->

## -description

Initializes a new instance of the [DesktopWindowXamlSource](desktopwindowxamlsource.md) class.

## -parameters

### -param parentWindowId

The *WindowId* of the HWND of your Win32 application.

## -remarks

For C++ desktop application developers, use the [interop::GetWindowIdFromWindow](/windows/windows-app-sdk/api/win32/winrt-microsoft.ui.interop/nf-winrt-microsoft-ui-interop-getwindowidfromwindow) function to obtain the *WindowId* of the HWND of your Win32 application.

For C# desktop application developers, use the [Win32Interop.GetWindowIdFromWindow(IntPtr)](/windows/apps/api-reference/cs-interop-apis/microsoft.ui/microsoft.ui.win32interop.getwindowidfromwindow) method to obtain the *WindowId* of the HWND of your Win32 application.

## -see-also

## -examples
