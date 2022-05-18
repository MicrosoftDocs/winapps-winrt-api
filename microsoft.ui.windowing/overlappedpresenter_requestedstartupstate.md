---
-api-id: P:Microsoft.UI.Windowing.OverlappedPresenter.RequestedStartupState
-api-type: winrt property
---

# Microsoft.UI.Windowing.OverlappedPresenter.RequestedStartupState

<!--
public static Microsoft.UI.Windowing.OverlappedPresenterState RequestedStartupState { get; }
-->

## -description

Gets a value that specifies the [OverlappedPresenterState](overlappedpresenterstate.md) that the window will assume when [AppWindow.ShowOnceWithRequestedStartupState](appwindow_showoncewithrequestedstartupstate_602256646.md) is called.

## -property-value

A value of the enumeration that specifies the requested state of the window on startup.

## -remarks

[AppWindow.ShowOnceWithRequestedStartupState](appwindow_showoncewithrequestedstartupstate_602256646.md) is the equivalent of calling [ShowWindow(SW_SHOWDEFAULT)](/windows/win32/api/winuser/nf-winuser-showwindow). It uses the show mode specified in the [STARTUPINFO](/windows/win32/api/processthreadsapi/ns-processthreadsapi-startupinfoa) struct, if specified. This applies to the default presenter ([OverlappedPresenter](overlappedpresenter.md)). Check the `RequestedStartupState` property to determine the presenter state (`Maximized`, `Minimized`, or `Restored`) that will result from calling the [AppWindow.ShowOnceWithRequestedStartupState](appwindow_showoncewithrequestedstartupstate_602256646.md) method.

## -see-also

## -examples

