---
-api-id: T:Microsoft.UI.Xaml.Controls.TabViewCloseButtonOverlayMode
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.TabViewCloseButtonOverlayMode

<!--
public enum TabViewCloseButtonOverlayMode
-->

## -description

Defines constants that describe the behavior of the close button contained within each [TabViewItem](tabviewitem.md).

## -enum-fields

### -field Always

The selected tab always shows the close button if it is closable. Unselected tabs always show the close button if they are closable.

### -field Auto

Behavior is defined by the framework. Default.

This value maps to **Always**.

### -field OnPointerOver

The selected tab always shows the close button if it is closable. Unselected tabs show the close button when the tab is closable and the user has their pointer over the tab.

## -remarks

Selected TabViewItems that are closable always show their close button regardless of the value of the TabViewCloseButtonOverlayMode property. The TabViewCloseButtonOverlayMode only effects the behavior of the unselected TabViewItems.

## -see-also

[TabView](tabview.md), [TabViewItem](tabviewitem.md), [Guidelines for TabView](/windows/apps/design/controls/tab-view)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [TabView](/windows/apps/design/controls/tab-view).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the TabView in action](winui3gallery:/item/TabView)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).
