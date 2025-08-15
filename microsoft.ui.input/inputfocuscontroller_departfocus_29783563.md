---
-api-id: M:Microsoft.UI.Input.InputFocusController.DepartFocus(Microsoft.UI.Input.FocusNavigationRequest)
-api-type: winrt method
---

# Microsoft.UI.Input.InputFocusController.DepartFocus(Microsoft.UI.Input.FocusNavigationRequest)

<!--
public Microsoft.UI.Input.FocusNavigationResult DepartFocus (Microsoft.UI.Input.FocusNavigationRequest request);
-->

## -description

Raises the InputFocusNavigationHost.DepartFocusRequested event for the [Content.ContentIsland](../microsoft.ui.content/contentisland.md) host.

For example, the user has tabbed through all of the tabbable elements within the ContentIsland and now focus should move away from the Island to something else in the hosting application.

## -parameters

### -param request

Details of the focus navigation event.

## -returns

The possible results of a focus navigation event, determined by the [Content.ContentIsland](../microsoft.ui.content/contentisland.md) host.

## -remarks

The FocusNavigationResult value returned by this method is determined by the [Content.ContentIsland](../microsoft.ui.content/contentisland.md) host, and is not a result of focus actually moving. Check if focus was actually moved by using either the [HasFocus](../microsoft.ui.xaml.hosting/desktopwindowxamlsource_hasfocus.md) property or by listening for the [LostFocus](../microsoft.ui.xaml.input/focusmanager_lostfocus.md) event.

## -see-also

## -examples
