---
-api-id: T:Microsoft.UI.Xaml.Controls.GridView
-api-type: winrt class
---

<!-- Class syntax.
public class GridView : Windows.UI.Xaml.Controls.ListViewBase, Windows.UI.Xaml.Controls.IGridView
-->

# Microsoft.UI.Xaml.Controls.GridView

## -description

Represents a control that displays data items in rows and columns.

## -xaml-syntax

```xaml
<GridView .../>
-or-
<GridView ...>
  oneOrMoreItems
</GridView>
```

## -remarks

Use a **GridView** to display a collection of items in rows and columns that can scroll vertically. Data is stacked horizontally until it fills the columns, then continues with the next row. It's often used when you need to show a rich visualization of each item that takes more space, such as a photo gallery.

:::image type="content" source="images/controls/grid-view.png" alt-text="Grid view control":::

GridView is an [ItemsControl](itemscontrol.md), so it can contain a collection of items of any type. To populate the view, add items to the [Items](itemscontrol_items.md) collection, or set the [ItemsSource](itemscontrol_itemssource.md) property to a data source.

If you use the GridView to display large sets of data, see [Optimize ListView and GridView](/windows/uwp/debug-test-perf/optimize-gridview-and-listview) for tips to maintain a smooth and responsive user experience.

> [!NOTE]
> When you set the [Padding](control_padding.md) property on a GridView control, the value for [Right](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.thickness.right) padding is ignored; only the values for `Left`, `Top`, and `Bottom` padding are applied.

### Data template

By default, a data item is displayed in the GridView as the string representation of the data object it's bound to. To specify exactly how items in the GridView are displayed, you create a [DataTemplate](../microsoft.ui.xaml/datatemplate.md) to define the layout of controls used to display an individual item. The controls in the layout can be bound to properties of a data object, or have content defined inline. You assign the [DataTemplate](../microsoft.ui.xaml/datatemplate.md) to the [ItemTemplate](itemscontrol_itemtemplate.md) property of the GridView. For common templates you can use in your app, see [Item templates for GridView](/windows/apps/design/controls/item-templates-gridview).

If you populate the GridView by setting the [ItemsSource](itemscontrol_itemssource.md) property, the [ItemTemplate](itemscontrol_itemtemplate.md) is applied to every item. If you populate the [Items](itemscontrol_items.md) collection directly, the [ItemTemplate](itemscontrol_itemtemplate.md) is applied only if the item is not a [GridViewItem](gridviewitem.md). In this example, the template is applied to the first and last items, but not the second item.

```xaml
<GridView>
    <GridView.ItemTemplate>
        <DataTemplate>
            <Grid Background="LightGray"
                  Height="100" Width="100">
                <FontIcon Glyph="&#xE76E;" />
                <TextBlock Text="{Binding}"
                           HorizontalAlignment="Center"
                           FontSize="24" Foreground="Green"/>

            </Grid>
        </DataTemplate>
    </GridView.ItemTemplate>
    <GridView.Items>
        <x:String>One</x:String>
        <GridViewItem>Two</GridViewItem>
        <x:String>Three</x:String>
    </GridView.Items>
</GridView>

```

:::image type="content" source="images/grid-view-item.png" alt-text="Grid view control with the first and last items showing green text and an icon, but the second item showing only plain text with no template applied.":::

### Item selection

By default, a user can select a single item in a GridView. You can set the [SelectionMode](listviewbase_selectionmode.md) property to a [ListViewSelectionMode](listviewselectionmode.md) enumeration value to allow multi-selection or to disable selection. You can also change the GridView interaction mode to make items respond to a user click like a button instead of being selected.

This table shows the ways a user can interact with a GridView, and how you can respond to the interaction.

| To enable this interaction: | Use these settings: | Handle this event: | Use this property to get the selected item: |
| - | - | - | - |
| No interaction | [SelectionMode](listviewbase_selectionmode.md) = [None](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False** | N/A | N/A |
| Single selection | [SelectionMode](listviewbase_selectionmode.md) = [Single](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False** | [SelectionChanged](../microsoft.ui.xaml.controls.primitives/selector_selectionchanged.md) | [SelectedItem](../microsoft.ui.xaml.controls.primitives/selector_selecteditem.md), [SelectedIndex](../microsoft.ui.xaml.controls.primitives/selector_selectedindex.md) |
| Contiguous multi-selection | [SelectionMode](listviewbase_selectionmode.md) = [Multiple](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False** | [SelectionChanged](../microsoft.ui.xaml.controls.primitives/selector_selectionchanged.md) | [SelectedItems](listviewbase_selecteditems.md) |
| Non-contiguous multi-selection | [SelectionMode](listviewbase_selectionmode.md) = [Extended](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False** | [SelectionChanged](../microsoft.ui.xaml.controls.primitives/selector_selectionchanged.md) | [SelectedItems](listviewbase_selecteditems.md) |
| Click | [SelectionMode](listviewbase_selectionmode.md) = [None](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **True** | [ItemClick](listviewbase_itemclick.md) | N/A |


#### Selection behavior and CollectionViewSource

List controls that derive from [Selector](../microsoft.ui.xaml.controls.primitives/selector.md) have a default selection behavior that depends on what the items source is (the type that's used for [ItemsSource](itemscontrol_itemssource.md)). If the items source is a [CollectionViewSource](../microsoft.ui.xaml.data/collectionviewsource.md) instance, then the behavior in the selection control is that the selection will default to the current item. When the list is first displayed, the selection defaults to the first item as current item. If you don't want the first item to be selected in this case, set [IsSynchronizedWithCurrentItem](../microsoft.ui.xaml.controls.primitives/selector_issynchronizedwithcurrentitem.md) to `false` in the GridView.


### Data virtualization

GridView supports data virtualization to improve performance with large data sets. Random access virtualization is supported when the data source implements the appropriate interfaces, which vary depending on the programming language:

+ C++ apps should implement [IObservableVector](/uwp/api/windows.foundation.collections.iobservablevector-1).
+ C# apps should implement [INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true) and [System.Collections.IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) (not [IList&lt;T>](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)). Virtualization requires both of these interfaces.
 Incremental loading virtualization is supported when the data source implements the [ISupportIncrementalLoading](../microsoft.ui.xaml.data/isupportincrementalloading.md) interface. When incremental loading is supported, you can use these members to control data loading: [DataFetchSize](listviewbase_datafetchsize.md), [IncrementalLoadingThreshold](listviewbase_incrementalloadingthreshold.md), [IncrementalLoadingTrigger](listviewbase_incrementalloadingtrigger.md), [LoadMoreItemsAsync](listviewbase_loadmoreitemsasync_1264491126.md).

### Semantic zoom

GridView implements the [ISemanticZoomInformation](isemanticzoominformation.md) interface, so it can be used as a view in a [SemanticZoom](semanticzoom.md) control. When it's used in a [SemanticZoom](semanticzoom.md) control, always set the [ScrollViewer.IsHorizontalScrollChainingEnabled](scrollviewer_ishorizontalscrollchainingenabled.md) attached property to **false** on the [ScrollViewer](scrollviewer.md) that's in the GridView's control template, like this: `<GridView ScrollViewer.IsHorizontalScrollChainingEnabled="False">`.

These members have an effect only when the GridView is hosted in a [SemanticZoom](semanticzoom.md) control: [IsActiveView](listviewbase_isactiveview.md), [IsZoomedInView](listviewbase_iszoomedinview.md), [SemanticZoomOwner](listviewbase_semanticzoomowner.md), [CompleteViewChange](listviewbase_completeviewchange_1917507883.md), [CompleteViewChangeFrom](listviewbase_completeviewchangefrom_996733196.md), [CompleteViewChangeTo](listviewbase_completeviewchangeto_400609881.md), [InitializeViewChange](listviewbase_initializeviewchange_1165335344.md), [MakeVisible](listviewbase_makevisible_497090924.md), [StartViewChangeFrom](listviewbase_startviewchangefrom_1194830824.md), [StartViewChangeTo](listviewbase_startviewchangeto_1278247285.md).

### Animations

The default template for GridView includes existing transition animations. Specifically, the default [ItemContainerTransitions](itemscontrol_itemcontainertransitions.md) value already contains values for [AddDeleteThemeTransition](../microsoft.ui.xaml.media.animation/adddeletethemetransition.md), [ContentThemeTransition](../microsoft.ui.xaml.media.animation/contentthemetransition.md), [ReorderThemeTransition](../microsoft.ui.xaml.media.animation/reorderthemetransition.md) and [EntranceThemeTransition](../microsoft.ui.xaml.media.animation/entrancethemetransition.md) (with `IsStaggeringEnabled="False"`). If you are setting a new value for [ItemContainerTransitions](itemscontrol_itemcontainertransitions.md) on GridView, consider reproducing these same theme animations as a starting point. If you are setting the property yourself, those defaults get overwritten unless you include them again in your definition.

### Input

If you need to handle pointer events for a [UIElement](../microsoft.ui.xaml/uielement.md) in a scrollable view (such as a ScrollViewer), you must explicitly disable support for manipulation events on the element in the view by calling [UIElement.CancelDirectManipulation](../microsoft.ui.xaml/uielement_canceldirectmanipulations_1164631120.md). To re-enable manipulation events in the view, call [UIElement.TryStartDirectManipulation](../microsoft.ui.xaml/uielement_trystartdirectmanipulation_2108245083.md).

The [PointerWheelChanged](../microsoft.ui.xaml/uielement_pointerwheelchanged.md) event does not bubble up from a GridView. This means that a control that has a GridView inside of it does not receive mouse wheel change messages if the pointer is over the GridView. For example, if you put a GridView inside of a [ScrollViewer](scrollviewer.md), you can't scroll the [ScrollViewer](scrollviewer.md) with the mouse wheel when the pointer is over the GridView.

By default, instead of performing selection, an active pen scrolls/pans a list (like touch, touchpad, and passive pen). If your app should use an active pen for text selection, you can override the pen scrolling behavior. See the Pen interaction section of the [Scroll​Viewer](scrollviewer.md) class reference for details.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [List view and grid view](/windows/apps/design/controls/listview-and-gridview).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the GridView in action](winui3gallery://item/GridView)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://apps.microsoft.com/detail/9p3jfpwwdzrc) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

## -see-also

[List view and grid view](/windows/apps/design/controls/listview-and-gridview), [ListViewBase](listviewbase.md), [ISemanticZoomInformation](isemanticzoominformation.md), [Item templates for GridView](/windows/apps/design/controls/item-templates-gridview), [Data binding overview](/windows/apps/develop/data-binding/data-binding-overview), [ListView](listview.md), [SemanticZoom](semanticzoom.md)
