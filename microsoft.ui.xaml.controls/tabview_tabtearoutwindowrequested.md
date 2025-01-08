---
-api-id: E:Microsoft.UI.Xaml.Controls.TabView.TabTearOutWindowRequested
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.TabView.TabTearOutWindowRequested

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.TabView,Microsoft.UI.Xaml.Controls.TabViewTabTearOutWindowRequestedEventArgs> TabTearOutWindowRequested;
-->

## -description

Occurs when the user has started to drag the selected tabs and `CanTearOutTabs` is set to `true`.

## -remarks

Handle this event to create a new [Window](../microsoft.ui.xaml/window.md) in which to host the torn-out tabs. In the event handler, create the new window and set the event args [NewWindowId](tabviewtabtearoutwindowrequestedeventargs_newwindowid.md) property to the [AppWindow.Id](../microsoft.ui.windowing/appwindow_id.md) of the new window.

This event occurs only when the [CanTearOutTabs](tabview_cantearouttabs.md) property is `true`.

## -see-also

[Tab view](/windows/apps/design/controls/tab-view), [CanTearOutTabs](tabview_cantearouttabs.md), [TabTearOutRequested](tabview_tabtearoutrequested.md), [ExternalTornOutTabsDropping](tabview_externaltornouttabsdropping.md), [ExternalTornOutTabsDropped](tabview_externaltornouttabsdropped.md)

## -examples


