---
-api-id: T:Microsoft.UI.Xaml.Controls.ListView
-api-type: winrt class
---

<!-- Class syntax.
public class ListView : Windows.UI.Xaml.Controls.ListViewBase, Windows.UI.Xaml.Controls.IListView
-->

# Microsoft.UI.Xaml.Controls.ListView

## -description

Represents a control that displays data items in a vertical stack.

## -xaml-syntax

```xaml
<ListView .../>
-or-
<ListView ...>
  oneOrMoreItems
</ListView>
```

## -remarks

Use a ListView to display a collection of items stacked vertically or horizontally (see [List view and grid view](/windows/apps/design/controls/listview-and-gridview) for more info). To display a collection in rows and columns, use a [GridView](gridview.md).

:::image type="content" source="images/controls/list-view.png" alt-text="List view control":::

ListView is an [ItemsControl](itemscontrol.md), so it can contain a collection of items of any type. To populate the view, add items to the [Items](itemscontrol_items.md) collection, or set the [ItemsSource](itemscontrol_itemssource.md) property to a data source.

If you use the ListView to display large sets of data, see [Optimize ListView and GridView](/windows/uwp/debug-test-perf/optimize-gridview-and-listview) for tips to maintain a smooth and responsive user experience.

### Data template

By default, a data item is displayed in the ListView as the string representation of the data object it's bound to. To specify exactly how items in the ListView are displayed, you create a [DataTemplate](../microsoft.ui.xaml/datatemplate.md) to define the layout of controls used to display an individual item. The controls in the layout can be bound to properties of a data object, or have content defined inline. You assign the [DataTemplate](../microsoft.ui.xaml/datatemplate.md) to the [ItemTemplate](itemscontrol_itemtemplate.md) property of the ListView. For common templates you can use in your app, see [Item templates for ListView](/windows/uwp/controls-and-patterns/item-templates-listview).

If you populate the ListView by setting the [ItemsSource](itemscontrol_itemssource.md) property, the [ItemTemplate](itemscontrol_itemtemplate.md) is applied to every item. If you populate the [Items](itemscontrol_items.md) collection directly, the [ItemTemplate](itemscontrol_itemtemplate.md) is applied only if the item is not a [ListViewItem](listviewitem.md). In this example, the template is applied to the first and last items, but not the second item.

```xaml
<ListView>
    <ListView.ItemTemplate>
        <DataTemplate>
            <StackPanel Orientation="Horizontal">
                <FontIcon Glyph="&#xE76E;" Margin="0,0,4,0"/>
                <TextBlock Text="{Binding}"
                           FontSize="24" Foreground="Green"/>
            </StackPanel>
        </DataTemplate>
    </ListView.ItemTemplate>
    <ListView.Items>
        <x:String>One</x:String>
        <ListViewItem>Two</ListViewItem>
        <x:String>Three</x:String>
    </ListView.Items>
</ListView>

```

:::image type="content" source="images/list-view-item.png" alt-text="Grid view control with the first and last items showing green text and an icon, but the second item showing only plain text with no template applied.":::

### Item selection


By default, a user can select a single item in a ListView. You can set the [SelectionMode](listviewbase_selectionmode.md) property to a [ListViewSelectionMode](listviewselectionmode.md) enumeration value to allow multi-selection or to disable selection. You can also change the ListView interaction mode to make items respond to a user click like a button instead of being selected.

This table shows the ways a user can interact with a ListView, and how you can respond to the interaction.

| To enable this interaction: | Use these settings: | Handle this event: | Use this property to get the selected item: |
| - | - | - | - |
| No interaction | [SelectionMode](listviewbase_selectionmode.md) = [None](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False** | N/A | N/A |
| Single selection | [SelectionMode](listviewbase_selectionmode.md) = [Single](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False** | [SelectionChanged](../microsoft.ui.xaml.controls.primitives/selector_selectionchanged.md) | [SelectedItem](../microsoft.ui.xaml.controls.primitives/selector_selecteditem.md), [SelectedIndex](../microsoft.ui.xaml.controls.primitives/selector_selectedindex.md) |
| Contiguous multi-selection | [SelectionMode](listviewbase_selectionmode.md) = [Multiple](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False** | [SelectionChanged](../microsoft.ui.xaml.controls.primitives/selector_selectionchanged.md) | [SelectedItems](listviewbase_selecteditems.md) |
| Non-contiguous multi-selection | [SelectionMode](listviewbase_selectionmode.md) = [Extended](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **False** | [SelectionChanged](../microsoft.ui.xaml.controls.primitives/selector_selectionchanged.md) | [SelectedItems](listviewbase_selecteditems.md) |
| Click | [SelectionMode](listviewbase_selectionmode.md) = [None](listviewselectionmode.md), [IsItemClickEnabled](listviewbase_isitemclickenabled.md) = **True** | [ItemClick](listviewbase_itemclick.md) | N/A |


#### Selection behavior and CollectionViewSource

List controls that derive from [Selector](../microsoft.ui.xaml.controls.primitives/selector.md) have a default selection behavior that depends on what the items source is (the type that's used for [ItemsSource](itemscontrol_itemssource.md)). If the items source is a [CollectionViewSource](../microsoft.ui.xaml.data/collectionviewsource.md) instance, then the behavior in the selection control is that the selection will default to the current item. When the list is first displayed, the selection defaults to the first item as current item. If you don't want the first item to be selected in this case, set [IsSynchronizedWithCurrentItem](../microsoft.ui.xaml.controls.primitives/selector_issynchronizedwithcurrentitem.md) to **false** in the ListView.

### Data virtualization

ListView supports data virtualization to improve performance with large data sets. Random access virtualization is supported when the data source implements the appropriate interfaces, which vary depending on the programming language:

+ C++ apps should implement [IObservableVector](/uwp/api/windows.foundation.collections.iobservablevector-1).
+ C# apps should implement [INotifyCollectionChanged](/dotnet/api/system.collections.specialized.inotifycollectionchanged?view=dotnet-uwp-10.0&preserve-view=true) and [System.Collections.IList](/dotnet/api/system.collections.ilist?view=dotnet-uwp-10.0&preserve-view=true) (not [IList&lt;T>](/dotnet/api/system.collections.generic.ilist-1?view=dotnet-uwp-10.0&preserve-view=true)). Virtualization requires both of these interfaces.
 Incremental loading virtualization is supported when the data source implements the [ISupportIncrementalLoading](../microsoft.ui.xaml.data/isupportincrementalloading.md) interface. When incremental loading is supported, you can use these members to control data loading: [DataFetchSize](listviewbase_datafetchsize.md), [IncrementalLoadingThreshold](listviewbase_incrementalloadingthreshold.md), [IncrementalLoadingTrigger](listviewbase_incrementalloadingtrigger.md), [LoadMoreItemsAsync](listviewbase_loadmoreitemsasync_1264491126.md).

### Semantic zoom

ListView implements the [ISemanticZoomInformation](isemanticzoominformation.md) interface, so it can be used as a view in a [SemanticZoom](semanticzoom.md) control. When it's used in a [SemanticZoom](semanticzoom.md) control, always set the [ScrollViewer.IsVerticalScrollChainingEnabled](scrollviewer_isverticalscrollchainingenabled.md) attached property to **false** on the [ScrollViewer](scrollviewer.md) that's in the ListView's control template, like this: `<ListView ScrollViewer.IsVerticalScrollChainingEnabled="False">`. These members have an effect only when the ListView is hosted in a [SemanticZoom](semanticzoom.md) control: [IsActiveView](listviewbase_isactiveview.md), [IsZoomedInView](listviewbase_iszoomedinview.md), [SemanticZoomOwner](listviewbase_semanticzoomowner.md), [CompleteViewChange](listviewbase_completeviewchange_1917507883.md), [CompleteViewChangeFrom](listviewbase_completeviewchangefrom_996733196.md), [CompleteViewChangeTo](listviewbase_completeviewchangeto_400609881.md), [InitializeViewChange](listviewbase_initializeviewchange_1165335344.md), [MakeVisible](listviewbase_makevisible_497090924.md), [StartViewChangeFrom](listviewbase_startviewchangefrom_1194830824.md), [StartViewChangeTo](listviewbase_startviewchangeto_1278247285.md).

### Input

If you need to handle pointer events for a [UIElement](../microsoft.ui.xaml/uielement.md) in a scrollable view (such as a ScrollViewer), you must explicitly disable support for manipulation events on the element in the view by calling [UIElement.CancelDirectManipulation](../microsoft.ui.xaml/uielement_canceldirectmanipulations_1164631120.md). To re-enable manipulation events in the view, call [UIElement.TryStartDirectManipulation](../microsoft.ui.xaml/uielement_trystartdirectmanipulation_2108245083.md).

The [PointerWheelChanged](../microsoft.ui.xaml/uielement_pointerwheelchanged.md) event does not bubble up from a ListView. This means that a control that has a ListView inside of it does not receive mouse wheel change messages if the pointer is over the ListView. For example, if you put a ListView inside of a [ScrollViewer](scrollviewer.md), you can't scroll the [ScrollViewer](scrollviewer.md) with the mouse wheel when the pointer is over the ListView.

By default, instead of performing selection, an active pen scrolls/pans a list (like touch, touchpad, and passive pen). If your app should use an active pen for text selection, you can override the pen scrolling behavior. See the Pen interaction section of the [Scroll​Viewer](scrollviewer.md) class reference for details.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [List view and grid view](/windows/apps/design/controls/listview-and-gridview).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the ListView in action](winui3gallery://item/ListView)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://apps.microsoft.com/detail/9p3jfpwwdzrc) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

## -see-also

[List view and grid view](/windows/apps/design/controls/listview-and-gridview), [ListViewBase](listviewbase.md), [ISemanticZoomInformation](isemanticzoominformation.md), [Item templates for ListView](/windows/uwp/controls-and-patterns/item-templates-listview), [Data binding overview](/windows/apps/develop/data-binding/data-binding-overview), [GridView](gridview.md), [SemanticZoom](semanticzoom.md)
