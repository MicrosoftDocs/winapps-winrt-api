---
-api-id: P:Microsoft.UI.Xaml.Controls.TabViewTabTearOutRequestedEventArgs.NewWindowId
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.TabViewTabTearOutRequestedEventArgs.NewWindowId

<!--
public Microsoft.UI.WindowId NewWindowId { get; }
-->

## -description

Gets the `WindowId` for the new window that will host the torn-out tabs.

## -property-value

The `WindowId` for the new window that will host the torn-out tabs. The default is `null`.

## -remarks

The new window is provided in the [TabView.TabTearOutWindowRequested](tabview_tabtearoutwindowrequested.md) event. If the `NewWindowId` is not set in the `TabTearOutWindowRequested` event handler, the tab tear-out will be cancelled and this event will not be raised. The window represented by the window ID can be any HWND, not necessarily a XAML [Window](../microsoft.ui.xaml/window.md). It must be on the same thread as the TabView.

## -see-also

## -examples
