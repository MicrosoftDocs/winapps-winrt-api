---
-api-id: E:Microsoft.UI.Xaml.Controls.LinedFlowLayout.ItemsInfoRequested
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.LinedFlowLayout.ItemsInfoRequested

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.LinedFlowLayout,Microsoft.UI.Xaml.Controls.LinedFlowLayoutItemsInfoRequestedEventArgs> ItemsInfoRequested;
-->

## -description

Occurs when the `LinedFlowLayout` needs sizing information for items in and around the current scrolling viewport.

## -remarks

This event is raised with the [LinedFlowLayoutItemsInfoRequestedEventArgs](linedflowlayoutitemsinforequestedeventargs.md) argument, which provides details about the requested item sizing information.

You can provide the requested information to improve the responsiveness of the user interface. Handling of this event is optional and influences the layout algorithm employed by the [LinedFlowLayout](linedflowlayout.md) in the following ways.

**Not handling this event, or not providing sizing information for the requested items range:**

- A contiguous range of items is created. By default, those items fill up a buffer of up to 5 scrolling viewports, centered around the currently visible viewport. All other items are virtualized.
- Only that range of items is laid out. Items outside the range (virtualized items) do not influence the layout.
- Scrolling through the items (and more generally, each layout pass) triggers the `ItemsInfoRequested` event in an attempt to gather sizing information again.
- Recently created items are used to compute an average items-per-line value. That number determines how many lines are needed to display the entire collection, and the approximate location of each item.
- A width change of the hosting `ItemsRepeater`/`ItemsView` may or may not trigger an average items-per-line change. The greater that width change, the greater the chance of an average items-per-line change.
- A complete reflow of the items is performed when that average items-per-line evaluates to a new value for any reason.
- The number of items created and laid out in the buffer (up to 5 scrolling viewports) is strictly enforced by the computed average items-per-line.

**Providing sizing information exactly for the requested items range:**

Results in the same characteristics as the first case, except:

- Only up to 3 scrolling viewports worth of items are created instead of 5. Fewer created items translates into improved performance. Thus it is recommended to handle the `ItemsInfoRequested` event and provide sizing information for at least the requested range, which covers up to 5 scrolling viewports.
- The average items-per-line is computed based on the provided sizing information and not the created items' desired size.
- Scrolling through the items triggers the `ItemsInfoRequested` event in order to gather sizing information for the buffer (up to 5 scrolling viewports) centered around the new visible viewport.

**Providing sizing information for a greater items range than the requested one:**

Results in the same characteristics as the first case, except:

- Because sizing information was provided for a superset of the requested items range, scrolling does not necessarily raise the `ItemsInfoRequested` event. As long as the 5 scrolling viewports centered around the visible viewport are within the known sizes, the `ItemsInfoRequested` does not need to be raised.
- The larger the items range of sizing information provided by the `ItemsInfoRequested` event handler, the fewer its occurrences. This improves the overall performance.

**Providing sizing information for the entire items collection:**

This case results in significantly different characteristics from the 3 previous cases:

- Up to 3 scrolling viewports worth of items are created.
- Bounding rectangles are evaluated for all items, whether created or virtualized. This takes full advantage of the sizing information provided for the entire collection.
- There is no enforcement about how many items are laid out around the visible viewport. Not being constrained to fulfill an average items-per-line may result in less item cropping. The total number of lines is also not enforced by the average items-per-line.
- Scrolling through the items never triggers the `ItemsInfoRequested` event because no additional sizing information needs to be retrieved. However, the event can be triggered by a call to the `InvalidateItemsInfo` method.
- A width change of the hosting `ItemsRepeater`/`ItemsView` always triggers a reflow of the items.

## -see-also

## -examples


