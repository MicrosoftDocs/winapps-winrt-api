---
-api-id: M:Microsoft.UI.Windowing.AppWindow.SetIcon(Microsoft.UI.IconId)
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.SetIcon(Microsoft.UI.IconId)

<!--
public void SetIcon (Microsoft.UI.IconId iconId);
-->

## -description

Sets the icon for the window using the specified icon ID.

## -parameters

### -param iconId

The ID of the icon.

## -remarks

If you already have a handle to an icon (`HICON`) from one of the [Icon functions](/windows/win32/menurc/icon-functions) like [CreateIcon](/windows/win32/api/winuser/nf-winuser-createicon) or [LoadImage](/windows/win32/api/winuser/nf-winuser-loadimagew), you can use the [GetIconIdFromIcon](/windows/windows-app-sdk/api/win32/microsoft.ui.interop/nf-microsoft-ui-interop-geticonidfromicon) interop API to get an [IconId](/windows/windows-app-sdk/api/winrt/microsoft.ui.iconid). You can then pass the `IconId` to the `SetIcon(IconId)` method to set your window icon.

> [!IMPORTANT]
> When you include the .ico file with your apps assets, you have to set the Build Action to Content in the Visual Studio properties pane.
>
> :::image type="content" source="images/build-action-content.png" alt-text="Visual Studio properties U I for the icon file showing build action set to content.":::

## -see-also

[Build a C# .NET app with WinUI 3 and Win32 interop](/windows/apps/winui/winui3/desktop-winui3-app-with-basic-interop), [CsWin32 on GitHub](https://github.com/microsoft/CsWin32), [Getting started with CsWin32](https://microsoft.github.io/CsWin32/docs/getting-started.html)

## -examples

These examples assume you have an icon file named `MyAppIcon.ico` in the `Assets` folder of your project with its **Build Action** set to **Content**.

This code is placed in the `App.xaml.cs` file, but the icon can also be set in the file for the [Window](../microsoft.ui.xaml/window.md) class (`MainWindow.xaml.cs` by default).

This example shows how to use [Platform Invoke (P/Invoke)](/dotnet/standard/native-interop/pinvoke) get a handle to an icon using the Win32 [LoadImage](/windows/win32/api/winuser/nf-winuser-loadimagew) function. You can then get the [IconId](../microsoft.ui/iconid.md) and use it in the call to `SetIcon`.

`DLLImport` is used to access the `LoadImage` function in `user32.dll`.

```csharp
using Microsoft.UI;
using System;
using System.Runtime.InteropServices;

// ...

protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
{
    m_window = new MainWindow();
    LoadIconById("Assets/MyAppIcon.ico");
    m_window.Activate();
}

private void LoadIconById(string iconName)
{
    nint hwnd = WinRT.Interop.WindowNative.GetWindowHandle(m_window);
    IntPtr hIcon = LoadImage(
        IntPtr.Zero, iconName, ImageType.IMAGE_ICON, 16, 16, LoadImageFlags.LR_LOADFROMFILE);
    IconId iconID = Microsoft.UI.Win32Interop.GetIconIdFromIcon(hIcon);

    // SetIcon
    m_window?.AppWindow.SetIcon(iconID);
}

[DllImport("user32.dll", SetLastError = true)]
public static extern unsafe IntPtr LoadImage(
    IntPtr hInst,
    string name,
    ImageType type,
    int cx,
    int cy,
    LoadImageFlags fuLoad);

public enum ImageType : uint
{
    IMAGE_BITMAP = 0,
    IMAGE_ICON = 1,
    IMAGE_CURSOR = 2,
}

[Flags]
public enum LoadImageFlags : uint
{
    LR_CREATEDIBSECTION = 0x00002000,
    LR_DEFAULTCOLOR = 0x0,
    LR_DEFAULTSIZE = 0x00000040,
    LR_LOADFROMFILE = 0x00000010,
    LR_LOADMAP3DCOLORS = 0x00001000,
    LR_LOADTRANSPARENT = 0x00000020,
    LR_MONOCHROME = 0x00000001,
    LR_SHARED = 0x00008000,
    LR_VGACOLOR = 0x00000080,
}
```

This example does the same thing as the previous example. However, instead of using `DLLImport`, it uses the [CsWin32](https://microsoft.github.io/CsWin32/docs/features.html) NuGet package to access the `LoadImage` function.

```csharp
using Microsoft.UI;
using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Windows.Win32.UI.WindowsAndMessaging;

// ...

protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
{
    m_window = new MainWindow();
    LoadIconById("Assets/MyAppIcon.ico");
    m_window.Activate();
}

private void LoadIconById(string iconName)
{
    nint hwnd = WinRT.Interop.WindowNative.GetWindowHandle(m_window);
    SafeFileHandle hIcon_handle = Windows.Win32.PInvoke.LoadImage(
        null, iconName, GDI_IMAGE_TYPE.IMAGE_ICON, 32, 32, IMAGE_FLAGS.LR_LOADFROMFILE);

    if (hIcon_handle.IsInvalid || hIcon_handle.IsClosed)
    {
        Win32Exception ex = new Win32Exception(Marshal.GetLastWin32Error());
        throw ex;
    }
    bool success = false;
    hIcon_handle.DangerousAddRef(ref success);
    IconId iconID = Win32Interop.GetIconIdFromIcon(hIcon_handle.DangerousGetHandle());

    // SetIcon
    m_window?.AppWindow.SetIcon(iconID);
}

```
