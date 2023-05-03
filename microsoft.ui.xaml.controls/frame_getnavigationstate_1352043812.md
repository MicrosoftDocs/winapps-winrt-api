---
-api-id: M:Microsoft.UI.Xaml.Controls.Frame.GetNavigationState
-api-type: winrt method
---

<!-- Method syntax
public string GetNavigationState()
-->

# Microsoft.UI.Xaml.Controls.Frame.GetNavigationState

## -description

Serializes the [Frame](frame.md) navigation history into a string.

## -returns

The string-form serialized navigation history. See Remarks.

## -remarks

This method is useful to save and restore the navigation state of your app. To save the navigation state, call `GetNavigationState` and save the return value. To restore the navigation state, call [SetNavigationState](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.frame.setnavigationstate) and pass it the saved value.

Calling this method will call [Page.OnNavigatedFrom](page_onnavigatedfrom_1545714785.md) for the current page using `NavigationMode.Forward`.

> [!TIP]
> In a UWP app, `GetNavigationState` is typically called when the app is suspended, and `SetNavigationState` is called when the app is resumed. When the app is resumed after being suspended, the user expects it to be in the same state.
>
>A Windows App SDK app does not have `Suspending` and `Resuming` events, so you should consider whether or not it's appropriate for your app to save and restore navigation state when a `Window` is [Closed](../microsoft.ui.xaml/window_closed.md) and [Activated](../microsoft.ui.xaml/window_activated.md). The user might not expect the navigation state to be restored after closing a `Window`. For more info, see [Windows App SDK app lifecycle](/windows/apps/windows-app-sdk/applifecycle/applifecycle).

> [!NOTE]
> The serialization format used by these methods is for internal use only. Your app should not form any dependencies on it. Additionally, this format supports serialization only for basic types like string, char, numeric and [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) types.

## -examples

## -see-also

[SetNavigationState](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.frame.setnavigationstate)
