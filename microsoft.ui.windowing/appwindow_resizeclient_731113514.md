---
-api-id: M:Microsoft.UI.Windowing.AppWindow.ResizeClient(Windows.Graphics.SizeInt32)
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.ResizeClient(Windows.Graphics.SizeInt32)

<!--
public void ResizeClient (Windows.Graphics.SizeInt32 size);
-->

## -description

Resizes the window to accommodate the specified size for the client area.

## -parameters

### -param size

The height and width of the window client area in Win32 client coordinates.

## -remarks

Call this method to resize the window if you know the size of the client area you need. Use the [ClientSize](appwindow_clientsize.md) property to check the size of the client area. The non-client area is calculated for you. Use the [Size](appwindow_size.md) property to get the height and width of the entire window.

After the window size has changed a [Changed](appwindow_changed.md) event will occur.

_Client coordinates_ are relative to the upper-left corner of the window's client area; the coordinates of the upper-left corner are (0,0). For more information, see [Window Coordinate System (Win32)](/windows/win32/gdi/window-coordinate-system).

## -see-also

[AppWindow](appwindow.md), [ClientSize](appwindow_clientsize.md), [Window Coordinate System (Win32)](/windows/win32/gdi/window-coordinate-system), [Windows Forms coordinates](/dotnet/desktop/winforms/windows-forms-coordinates), [Move](appwindow_move_893940313.md), [MoveAndResize](/windows/windows-app-sdk/api/winrt/microsoft.ui.windowing.appwindow.moveandresize), [AdjustWindowRectEx](/windows/win32/api/winuser/nf-winuser-adjustwindowrectex)

## -examples


