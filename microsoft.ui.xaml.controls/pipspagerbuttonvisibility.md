---
-api-id: T:Microsoft.UI.Xaml.Controls.PipsPagerButtonVisibility
-api-type: winrt enum
---

# Microsoft.UI.Xaml.Controls.PipsPagerButtonVisibility

<!--
public enum PipsPagerButtonVisibility
-->

## -description

Defines constants that specify how the navigation buttons of the [PipsPager](pipspager.md) are displayed.

## -enum-fields

### -field Visible: 0

The navigation button is visible and enabled, but hidden when content is at one or the other extent. For example, the Previous button is hidden when the current page is the first page, and the Next button is hidden when the current page is the last page.

### -field VisibleOnPointerOver: 1

The button behavior is the same as *Visible* except the button is visible only when the pointer cursor is over the pager, or keyboard focus is inside the pager or on a navigation button.

### -field Collapsed: 2

The button is not visible and does not take up layout space.

## -remarks

## -see-also

[PipsPager](pipspager.md), [PipsPager.PreviousButtonVisibility](pipspager_previousbuttonvisibility.md), [PipsPager.NextButtonVisbility](pipspager_nextbuttonvisibility.md), [PipsPager overview](/windows/apps/design/controls/pipspager)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [PipsPager](/windows/apps/design/controls/pipspager).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the PipsPager in action](winui3gallery:/item/PipsPager)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).
