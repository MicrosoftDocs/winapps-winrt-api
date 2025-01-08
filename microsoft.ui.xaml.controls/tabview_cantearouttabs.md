---
-api-id: P:Microsoft.UI.Xaml.Controls.TabView.CanTearOutTabs
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.TabView.CanTearOutTabs

<!--
public bool CanTearOutTabs { get; set; }
-->

## -description

Gets or sets a value that indicates whether or not tearing out tabs into a new window is allowed on this TabView.

## -property-value

`true` if tabs can be torn out into a new window; otherwise, `false`. The default is `false`.

## -remarks

When this property is set to true, it causes [TabTearOutWindowRequested](tabview_tabtearoutwindowrequested.md) and [TabTearOutRequested](tabview_tabtearoutrequested.md) events to be raised instead of the [TabDragStarting](tabview_tabdragstarting.md) event, and causes [ExternalTornOutTabsDropping](tabview_externaltornouttabsdropping.md) and [ExternalTornOutTabsDropped](tabview_externaltornouttabsdropped.md) events to be raised instead of [TabStripDragOver](tabview_tabstripdragover.md), [TabStripDrop](tabview_tabstripdrop.md), [TabDragCompleted](tabview_tabdragcompleted.md), and [TabDroppedOutside](tabview_tabdroppedoutside.md) events.

## -see-also

[Tab view](/windows/apps/design/controls/tab-view), [TabTearOutWindowRequested](tabview_tabtearoutwindowrequested.md), [TabTearOutRequested](tabview_tabtearoutrequested.md), [ExternalTornOutTabsDropping](tabview_externaltornouttabsdropping.md), [ExternalTornOutTabsDropped](tabview_externaltornouttabsdropped.md)

## -examples
