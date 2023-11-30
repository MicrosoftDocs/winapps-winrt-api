---
-api-id: T:Microsoft.UI.Xaml.Controls.MenuFlyout
-api-type: winrt class
---

<!-- Class syntax.
public class MenuFlyout : Windows.UI.Xaml.Controls.Primitives.FlyoutBase, Windows.UI.Xaml.Controls.IMenuFlyout, Windows.UI.Xaml.Controls.IMenuFlyout2
-->

# Microsoft.UI.Xaml.Controls.MenuFlyout

## -description

Represents a flyout that displays a menu of commands.

## -xaml-syntax

```xaml
<MenuFlyout>
  oneOrMoreItems
</MenuFlyout>
```

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Menus and context menus](/windows/apps/design/controls/menus).

MenuFlyout temporarily displays a list of commands or options related to what the user is currently doing.

<img src="images/controls/MenuFlyout.png" alt="Menu flyout control" />

Use a [Flyout](flyout.md) control to display single items and a MenuFlyout control to show a menu of items. For more info, see [Menus and context menus](/windows/uwp/controls-and-patterns/menus).

A MenuFlyout control can be used as the value of the [Button.Flyout](button_flyout.md) property. This is usually set in XAML as part of a UI definition of the page. [Button](button.md) is the only control that has a dedicated **Flyout** property. When set as [Button.Flyout](button_flyout.md), the MenuFlyout displays when the button is tapped or otherwise invoked.

To associate a MenuFlyout with other controls as a content menu, use the [ContextFlyout](../microsoft.ui.xaml/uielement_contextflyout.md) property that's available on any UIElement.

You can use the [FlyoutBase.AttachedFlyout](../microsoft.ui.xaml.controls.primitives/flyoutbase_attachedflyout.md) attached property to associate a MenuFlyout with other controls as a regular menu. When a MenuFlyout is assigned to other UI elements using [FlyoutBase.AttachedFlyout](../microsoft.ui.xaml.controls.primitives/flyoutbase_attachedflyout.md), you must call either the [ShowAt](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.primitives.flyoutbase.showat) method or the static [ShowAttachedFlyout](../microsoft.ui.xaml.controls.primitives/flyoutbase_showattachedflyout_197558112.md) method to display the flyout.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Menus and context menus](/windows/apps/design/controls/menus).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the MenuFlyout in action](winui3gallery:/item/MenuFlyout).

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

This example creates a [MenuFlyout class](/uwp/api/Windows.UI.Xaml.Controls.MenuFlyout) and uses the [ContextFlyout](../microsoft.ui.xaml/uielement_contextflyout.md) property, a property available to most controls, to show the [MenuFlyout class](/uwp/api/Windows.UI.Xaml.Controls.MenuFlyout) as a context menu.

```xaml
<Rectangle Height="100" Width="100">
  <Rectangle.ContextFlyout>
    <MenuFlyout>
      <MenuFlyoutItem Text="Change color" Click="ChangeColorItem_Click" />
    </MenuFlyout>
  </Rectangle.ContextFlyout>
  <Rectangle.Fill>
    <SolidColorBrush x:Name="rectangleFill" Color="Red" />
  </Rectangle.Fill>
</Rectangle>
```

```csharp
private void ChangeColorItem_Click(object sender, RoutedEventArgs e)
{
    // Change the color from red to blue or blue to red.
    if (rectangleFill.Color == Windows.UI.Colors.Red)
    {
        rectangleFill.Color = Windows.UI.Colors.Blue;
    }
    else
    {
        rectangleFill.Color = Windows.UI.Colors.Red;
    }
}
```

The next example is nearly identical, but instead of using the [ContextFlyout](../microsoft.ui.xaml/uielement_contextflyout.md) property to show the [MenuFlyout class](/uwp/api/Windows.UI.Xaml.Controls.MenuFlyout) as a context menu, the example uses the [FlyoutBase.ShowAttachedFlyout](/uwp/api/windows.ui.xaml.controls.primitives.flyoutbase.showattachedflyout) property to show it as a menu.

```xaml
<Rectangle
  Height="100" Width="100"
  Tapped="Rectangle_Tapped">
  <FlyoutBase.AttachedFlyout>
    <MenuFlyout>
      <MenuFlyoutItem Text="Change color" Click="ChangeColorItem_Click" />
    </MenuFlyout>
  </FlyoutBase.AttachedFlyout>
  <Rectangle.Fill>
    <SolidColorBrush x:Name="rectangleFill" Color="Red" />
  </Rectangle.Fill>
</Rectangle>
```

```csharp
private void Rectangle_Tapped(object sender, TappedRoutedEventArgs e)
{
    FlyoutBase.ShowAttachedFlyout((FrameworkElement)sender);
}

private void ChangeColorItem_Click(object sender, RoutedEventArgs e)
{
    // Change the color from red to blue or blue to red.
    if (rectangleFill.Color == Windows.UI.Colors.Red)
    {
        rectangleFill.Color = Windows.UI.Colors.Blue;
    }
    else
    {
        rectangleFill.Color = Windows.UI.Colors.Red;
    }
}
```

This example shows how you can add and remove menu items at runtime based on changing conditions in your app.

```xaml
<StackPanel Margin="40" Width="220">
    <Rectangle x:Name="Rect1" Height="100" Width="200" 
               Stroke="Black" StrokeThickness="1" Fill="White">
        <Rectangle.ContextFlyout>
            <MenuFlyout x:Name="RectangleColorMenu"/>
        </Rectangle.ContextFlyout>
    </Rectangle>

    <StackPanel>
        <TextBlock TextWrapping="WrapWholeWords"
                   Text="Check colors to include in the menu, then choose a color from the context menu on the rectangle."/>
        <CheckBox Content="Blue" Click="CheckBox_Click" Tag="blue"/>
        <CheckBox Content="Green" Click="CheckBox_Click" Tag="green"/>
        <CheckBox Content="Red" Click="CheckBox_Click" Tag="red"/>
        <CheckBox Content="Yellow" Click="CheckBox_Click" Tag="yellow"/>
    </StackPanel>
</StackPanel>
```

```csharp
private void CheckBox_Click(object sender, RoutedEventArgs e)
{
    // Using the Tag property lets you localize the display name
    // without affecting functionality.
    var cb = (CheckBox)sender;
    if (cb.IsChecked == true)
    {
        AddMenuItem(cb.Tag.ToString(), cb.Content.ToString());
    }
    else
    {
        RemoveMenuItem(cb.Content.ToString());
    }
}

private void AddMenuItem(string colorString, string locColorName)
{
    // Set the color.
    Color newColor = Colors.Blue;
    if (colorString == "green")
        newColor = Colors.Green;
    else if (colorString == "red")
        newColor = Colors.Red;
    else if (colorString == "yellow")
        newColor = Colors.Yellow;

    // Create the menu item.
    var newMenuItem = new MenuFlyoutItem();
    newMenuItem.Text = locColorName;
    newMenuItem.Click += (s, e1) =>
    {
        Rect1.Fill = new SolidColorBrush(newColor);
    };

    // Add the item to the menu.
    RectangleColorMenu.Items.Add(newMenuItem);

    // Sort the menu so it's always consistent.
    var orderedItems =  RectangleColorMenu.Items.OrderBy(i => ((MenuFlyoutItem)i).Text).ToList();
    RectangleColorMenu.Items.Clear();
    foreach (var item in orderedItems)
    {
        RectangleColorMenu.Items.Add(item);
    }
}

private void RemoveMenuItem(string locColorName)
{
    // Get any menu items to remove and remove them.
    var items = RectangleColorMenu.Items.Where(i => ((MenuFlyoutItem)i).Text == locColorName);
    foreach (MenuFlyoutItem item in items)
    {
        RectangleColorMenu.Items.Remove(item);
    }
}
```

## -see-also

[Menus and context menus overview](/windows/uwp/controls-and-patterns/menus), [MenuFlyoutPresenter](menuflyoutpresenter.md), [FlyoutBase](../microsoft.ui.xaml.controls.primitives/flyoutbase.md), [Flyout](flyout.md), [Button.Flyout](button_flyout.md), [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview), [Context menu sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlContextMenu), [Commanding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlCommanding), [Context menu (XAML) sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlContextMenu)
