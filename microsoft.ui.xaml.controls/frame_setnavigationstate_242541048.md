---
-api-id: M:Microsoft.UI.Xaml.Controls.Frame.SetNavigationState(System.String,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax.
public void Frame.SetNavigationState(String navigationState, Boolean suppressNavigate)
-->

# Microsoft.UI.Xaml.Controls.Frame.SetNavigationState

## -description

Reads and restores the navigation history of a [Frame](frame.md) from a provided serialization string.

## -parameters

### -param navigationState

The serialization string that supplies the restore point for navigation history.

### -param suppressNavigate

`true` to restore navigation history without navigating to the current page; otherwise, `false`.

## -remarks

If you call `SetNavigationState` with the `suppressNavigate` parameter set to `true`, [Page.OnNavigatedTo](page_onnavigatedto_1316593960.md) is not called for the current page. The current page is also put into the [BackStack](frame_backstack.md). When suppressing the transition, also be sure to use [GoBack](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.frame.goback) or [GoForward](frame_goforward_1537152893.md) to navigate to the correct page in the navigation history. [NavigateToType](frame_navigatetotype_1537292032.md) is also supported, however the forward stack will be cleared when it is used.

## -see-also

## -examples

