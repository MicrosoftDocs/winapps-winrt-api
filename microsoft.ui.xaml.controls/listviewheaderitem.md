---
-api-id: T:Microsoft.UI.Xaml.Controls.ListViewHeaderItem
-api-type: winrt class
---

<!-- Class syntax.
public class ListViewHeaderItem : Windows.UI.Xaml.Controls.ListViewBaseHeaderItem, Windows.UI.Xaml.Controls.IListViewHeaderItem
-->

# Microsoft.UI.Xaml.Controls.ListViewHeaderItem

## -description
Represents items in the header for grouped data inside a [ListView](listview.md).

## -remarks
ListViewHeaderItem is a control that's created by the system and added to the visual tree when the data templates for a grouped [ListView](listview.md) are realized. Specifically, it's created when realizing the [GroupStyle.HeaderTemplate](groupstyle_headertemplate.md). You don't typically define elements for ListViewHeaderItem in XAML. There's a default template for ListViewHeaderItem as part of the built-in templates. The main app scenario for the ListViewHeaderItem class is to copy and replace the default style and template with a style of your own, which also implicitly targets ListViewHeaderItem.

There's a dedicated automation peer class for ListViewHeaderItem, [ListViewHeaderItemAutomationPeer](../microsoft.ui.xaml.automation.peers/listviewheaderitemautomationpeer.md). This is because after the [ListView](listview.md) is realized, all the created item parts need automation representation, so that Microsoft UI Automation can report them in the tree it provides for assistive technology and other Microsoft UI Automation clients.

If you use the [GroupStyle.HeaderContainerStyle](groupstyle_headercontainerstyle.md) property, the [Style](../microsoft.ui.xaml/style.md) it contains must have a [TargetType](../microsoft.ui.xaml/style_targettype.md) value of either ListViewHeaderItem or [GridViewHeaderItem](gridviewheaderitem.md).

## -examples

## -see-also
[ListViewBaseHeaderItem](listviewbaseheaderitem.md), [ListView](listview.md), [GroupStyle property](itemscontrol_groupstyle.md), [GroupStyle.HeaderTemplate](groupstyle_headertemplate.md)
