---
-api-id: T:Microsoft.UI.Xaml.Controls.TabView
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.TabView

<!--
public class TabView : Windows.UI.Xaml.Controls.Control
-->

## -description

The TabView control is a way to display a set of tabs and their respective content. Tab controls are useful for displaying several pages (or documents) of content while giving a user the capability to rearrange, open, or close new tabs.

## -remarks

For more info, design guidance, and code examples, see [Tab view](/windows/apps/design/controls/tab-view).

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -see-also

[TabViewItem](tabviewitem.md), [TabViewCloseButtonOverlayMode](tabviewclosebuttonoverlaymode.md), [Tab view](/windows/apps/design/controls/tab-view)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Tab view](/windows/apps/design/controls/tab-view).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the TabView in action](winui3gallery://item/TabView).

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)

This example creates a simple TabView along with event handlers to support opening and closing tabs. The _Home_ tab is defined in XAML and can't be closed. The `TabView_AddTabButtonClick` event handler shows how to add a new [TabViewItem](tabviewitem.md) in code.

``` xaml
<TabView VerticalAlignment="Stretch"
         AddTabButtonClick="TabView_AddTabButtonClick"
         TabCloseRequested="TabView_TabCloseRequested">
    <TabViewItem Header="Home" IsClosable="False">
        <TabViewItem.IconSource>
            <SymbolIconSource Symbol="Home" />
        </TabViewItem.IconSource>
        <TabViewItem.Content>
            <StackPanel Padding="12">
                <TextBlock Text="TabView content" 
                           Style="{ThemeResource TitleTextBlockStyle}"/>
            </StackPanel>
        </TabViewItem.Content>
    </TabViewItem>
</TabView>
```

``` csharp
// Add a new tab to the TabView.
private void TabView_AddTabButtonClick(TabView sender, object args)
{
    var newTab = new TabViewItem();
    newTab.Header = $"New Document {sender.TabItems.Count}";
    newTab.IconSource = new SymbolIconSource() { Symbol = Symbol.Document };
    newTab.Content = new TextBlock() { Text = $"Content for new tab {sender.TabItems.Count}.",
                                       Padding = new Thickness(12) };
    sender.TabItems.Add(newTab);
    sender.SelectedItem = newTab;
}

// Remove the requested tab from the TabView.
private void TabView_TabCloseRequested(TabView sender, 
                                       TabViewTabCloseRequestedEventArgs args)
{
    sender.TabItems.Remove(args.Tab);
}
```
