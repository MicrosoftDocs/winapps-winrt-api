---
-api-id: E:Microsoft.UI.Input.InputFocusController.GotFocus
-api-type: winrt event
---

# Microsoft.UI.Input.InputFocusController.GotFocus

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Input.InputFocusController,Microsoft.UI.Input.FocusChangedEventArgs> GotFocus;
-->

## -description

Occurs when the associated [ContentIsland](../microsoft.ui.content/contentisland.md) receives focus.

## -remarks

A [ContentIsland](../microsoft.ui.content/contentisland.md) can receive focus through the [TrySetFocus](inputfocuscontroller_trysetfocus_432736152.md) method, or because focus is moved from elsewhere. For example, an app using a [DesktopChildSiteBridge](../microsoft.ui.content/desktopchildsitebridge.md) to host content should signal that focus is to move to the content by calling [SetFocus](/windows/win32/api/winuser/nf-winuser-setfocus) on the HWND of the bridge. The bridge internally will then move focus to the underlying HWND of the [ContentIsland](../microsoft.ui.content/contentisland.md) and the [GotFocus](inputfocuscontroller_gotfocus.md) event will be raised.

> [!NOTE]
> If the top-level HWND of an app has focus and becomes inactive, focus will be lost and will not set back once the HWND is active again. Instead focus will be set to the top-level window that was activated and the HWND will not raise the [GotFocus](inputfocuscontroller_gotfocus.md) event (for example, if the user Alt+Tab navigates back to the app).
>
> In this case, you need to manually set focus to the [ContentIsland](../microsoft.ui.content/contentisland.md). The [InputActivationListener](inputactivationlistener.md) supports events that can help determine when a window has been activated.

## -see-also

[InputFocusController.TrySetFocus](inputfocuscontroller_trysetfocus_432736152.md), [InputFocusController.HasFocus](inputfocuscontroller_hasfocus.md), [InputFocusController.LostFocus](inputfocuscontroller_lostfocus.md)

## -examples
