---
-api-id: M:Microsoft.UI.Windowing.AppWindow.Create(Microsoft.UI.Windowing.AppWindowPresenter,Microsoft.UI.WindowId)
-api-type: winrt method
---

# Microsoft.UI.Windowing.AppWindow.Create(Microsoft.UI.Windowing.AppWindowPresenter,Microsoft.UI.WindowId)

<!--
public static Microsoft.UI.Windowing.AppWindow Create (Microsoft.UI.Windowing.AppWindowPresenter appWindowPresenter, Microsoft.UI.WindowId ownerWindowId);
-->


## -description

Creates a window with styles and properties as defined in the specified `AppWindowPresenter` and parented to the specified window.

## -parameters

### -param appWindowPresenter

An `AppWindowPresenter` object that specifies property values to apply to the window.

### -param ownerWindowId

The ID of the parent window for the new window.

## -returns

A new app window with the specified configuration.

## -remarks

To make this window an owned window, pass the [Id](appwindow_id.md) of the window you want to be its owner to the `ownerWindowsId` parameter. The `OwnerWindowId` must be a [WindowId](/uwp/api/windows.ui.windowid) from the same process as the window that has the configuration applied to it.

ContextMenu, Dialog, and ToolWindow configurations require this property to be set when the window is created in order to be applied successfully.

## -see-also

[AppWindow](appwindow.md), [AppWindowPresenter](appwindowpresenter.md)

## -examples
