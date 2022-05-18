---
-api-id: M:Microsoft.UI.Windowing.AppWindow.Resize(Windows.Graphics.SizeInt32)
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.Resize(Windows.Graphics.SizeInt32)

<!--
public void Resize (Windows.Graphics.SizeInt32 size);
-->

## -description

Resizes the window to the specified size.

## -parameters

### -param size

The height and width of the window in screen coordinates.

## -remarks

After the window size has changed a [Changed](appwindow_changed.md) event will occur.

Call [ResizeClient](appwindow_resizeclient_731113514.md) to resize the window when you know the size of the client area you need.

_Screen coordinates_ are relative to the upper-left corner of the screen; the coordinates of the upper-left corner are (0,0). For more information, see [Window Coordinate System (Win32)](/windows/win32/gdi/window-coordinate-system).

## -see-also

[AppWindow](appwindow.md), [Size](appwindow_size.md), [Window Coordinate System (Win32)](/windows/win32/gdi/window-coordinate-system), [Windows Forms coordinates](/dotnet/desktop/winforms/windows-forms-coordinates), [Move](appwindow_move_893940313.md), [MoveAndResize](/windows/windows-app-sdk/api/winrt/microsoft.ui.windowing.appwindow.moveandresize)

## -examples
