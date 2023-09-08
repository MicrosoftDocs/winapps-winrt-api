---
-api-id: P:Microsoft.UI.Xaml.Controls.ScrollView.ContentOrientation
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.ScrollView.ContentOrientation

<!--
public Microsoft.UI.Xaml.Controls.ScrollingContentOrientation ContentOrientation { get; set; }
-->

## -description

Gets or sets a value that indicates whether the content prefers to scroll horizontally or vertically.

## -property-value

The preferred scroll direction of the content. The default is `Vertical`.

## -remarks

The `ContentOrientation` property affects the `ScrollPresenter`'s `MeasureOverride` behavior:

- When the `Vertical` orientation is applied, the available width of the `ScrollPresenter.Content` is set to the available width of the `ScrollPresenter`. Otherwise, the available width of the `ScrollPresenter.Content` is infinity.
- When the `Horizontal` orientation is applied, the available height of the `ScrollPresenter.Content` is set to the available height of the `ScrollPresenter`. Otherwise, the available height of the `ScrollPresenter.Content` is infinity.

## -see-also

## -examples


