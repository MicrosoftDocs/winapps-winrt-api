---
-api-id: P:Microsoft.UI.Xaml.Controls.TabView.CloseButtonOverlayMode
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.TabView.CloseButtonOverlayMode

<!--
public Microsoft.UI.Xaml.Controls.TabViewCloseButtonOverlayMode CloseButtonOverlayMode { get; set; }
-->

## -description

Gets or sets a value that indicates the behavior of the close button within tabs.

## -property-value

A value of the enumeration that describes the behavior of the close button within tabs. The default is `Auto`.

## -remarks

For more info, design guidance, and code examples, see [Tab view](/windows/apps/design/controls/tab-view).

Selected TabViewItems that are closable always show their close button regardless of the value of the TabViewCloseButtonOverlayMode property. The TabViewCloseButtonOverlayMode only effects the behavior of the unselected TabViewItems.

If the CloseButtonOverlayMode is set to `Always`, unselected tabs always show the close button if they are closable.

If the CloseButtonOverlayMode is set to `OnPointerOver`, unselected tabs show the close button when the tab is closable and the user has their pointer over the tab.

## -see-also

## -examples


