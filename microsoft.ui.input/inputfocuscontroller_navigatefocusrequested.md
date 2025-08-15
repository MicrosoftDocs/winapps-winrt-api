---
-api-id: E:Microsoft.UI.Input.InputFocusController.NavigateFocusRequested
-api-type: winrt event
---

# Microsoft.UI.Input.InputFocusController.NavigateFocusRequested

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Input.InputFocusController,Microsoft.UI.Input.FocusNavigationRequestEventArgs> NavigateFocusRequested;
-->

## -description

Occurs when the [Content.ContentIsland](../microsoft.ui.content/contentisland.md) host wants the ContentIsland to take focus.

For example, the user has tabbed through the elements of the host and now needs to tab into the ContentIsland. The hosting application calls [InputFocusNavigationHost.NavigateFocus(Microsoft.UI.Input.FocusNavigationRequest)](inputfocusnavigationhost_navigatefocus_534361705.md) on the [InputFocusNavigationHost](inputfocusnavigationhost.md) associated with the [SiteBridge](../microsoft.ui.xaml.hosting/desktopwindowxamlsource_sitebridge.md). The  [InputFocusController](inputfocuscontroller.md) for the ContentIsland then receives this NavigateFocusRequested event and can decide if it will take focus.

## -remarks

Setting the result value of the [FocusNavigationRequestEventArgs](focusnavigationrequesteventargs.md) does not implicitly set focus. [TrySetFocus](inputfocuscontroller_trysetfocus_432736152.md) must be called explicitly.

## -see-also

## -examples
