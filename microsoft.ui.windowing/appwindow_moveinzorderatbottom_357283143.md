---
-api-id: M:Microsoft.UI.Windowing.AppWindow.MoveInZOrderAtBottom
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.MoveInZOrderAtBottom

<!--
public void MoveInZOrderAtBottom ();
-->

## -description

Moves the current window to be the bottom window in the Z-order.

## -remarks

If the window is a topmost window, the window loses its topmost status and is placed at the bottom of all other windows. This corresponds to calling the [SetWindowPos](/windows/win32/api/winuser/nf-winuser-setwindowpos) function with the `hWndInsertAfter` parameter set to `HWND_BOTTOM`.

## -see-also

## -examples


