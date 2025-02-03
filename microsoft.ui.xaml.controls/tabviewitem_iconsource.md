---
-api-id: P:Microsoft.UI.Xaml.Controls.TabViewItem.IconSource
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.TabViewItem.IconSource

<!--
public Microsoft.UI.Xaml.Controls.IconSource IconSource { get; set; }
-->

## -description

Gets or sets the icon to be displayed within the tab.

## -property-value

The icon to be displayed within the tab.

## -remarks

If the [Header](tabviewitem_header.md) property is set, the icon appears inside the tab UI to the left of the header content.

## -see-also

[Header](tabviewitem_header.md)

## -examples

``` xaml
<TabView>
    <TabView.TabItems>
        <TabViewItem Header="Home" IsClosable="False">
            <TabViewItem.IconSource>
                <SymbolIconSource Symbol="Home" />
            </TabViewItem.IconSource>
            <!-- The content of the TabViewItem -->
        </TabViewItem>
    </TabView.TabItems>
</TabView>
```
