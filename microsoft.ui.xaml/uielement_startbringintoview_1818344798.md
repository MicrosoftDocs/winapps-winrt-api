---
-api-id: M:Microsoft.UI.Xaml.UIElement.StartBringIntoView
-api-type: winrt method
---

<!-- Method syntax.
public void UIElement.StartBringIntoView()
-->

# Microsoft.UI.Xaml.UIElement.StartBringIntoView

## -description

Initiates a request to the XAML framework to bring the element into view within any scrollable regions it is contained within.

## -remarks

The request is fulfilled asynchronously as the framework initiates changes to the view of [ScrollViewer](../microsoft.ui.xaml.controls/scrollviewer.md)s that contain the element. The [HorizontalOffset](../microsoft.ui.xaml.controls/scrollviewer_horizontaloffset.md) and [VerticalOffset](../microsoft.ui.xaml.controls/scrollviewer_verticaloffset.md) of those ScrollViewers may not be updated immediately upon returning from the call. However, in the process of servicing the request a ScrollViewer's [ViewChanging](../microsoft.ui.xaml.controls/scrollviewer_viewchanging.md) and [ViewChanged](../microsoft.ui.xaml.controls/scrollviewer_viewchanged.md) events will fire.

If you use the signature that does not specify any options, then the entire element size (its [RenderSize](uielement_rendersize.md)) will be made visible and any changes to the viewports will be animated.

The `StartBringIntoView` method does not transmit any information about success or failure. Reasons for failure can include the element settings, such as [Visibility](uielement_visibility.md) being some value other than `Visible`.

## -see-also

[BringIntoViewRequested](uielement_bringintoviewrequested.md)

## -examples
