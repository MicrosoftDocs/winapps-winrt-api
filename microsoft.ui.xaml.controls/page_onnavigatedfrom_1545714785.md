---
-api-id: M:Microsoft.UI.Xaml.Controls.Page.OnNavigatedFrom(Microsoft.UI.Xaml.Navigation.NavigationEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnNavigatedFrom(Windows.UI.Xaml.Navigation.NavigationEventArgs e)
-->

# Microsoft.UI.Xaml.Controls.Page.OnNavigatedFrom

## -description

Invoked immediately after the [Page](page.md) is unloaded and is no longer the current source of a parent [Frame](frame.md).

## -parameters

### -param e

Event data that can be examined by overriding code. The event data is representative of the navigation that has unloaded the current [Page](page.md).

## -remarks

`OnNavigatedFrom` is invoked by default when you navigate between pages in your app. You can override this method and get info about the navigation from the `NavigationEventArgs`, and take any action required by your app.

In addition to being invoked when navigating between pages, the `OnNavigatedFrom` method is invoked when [Frame.GetNavigationState](frame_getnavigationstate_1352043812.md) is called. To avoid any issues, you should use [OnNavigatingFrom](page_onnavigatingfrom_1820075439.md) or the [Unloaded](../microsoft.ui.xaml/frameworkelement_unloaded.md) event, which are only called on actual navigation, to unregister event handlers and do other cleanup.

## -examples

## -see-also
