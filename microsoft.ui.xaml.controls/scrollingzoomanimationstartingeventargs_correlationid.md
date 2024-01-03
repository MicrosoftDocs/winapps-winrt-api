---
-api-id: P:Microsoft.UI.Xaml.Controls.ScrollingZoomAnimationStartingEventArgs.CorrelationId
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.ScrollingZoomAnimationStartingEventArgs.CorrelationId

<!--
public int CorrelationId { get; }
-->

## -description

Gets the correlation ID associated with the animated zoom factor change, previously returned by `ZoomTo` or `ZoomBy`.

## -property-value

The correlation ID associated with the animated zoom factor change.

## -remarks

Each programmatic scroll or zoom change is associated with a particular correlation ID number. That number is provided when requesting a view change with `ScrollTo`, `ScrollBy`, `AddScrollVelocity`, `ZoomTo`, `ZoomBy` or `AddZoomVelocity` as a return value. A correlation ID is also provided in the [BringingIntoView](scrollview_bringingintoview.md) event raised at the beginning of a bring-into-view request participation. This marks the beginning of a correlation ID's lifetime.

That same number is then exposed in subsequent events like [ScrollAnimationStarting](scrollview_scrollanimationstarting.md) and [ScrollCompleted](scrollview_scrollcompleted.md), or [ZoomAnimationStarting](scrollview_zoomanimationstarting.md) and [ZoomCompleted](scrollview_zoomcompleted.md). This lets you match events with their triggering method call or request.

The lifetime of a correlation ID always ends in a completion event: [ScrollCompleted](scrollview_scrollcompleted.md) or [ZoomCompleted](scrollview_zoomcompleted.md).

The lifetimes of correlation IDs can overlap. For example, two back-to-back `ZoomTo` calls will generate two correlation IDs with overlapping lifetimes.

When a new view change is requested while an old one is still in progress, the old one is cancelled. That cancellation triggers a `ScrollCompleted` or `ZoomCompleted` event with the old `CorrelationId`.

## -see-also

## -examples


