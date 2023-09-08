---
-api-id: T:Microsoft.UI.Xaml.Controls.ScrollingChainMode
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.ScrollingChainMode

<!--
public enum ScrollingChainMode
-->

## -description

Defines constants that specify how scroll- and zoom-chaining is handled by the `ScrollView` control.

## -enum-fields

### -field Auto: 0

The `ScrollView` chains to the closest scrollable/zoomable outer component, if any.

### -field Always: 1

The `ScrollView` acts as if chaining occurred even when no scrollable/zoomable outer component is present.

### -field Never: 2

The `ScrollView` ignores any scrollable/zoomable outer component that is present and no chaining occurs.

## -remarks

## -see-also

[ScrollView.HorizontalScrollChainMode](scrollview_horizontalscrollchainmode.md), [ScrollView.VerticalScrollChainMode](scrollview_verticalscrollchainmode.md), [ScrollView.ZoomChainMode](scrollview_zoomchainmode.md)

## -examples
