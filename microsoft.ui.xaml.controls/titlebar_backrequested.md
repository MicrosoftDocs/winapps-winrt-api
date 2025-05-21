---
-api-id: E:Microsoft.UI.Xaml.Controls.TitleBar.BackRequested
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.TitleBar.BackRequested

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.TitleBar,object> BackRequested;
-->

## -description

Occurs when the back navigation button is invoked.

## -remarks

When you use the [TitleBar](titlebar.md) control with a [NavigationView](navigationview.md) control, you should replace the navigation view's back button with the title bar's back button.

We recommend that you:

- Hide the back button in the `NavigationView` control. `<NavigationView IsBackButtonVisible="Collapsed">`
- Show the back button in the `TitleBar` control. `<TitleBar IsBackButtonVisible="True">`
- Handle this event to navigate back.

## -see-also

[TitleBar.IsBackButtonVisible](titlebar_isbackbuttonvisible.md), [TitleBar.IsBackButtonEnabled](titlebar_isbackbuttonenabled.md) [NavigationView.IsBackButtonVisible](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.navigationview.isbackbuttonvisible)

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
