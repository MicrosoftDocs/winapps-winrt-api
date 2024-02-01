---
-api-id: T:Microsoft.UI.Xaml.Controls.Primitives.RepeatButton
-api-type: winrt class
---

<!-- Class syntax.
public class RepeatButton : Windows.UI.Xaml.Controls.Primitives.ButtonBase, Windows.UI.Xaml.Controls.Primitives.IRepeatButton
-->

# Microsoft.UI.Xaml.Controls.Primitives.RepeatButton

## -description
Represents a control that raises its [Click](buttonbase_click.md) event repeatedly when it is pressed and held.

## -xaml-syntax
```xaml
<RepeatButton .../>
-or-
<RepeatButton>
    singleObject
</RepeatButton>
-or-
<RepeatButton ...>stringContent</RepeatButton>
```


## -remarks
A RepeatButton is a button that raises [Click](buttonbase_click.md) events repeatedly from the time it is pressed until it is released. Set the [Delay](repeatbutton_delay.md) property to specify the time that the RepeatButton waits after it is pressed before it starts repeating the click action. Set the [Interval](repeatbutton_interval.md) property to specify the time between repetitions of the click action. Times for both properties are specified in milliseconds.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Buttons](/windows/apps/design/controls/buttons#create-a-repeat-button).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the RepeatButton in action](winui3gallery:/item/RepeatButton)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

The following example shows two RepeatButton controls whose respective [Click](buttonbase_click.md) events are used to increase and decrease the value shown in a [TextBlock](../microsoft.ui.xaml.controls/textblock.md).

```csharp
<StackPanel>
    <RepeatButton Width="100" Delay="500" Interval="100" Click="Increase_Click">Increase</RepeatButton>
    <RepeatButton Width="100" Delay="500" Interval="100" Click="Decrease_Click">Decrease</RepeatButton>
    <TextBlock x:Name="clickTextBlock" Text="Number of Clicks:"/>
</StackPanel>
```

```csharp
private static int _clicks = 0;
private void Increase_Click(object sender, RoutedEventArgs e)
{
    _clicks += 1;
    clickTextBlock.Text = "Number of Clicks: " + _clicks;
}

private void Decrease_Click(object sender, RoutedEventArgs e)
{
    if(_clicks > 0)
    {
        _clicks -= 1;
        clickTextBlock.Text = "Number of Clicks: " + _clicks;
    }
}
```

## -see-also
[ButtonBase](buttonbase.md)
