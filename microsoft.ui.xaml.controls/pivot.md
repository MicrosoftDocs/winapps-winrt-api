---
-api-id: T:Microsoft.UI.Xaml.Controls.Pivot
-api-type: winrt class
---

<!-- Class syntax.
public class Pivot : Windows.UI.Xaml.Controls.ItemsControl, Windows.UI.Xaml.Controls.IPivot, Windows.UI.Xaml.Controls.IPivot2, Windows.UI.Xaml.Controls.IPivot3
-->

# Microsoft.UI.Xaml.Controls.Pivot

## -description

Represents a control that provides quick navigation of views within an app.

## -xaml-syntax

```xaml

<Pivot .../>
-or-
<Pivot ...>
  oneOrMorePivotItems
</Pivot>

```

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Pivot](/windows/apps/design/controls/pivot).

> [!NOTE]
>The Pivot control is not recommended for [Windows 11 design patterns](/windows/apps/design/basics/app-silhouette). When designing for Windows 11, consider using a [NavigationView](/windows/apps/design/controls/navigationview) or [TabView](/windows/apps/design/controls/tab-view) control instead of a Pivot control. See the [Use NavigationView instead of Pivot](/windows/apps/design/controls/pivot#use-navigationview-instead-of-pivot) section of the Pivot article for an example.

Use a Pivot to present groups of content that a user can swipe through. You typically use a Pivot as the top level control on a page.

Pivot is an [ItemsControl](itemscontrol.md), so it can contain a collection of items of any type. Any item you add to the Pivot that is not explicitly a [PivotItem](pivotitem.md) is implicitly wrapped in a [PivotItem](pivotitem.md). Because a Pivot is often used to navigate between pages of content, it's common to populate the [Items](itemscontrol_items.md) collection directly with XAML UI elements. Or, you can set the [ItemsSource](itemscontrol_itemssource.md) property to a data source. Items bound in the [ItemsSource](itemscontrol_itemssource.md) can be of any type, but if they aren't explicitly [PivotItem](pivotitem.md) s, you must define an [ItemTemplate](itemscontrol_itemtemplate.md) and [HeaderTemplate](pivot_headertemplate.md) to specify how the items are displayed.

<!--<note>You can define an <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.itemscontrol_itemtemplate">ItemTemplate</xref> whether <xref targtype="class_winrt" rid="w_ui_xaml_ctrl.pivot">Pivot</xref> is populated through the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.itemscontrol_items">Items</xref> or <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.itemscontrol_itemssource">ItemsSource</xref> property. If you populate the <xref targtype="class_winrt" rid="w_ui_xaml_ctrl.pivot">Pivot</xref> by setting the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.itemscontrol_itemssource">ItemsSource</xref> property, the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.itemscontrol_itemtemplate">ItemTemplate</xref> is applied to every item. If you populate the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.itemscontrol_items">Items</xref> collection directly, the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.itemscontrol_itemtemplate">ItemTemplate</xref> is applied only if the item is not a <xref targtype="class_winrt" rid="w_ui_xaml_ctrl.pivotitem">PivotItem</xref>.</note>-->

You can use the [SelectedItem](pivot_selecteditem.md) property to get or set the Pivot's active item. Use the [SelectedIndex](pivot_selectedindex.md) property to get or set the index of the active item.

You can use the [LeftHeader](pivot_leftheader.md) and [RightHeader](pivot_rightheader.md) properties to add other controls to the Pivot header.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

### XAML attached properties

Pivot is the host service class for a [XAML attached property](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../microsoft.ui.xaml/dependencyobject_getvalue_229640130.md) or [SetValue](../microsoft.ui.xaml/dependencyobject_setvalue_1212521140.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| SlideInAnimationGroup | Gets or sets the slide-in animation group of a child element in a Pivot container.<ul><li>Type: [PivotSlideInAnimationGroup](pivotslideinanimationgroup.md)</li><li>Identifier field: <a href="/uwp/api/windows.ui.xaml.controls.pivot.slideinanimationgroupproperty">SlideInAnimationGroupProperty</a></li><li>Accessor methods: <a href="/uwp/api/windows.ui.xaml.controls.pivot.getslideinanimationgroup">GetSlideInAnimationGroup</a>, <a href="/uwp/api/windows.ui.xaml.controls.pivot.setslideinanimationgroup">SetSlideInAnimationGroup</a></li></ul> |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Pivot](/windows/apps/design/controls/pivot).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the Pivot in action](winui3gallery:/item/Pivot)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)


For more examples, see the [Pivot sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlPivot).

This example shows a Pivot with 3 items. It also has a [RightHeader](pivot_rightheader.md) with forward and back buttons that use [SelectedIndex](pivot_selectedindex.md) to let a user navigate through the items.

```xaml
<Pivot x:Name="rootPivot" Title="PIVOT TITLE">
    <Pivot.RightHeader>
        <CommandBar ClosedDisplayMode="Compact">
            <AppBarButton Icon="Back" Label="Previous" Click="BackButton_Click"/>
            <AppBarButton Icon="Forward" Label="Next" Click="NextButton_Click"/>
        </CommandBar>
    </Pivot.RightHeader>
    <PivotItem Header="Pivot Item 1">
        <!--Pivot content goes here-->
        <TextBlock Text="Content of pivot item 1."/>
    </PivotItem>
    <PivotItem Header="Pivot Item 2">
        <!--Pivot content goes here-->
        <TextBlock Text="Content of pivot item 2."/>
    </PivotItem>
    <PivotItem Header="Pivot Item 3">
        <!--Pivot content goes here-->
        <TextBlock Text="Content of pivot item 3."/>
    </PivotItem>
</Pivot>
```

```csharp
private void BackButton_Click(object sender, RoutedEventArgs e)
{
    if (rootPivot.SelectedIndex > 0)
    {
        // If not at the first item, go back to the previous one.
        rootPivot.SelectedIndex -= 1;
    }
    else
    {
        // The first PivotItem is selected, so loop around to the last item.
        rootPivot.SelectedIndex = rootPivot.Items.Count-1;
    }
}

private void NextButton_Click(object sender, RoutedEventArgs e)
{
    if (rootPivot.SelectedIndex < rootPivot.Items.Count-1)
    {
        // If not at the last item, go to the next one.
        rootPivot.SelectedIndex += 1;
    }
    else
    {
        // The last PivotItem is selected, so loop around to the first item.
        rootPivot.SelectedIndex = 0;
    }
}
```

## -see-also

[Pivot overview](/windows/apps/design/controls/pivot)
