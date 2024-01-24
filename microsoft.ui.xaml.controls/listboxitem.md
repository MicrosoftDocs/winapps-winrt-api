---
-api-id: T:Microsoft.UI.Xaml.Controls.ListBoxItem
-api-type: winrt class
---

<!-- Class syntax.
public class ListBoxItem : Windows.UI.Xaml.Controls.Primitives.SelectorItem, Windows.UI.Xaml.Controls.IListBoxItem
-->

# Microsoft.UI.Xaml.Controls.ListBoxItem

## -description
Represents the container for an item in a [ListBox](listbox.md) control.

## -xaml-syntax
```xaml
<ListBoxItem .../>
-or-
<ListBoxItem ...>
  content
</ListBoxItem>
```

## -remarks
The ListBoxItem class provides the container for items displayed in a [ListBox](listbox.md) control. You populate the [ListBox](listbox.md) by adding ListBoxItems directly to its [Items](itemscontrol_items.md) collection or by binding its [ItemsSource](itemscontrol_itemssource.md) property to a data source. When items are added to the [ListBox](listbox.md), a ListBoxItem container is created automatically for each item in the collection.

You can specify the look of the ListBoxItem by setting the [ListBox](listbox.md)'s [ItemContainerStyle](itemscontrol_itemcontainerstyle.md) property to a [Style](../microsoft.ui.xaml/style.md) with a [TargetType](../microsoft.ui.xaml/style_targettype.md) of ListBoxItem.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [List boxes](/windows/apps/design/controls/lists#list-boxes).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the ListBox in action](winui3gallery:/item/ListBox)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

## -see-also

[SelectorItem](../microsoft.ui.xaml.controls.primitives/selectoritem.md), [ListBox](listbox.md), [ItemContainerStyle](itemscontrol_itemcontainerstyle.md)
