---
-api-id: T:Microsoft.UI.Xaml.Controls.ScrollingAnchorRequestedEventArgs
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.ScrollingAnchorRequestedEventArgs

<!--
public sealed class ScrollingAnchorRequestedEventArgs
-->

## -description

Provides data for the `ScrollView.AnchorRequested` event.

## -remarks

These event args are used by the [ScrollView.AnchorRequested](scrollview_anchorrequested.md) event, which is raised when the `ScrollView` is selecting an element to be anchored. Handle this event to customize that selection.

If the event handler leaves the [AnchorElement](scrollinganchorrequestedeventargs_anchorelement.md) as `null`, then the [ScrollView](scrollview.md) selects an anchor from among the [AnchorCandidates](scrollinganchorrequestedeventargs_anchorcandidates.md) collection.

The `AnchorCandidates` collection is initialized with the elements that are registered as anchor candidates. That initial collection of candidates is populated with `ScrollPresenter` children that have their the `UIElement.CanBeScrollAnchor` property set to `true`, and with elements explicitly registered with the `ScrollView.RegisterAnchorCandidate` method.

You can use `AnchorRequested` event handler to modify that collection to adjust the list of candidates for the anchor request. After it is executed, the `ScrollView` uses its [HorizontalAnchorRatio](scrollview_horizontalanchorratio.md) and [VerticalAnchorRatio](scrollview_verticalanchorratio.md) properties to select an anchor among the final `AnchorCandidates` collection.

Alternatively, you can use the `AnchorRequested` event handler to set the [AnchorElement](scrollinganchorrequestedeventargs_anchorelement.md) property, initialized to `null`, to force the use of a particular element as the anchor. In that case, the `AnchorCandidates` collection is ignored and the `ScrollView`'s selection process is skipped entirely.

## -see-also

[ScrollView.AnchorRequested](scrollview_anchorrequested.md)

## -examples
