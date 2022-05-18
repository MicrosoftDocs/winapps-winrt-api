---
-api-id: P:Microsoft.UI.Windowing.AppWindow.ClientSize
-api-type: winrt property
---

# Microsoft.UI.Windowing.AppWindow.ClientSize

<!--
public Windows.Graphics.SizeInt32 ClientSize { get; }
-->

## -description

Gets the current size of the window's client area in Win32 client coordinates.

## -property-value

The current size of the window's client area in Win32 client coordinates.

## -remarks

To get the size of the entire window, use the [Size](appwindow_size.md) property.

_Client coordinates_ are relative to the upper-left corner of the window's client area; the coordinates of the upper-left corner are (0,0). For more information, see [Window Coordinate System (Win32)](/windows/win32/gdi/window-coordinate-system).

## -see-also

[AppWindow](appwindow.md), [Size](appwindow_size.md), [ResizeClient](appwindow_resizeclient_731113514.md), [Window Coordinate System (Win32)](/windows/win32/gdi/window-coordinate-system), [Windows Forms coordinates](/dotnet/desktop/winforms/windows-forms-coordinates)

## -examples


