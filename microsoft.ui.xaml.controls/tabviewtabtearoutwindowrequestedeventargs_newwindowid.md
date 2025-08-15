---
-api-id: P:Microsoft.UI.Xaml.Controls.TabViewTabTearOutWindowRequestedEventArgs.NewWindowId
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.TabViewTabTearOutWindowRequestedEventArgs.NewWindowId

<!--
public Microsoft.UI.WindowId NewWindowId { get; set; }
-->

## -description

Gets or sets the `WindowId` for the new window, if the application created one, that will host the torn-out tabs.

## -property-value

The `WindowId` for the new window, if the application created one, that will host the torn-out tabs. The default is `null`.

## -remarks

If this property is not set in the event handler, the tab tear-out will be cancelled. The window represented by the window ID can be any HWND, not necessarily a XAML [Window](../microsoft.ui.xaml/window.md). It must be on the same thread as the TabView.

## -see-also

## -examples
