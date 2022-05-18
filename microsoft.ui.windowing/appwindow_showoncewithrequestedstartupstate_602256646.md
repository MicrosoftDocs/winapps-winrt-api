---
-api-id: M:Microsoft.UI.Windowing.AppWindow.ShowOnceWithRequestedStartupState
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.ShowOnceWithRequestedStartupState

<!--
public void ShowOnceWithRequestedStartupState ();
-->

## -description

Shows the window with the default presenter in the requested state.

## -remarks

`ShowOnceWithRequestedStartupState` is the equivalent of calling [ShowWindow(SW_SHOWDEFAULT)](/windows/win32/api/winuser/nf-winuser-showwindow). It uses the show mode specified in the [STARTUPINFO](/windows/win32/api/processthreadsapi/ns-processthreadsapi-startupinfoa) struct, if specified. This applies to the default presenter ([OverlappedPresenter](overlappedpresenter.md)). Check the [OverlappedPresenter.RequestedStartupState](overlappedpresenter_requestedstartupstate.md) property to determine the presenter state (`Maximized`, `Minimized`, or `Restored`) that will result from calling the `ShowOnceWithRequestedStartupState` method.

## -see-also

[ShowWindow](/windows/win32/api/winuser/nf-winuser-showwindow), [STARTUPINFO](/windows/win32/api/processthreadsapi/ns-processthreadsapi-startupinfoa)

## -examples

