---
-api-id: M:Microsoft.UI.Input.InputFocusNavigationHost.NavigateFocus(Microsoft.UI.Input.FocusNavigationRequest)
-api-type: winrt method
---

# Microsoft.UI.Input.InputFocusNavigationHost.NavigateFocus(Microsoft.UI.Input.FocusNavigationRequest)

<!--
public Microsoft.UI.Input.FocusNavigationResult NavigateFocus (Microsoft.UI.Input.FocusNavigationRequest request);
-->

## -description

Tells the [Content.ContentIsland](../microsoft.ui.content/contentisland.md) corresponding to the associated [ContentSiteBridge](../microsoft.ui.content/icontentsitebridge.md) to raise its [InputFocusController.NavigateFocusRequested](inputfocuscontroller_navigatefocusrequested.md) event.

## -parameters

### -param request

The details for focus navigation event.

## -returns

The result of the focus navigation event.

## -remarks

An InputFocusNavigationHost is associated with a specific [ContentSiteBridge](../microsoft.ui.content/icontentsitebridge.md).

## -see-also

## -examples
