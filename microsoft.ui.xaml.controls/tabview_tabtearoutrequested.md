---
-api-id: E:Microsoft.UI.Xaml.Controls.TabView.TabTearOutRequested
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.TabView.TabTearOutRequested

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.TabView,Microsoft.UI.Xaml.Controls.TabViewTabTearOutRequestedEventArgs> TabTearOutRequested;
-->

## -description

Occurs when the user has started to tear-out tabs from a TabView and a new window has been provided by the `TabTearOutWindowRequested` event.

## -remarks

For more information and examples, see [Tab view > Tab tear-out](/windows/apps/design/controls/tab-view#tab-tear-out).

Handle this event to transfer the torn-out tab data items to the window specified by [NewWindowId](tabviewtabtearoutrequestedeventargs_newwindowid.md). This is usually done by adding them to the [TabItemsSource](tabview_tabitemssource.md) of a TabView control in that new window.

This event occurs after the [TabTearOutWindowRequested](tabview_tabtearoutwindowrequested.md) event has completed (where `NewWindowId` is set) and only when the [CanTearOutTabs](tabview_cantearouttabs.md) property is `true`.

## -see-also

[Tab view](/windows/apps/design/controls/tab-view), [CanTearOutTabs](tabview_cantearouttabs.md), [TabTearOutWindowRequested](tabview_tabtearoutwindowrequested.md), [ExternalTornOutTabsDropping](tabview_externaltornouttabsdropping.md), [ExternalTornOutTabsDropped](tabview_externaltornouttabsdropped.md)

## -examples
