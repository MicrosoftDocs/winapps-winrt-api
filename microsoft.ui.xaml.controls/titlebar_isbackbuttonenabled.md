---
-api-id: P:Microsoft.UI.Xaml.Controls.TitleBar.IsBackButtonEnabled
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.TitleBar.IsBackButtonEnabled

<!--
public bool IsBackButtonEnabled { get; set; }
-->

## -description

Gets or sets a value that indicates whether the button to navigate back is enabled.

## -property-value

`true` if the button to navigate back is enabled; otherwise, `false`. The default is `true`.

## -remarks

Typically, you should bind the `IsBackButtonEnabled` property to the [CanGoBack](frame_cangoback.md) property of the [Frame](frame.md) that will perform the back navigation. This will automatically disable the back button when back navigation is not possible and enable the button when it is possible.

When you use the [TitleBar](titlebar.md) control with a [NavigationView](navigationview.md) control, you should replace the navigation view's back button with the title bar's back button.

We recommend that you:

- Hide the back button in the `NavigationView` control. `<NavigationView IsBackButtonVisible="Collapsed">`
- Show the back button in the `TitleBar` control. `<TitleBar IsBackButtonVisible="True">`
- Handle the [TitleBar.BackRequested](titlebar_backrequested.md) event to navigate back.

## -see-also

[TitleBar.BackRequested](titlebar_backrequested.md), [TitleBar.IsBackButtonVisible](titlebar_isbackbuttonvisible.md) [NavigationView.IsBackButtonVisible](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.navigationview.isbackbuttonvisible)

## -examples

```xaml
<!-- MainWindow.xaml -->

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto" />
        <RowDefinition Height="*" />
    </Grid.RowDefinitions>
    <TitleBar Title="My App"
              IsBackButtonVisible="True"
              IsBackButtonEnabled="{x:Bind RootFrame.CanGoBack, Mode=OneWay}"
              BackRequested="TitleBar_BackRequested">
    </TitleBar>

    <NavigationView x:Name="RootNavigationView" Grid.Row="1"
                    IsBackButtonVisible="Collapsed">
        <Frame x:Name="RootFrame" />
    </NavigationView>
</Grid>
```

```csharp
// MainWindow.xaml.cs

private void TitleBar_BackRequested(TitleBar sender, object args)
{
    if (RootFrame.CanGoBack)
    {
        RootFrame.GoBack();
    }
}
```
