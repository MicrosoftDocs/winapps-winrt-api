---
-api-id: T:Microsoft.UI.Xaml.Controls.NavigationView
-api-type: winrt class
---
<!-- Class syntax.
public class NavigationView : ContentControl, ContentControl
-->

# Microsoft.UI.Xaml.Controls.NavigationView

## -description

Represents a container that enables navigation of app content. It has a header, a view for the main content, and a menu pane for navigation commands.

## -remarks

### Access keys for built-in elements

To add access keys for the _back arrow_ and _settings_ buttons that are built-in to NavigationView, you have to use [VisualTreeHelper](/uwp/api/windows.ui.xaml.media.visualtreehelper) to get a reference to those controls, then set the properties in your code.

This example shows how to handle the [Loaded](/uwp/api/windows.ui.xaml.frameworkelement.loaded) event to find the elements in the visual tree and set the [AccessKey](/uwp/api/windows.ui.xaml.uielement.accesskey) and [KeyTipPlacementMode](/uwp/api/windows.ui.xaml.uielement.keytipplacementmode) properties.

```csharp
private void NavigationView_Loaded(object sender, RoutedEventArgs e)
{
    // using muxc = Microsoft.UI.Xaml.Controls;

    var navView = sender as muxc.NavigationView;
    var rootGrid = VisualTreeHelper.GetChild(navView, 0) as Grid;

    // Find the back button.
    var paneToggleButtonGrid = VisualTreeHelper.GetChild(rootGrid, 0) as Grid;
    var buttonHolderGrid = VisualTreeHelper.GetChild(paneToggleButtonGrid, 1) as Grid;
    var navigationViewBackButton = VisualTreeHelper.GetChild(buttonHolderGrid, 0) as Button;

    navigationViewBackButton.AccessKey = "A";

    if (navView.PaneDisplayMode == muxc.NavigationViewPaneDisplayMode.Top)
    {
        // Set back button key tip placement mode.
        navigationViewBackButton.KeyTipPlacementMode = Windows.UI.Xaml.Input.KeyTipPlacementMode.Bottom;

        // Find the settings item and set properties.
        var grid = VisualTreeHelper.GetChild(rootGrid, 1) as Grid;
        var topNavArea = VisualTreeHelper.GetChild(grid, 0) as StackPanel;
        var topNavGrid = VisualTreeHelper.GetChild(topNavArea, 1) as Grid;
        var settingsTopNavPaneItem = VisualTreeHelper.GetChild(topNavGrid, 8) as muxc.NavigationViewItem;

        settingsTopNavPaneItem.AccessKey = "S";
        settingsTopNavPaneItem.KeyTipPlacementMode = Windows.UI.Xaml.Input.KeyTipPlacementMode.Bottom;
    }
    else
    {
        // Set back button key tip placement mode.
        navigationViewBackButton.KeyTipPlacementMode = Windows.UI.Xaml.Input.KeyTipPlacementMode.Right;

        // Find the settings item and set properties.
        var grid = VisualTreeHelper.GetChild(rootGrid, 1) as Grid;
        var rootSplitView = VisualTreeHelper.GetChild(grid, 1) as SplitView;
        var grid2 = VisualTreeHelper.GetChild(rootSplitView, 0) as Grid;
        var paneRoot = VisualTreeHelper.GetChild(grid2, 0) as Grid;
        var border = VisualTreeHelper.GetChild(paneRoot, 0) as Border;
        var paneContentGrid = VisualTreeHelper.GetChild(border, 0) as Grid;
        var settingsNavPaneItem = VisualTreeHelper.GetChild(paneContentGrid, 6) as muxc.NavigationViewItem;

        settingsNavPaneItem.AccessKey = "S";
        settingsNavPaneItem.KeyTipPlacementMode = Windows.UI.Xaml.Input.KeyTipPlacementMode.Right;
    }
}
```

### Specific keyboarding guidelines

NavigationView supports hierarchy and nested items, which slightly changes the expected keyboarding behavior. For more information on keyboarding within a hierarchical NavigationView, see the [hierarchical NavigationView guidelines documentation](/windows/uwp/design/controls-and-patterns/navigationview#hierarchical-navigation).

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -see-also

[Guidelines for navigation view](/windows/uwp/controls-and-patterns/navigationview), [Back button in NavigationView](/windows/apps/design/basics/navigation-history-and-backwards-navigation)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Navigation View](/windows/apps/design/controls/navigationview).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the NavigationView in action](winui3gallery:/item/NavigationView)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)

## -xaml-syntax

```xaml
<NavigationView .../>
```


