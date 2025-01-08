---
-api-id: E:Microsoft.UI.Xaml.Controls.TabView.ExternalTornOutTabsDropping
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.TabView.ExternalTornOutTabsDropping

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.TabView,Microsoft.UI.Xaml.Controls.TabViewExternalTornOutTabsDroppingEventArgs> ExternalTornOutTabsDropping;
-->

## -description

Occurs when tabs torn-out from a TabView in another window are being dropped onto this TabView.

## -remarks

Handle this event to specify whether to allow the drop to occur. Set [TabViewExternalTornOutTabsDroppingEventArgs.AllowDrop](tabviewexternaltornouttabsdroppingeventargs_allowdrop.md) to `true` to allow the drop; otherwise, set it to `false` (the default). If set to `false`, the [ExternalTornOutTabsDropped](tabview_externaltornouttabsdropped.md) event is not raised and the user will continue to be dragging the torn-out tabs.

External tabs are accepted only from other TabView controls in the same process.

This event occurs only when the [CanTearOutTabs](tabview_cantearouttabs.md) property is `true`.

## -see-also

[Tab view](/windows/apps/design/controls/tab-view), [CanTearOutTabs](tabview_cantearouttabs.md), [TabTearOutWindowRequested](tabview_tabtearoutwindowrequested.md), [TabTearOutRequested](tabview_tabtearoutrequested.md), [ExternalTornOutTabsDropped](tabview_externaltornouttabsdropped.md)

## -examples
