---
-api-id: E:Microsoft.UI.Xaml.Controls.TabView.ExternalTornOutTabsDropped
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.TabView.ExternalTornOutTabsDropped

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.TabView,Microsoft.UI.Xaml.Controls.TabViewExternalTornOutTabsDroppedEventArgs> ExternalTornOutTabsDropped;
-->

## -description

Occurs when tabs torn-out from a TabView in another window have been dropped onto this TabView.

## -remarks

Handle this event to move dropped tabs from the originating TabView control into this TabView. Use the  [TabViewExternalTornOutTabsDroppedEventArgs.DropIndex](tabviewexternaltornouttabsdroppedeventargs_dropindex.md) to determine where in the TabView the dropped tab should be inserted.

This event occurs after [ExternalTornOutTabsDropping](tabview_externaltornouttabsdropping.md), and only when [AllowDrop](tabviewexternaltornouttabsdroppingeventargs_allowdrop.md) is set to `true` in the `ExternalTornOutTabsDropping` event args and the [CanTearOutTabs](tabview_cantearouttabs.md) property is `true`.

## -see-also

[Tab view](/windows/apps/design/controls/tab-view), [CanTearOutTabs](tabview_cantearouttabs.md), [TabTearOutWindowRequested](tabview_tabtearoutwindowrequested.md), [TabTearOutRequested](tabview_tabtearoutrequested.md), [ExternalTornOutTabsDropping](tabview_externaltornouttabsdropping.md)

## -examples


