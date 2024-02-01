---
-api-id: T:Microsoft.UI.Xaml.Controls.StackPanel
-api-type: winrt class
---

<!-- Class syntax.
public class StackPanel : Windows.UI.Xaml.Controls.Panel, Windows.UI.Xaml.Controls.IInsertionPanel, Windows.UI.Xaml.Controls.IStackPanel, Windows.UI.Xaml.Controls.IStackPanel2, Windows.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo
-->

# Microsoft.UI.Xaml.Controls.StackPanel

## -description
Arranges child elements into a single line that can be oriented horizontally or vertically.

## -xaml-syntax
```xaml
<StackPanel .../>
-or-
<StackPanel ...>
  oneOrMoreChildren
</StackPanel>

```


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/apps/design/layout/layout-panels#stackpanel).

StackPanel is a layout panel that arranges child elements into a single line that can be oriented horizontally or vertically.

<img alt="Stack panel layout control" src="images/controls/StackPanel.png" />

By default, StackPanel stacks items vertically from top to bottom in the order they are declared. You can set the [Orientation](stackpanel_orientation.md) property to **Horizontal** to stack items from left to right.

You can insert items into a StackPanel at a specific location using the [InsertAt](uielementcollection_insertat_1200105662.md) method in code-behind.

### Border properties

StackPanel defines border properties that let you draw a border around the StackPanel without using an additional [Border](border.md) element. The properties are [StackPanel.BorderBrush](stackpanel_borderbrush.md), [StackPanel.BorderThickness](stackpanel_borderthickness.md), [StackPanel.CornerRadius](stackpanel_cornerradius.md), and [StackPanel.Padding](stackpanel_padding.md).

```xaml
<StackPanel BorderBrush="Red" BorderThickness="2" CornerRadius="10" Padding="12">
    <TextBlock Text="Hello World!"/>
</StackPanel>
```

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/apps/design/layout/layout-panels#stackpanel).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the StackPanel in action](winui3gallery:/item/StackPanel)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

The following example shows how to create a StackPanel of items.

[!code-xaml[LayoutOvwStackPanel_1](../microsoft.ui.xaml/code/layout_ovw_all/CSharp/MainPage.xaml#SnippetLayoutOvwStackPanel_1)]

[!code-xaml[02](../microsoft.ui.xaml.controls/code/StackPanel1/csharp/Page.xaml#Snippet02)]

[!code-csharp[01](../microsoft.ui.xaml.controls/code/StackPanel1/csharp/Page.xaml.cs#Snippet01)]

## -see-also
[Panel](panel.md), [IScrollSnapPointsInfo](../microsoft.ui.xaml.controls.primitives/iscrollsnappointsinfo.md), [Define layouts](/windows/uwp/layout/layouts-with-xaml), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding), [Canvas](canvas.md), [Grid](grid.md), [ItemsStackPanel](itemsstackpanel.md), [VariableSizedWrapGrid](variablesizedwrapgrid.md), [VirtualizingStackPanel](virtualizingstackpanel.md), [Controls list](/windows/apps/design/controls/)
