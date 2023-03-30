---
-api-id: M:Microsoft.UI.Xaml.Controls.Frame.SetNavigationState(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void SetNavigationState(System.String navigationState)
-->

# Microsoft.UI.Xaml.Controls.Frame.SetNavigationState

## -description

Reads and restores the navigation history of a [Frame](frame.md) from a provided serialization string.

## -parameters

### -param navigationState

The serialization string that supplies the restore point for navigation history.

## -remarks

This method is useful to save and restore the navigation state of your app. To save the navigation state, call [GetNavigationState](frame_getnavigationstate_1352043812.md) and save the return value. To restore the navigation state, call `SetNavigationState` and pass it the saved value.

Calling `SetNavigationState` will call [Page.OnNavigatedTo](page_onnavigatedto_1316593960.md) for the current page, with `NavigationMode.Back`. `SetNavigationState` is usually called when the Window is activated, so the current page is navigated to.

> [!TIP]
> In a UWP app, `GetNavigationState` is typically called when the app is suspended, and `SetNavigationState` is called when the app is resumed. When the app is resumed after being suspended, the user expects it to be in the same state.
>
>A Windows App SDK app does not have `Suspending` and `Resuming` events, so you should consider whether or not it's appropriate for your app to save and restore navigation state when a `Window` is [Closed](../microsoft.ui.xaml/window_closed.md) and [Activated](../microsoft.ui.xaml/window_activated.md). The user might not expect the navigation state to be restored after closing a `Window`. For more info, see [Windows App SDK app lifecycle](/windows/apps/windows-app-sdk/applifecycle/applifecycle).

## -examples

## -see-also
