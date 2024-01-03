---
-api-id: T:Microsoft.UI.Xaml.Controls.GridViewHeaderItem
-api-type: winrt class
---

<!-- Class syntax.
public class GridViewHeaderItem : Windows.UI.Xaml.Controls.ListViewBaseHeaderItem, Windows.UI.Xaml.Controls.IGridViewHeaderItem
-->

# Microsoft.UI.Xaml.Controls.GridViewHeaderItem

## -description
Represents items in the header for grouped data inside a [GridView](gridview.md).

## -remarks
GridViewHeaderItem is a control that's created by the system and added to the visual tree when the data templates for a grouped [ListView](listview.md) are realized. Specifically, it's created when realizing the [GroupStyle.HeaderTemplate](groupstyle_headertemplate.md). You don't typically define elements for GridViewHeaderItem in XAML. There's a default template for GridViewHeaderItem as part of the built-in templates. The main app scenario for the GridViewHeaderItem class is to copy and replace the default style and template with a style of your own, which also implicitly targets GridViewHeaderItem.

There's a dedicated automation peer class for GridViewHeaderItem, [GridViewHeaderItemAutomationPeer](../microsoft.ui.xaml.automation.peers/gridviewheaderitemautomationpeer.md). This is because after the [GridView](gridview.md) is realized, all the created item parts need automation representation, so that Microsoft UI Automation can report them in the tree it provides for assistive technology and other Microsoft UI Automation clients.

If you use the [GroupStyle.HeaderContainerStyle](groupstyle_headercontainerstyle.md) property, the [Style](../microsoft.ui.xaml/style.md) it contains must have a [TargetType](../microsoft.ui.xaml/style_targettype.md) value of either [ListViewHeaderItem](listviewheaderitem.md) or GridViewHeaderItem.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -examples

## -see-also
[ListViewBaseHeaderItem](listviewbaseheaderitem.md), [GridView](gridview.md), [GroupStyle property](itemscontrol_groupstyle.md), [GroupStyle.HeaderTemplate](groupstyle_headertemplate.md)
