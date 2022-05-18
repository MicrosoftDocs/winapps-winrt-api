---
-api-id: P:Microsoft.UI.Windowing.AppWindow.Size
-api-type: winrt property
---

# Microsoft.UI.Windowing.AppWindow.Size

<!--
public Windows.Graphics.SizeInt32 Size { get; }
-->

## -description

Gets the current size of the window in screen coordinates.

## -property-value

The current size of the window in screen coordinates.

## -remarks

To get the size of only the client area of the window, use the [ClientSize](appwindow_clientsize.md) property.

_Screen coordinates_ are relative to the upper-left corner of the screen; the coordinates of the upper-left corner are (0,0). For more information, see [Window Coordinate System (Win32)](/windows/win32/gdi/window-coordinate-system).

## -see-also

[AppWindow](appwindow.md), [ClientSize](appwindow_clientsize.md), [Resize](appwindow_resize_102971024.md) [Window Coordinate System (Win32)](/windows/win32/gdi/window-coordinate-system), [Windows Forms coordinates](/dotnet/desktop/winforms/windows-forms-coordinates)

## -examples
