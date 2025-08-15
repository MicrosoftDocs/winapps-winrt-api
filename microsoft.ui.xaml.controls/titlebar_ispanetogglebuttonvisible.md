---
-api-id: P:Microsoft.UI.Xaml.Controls.TitleBar.IsPaneToggleButtonVisible
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.TitleBar.IsPaneToggleButtonVisible

<!--
public bool IsPaneToggleButtonVisible { get; set; }
-->

## -description

Gets or sets a value that indicates whether the button to toggle the navigation pane is shown.

## -property-value

`true` if the button to toggle the navigation pane is shown; otherwise, `false`. The default is `false`.

## -remarks

When you use the [TitleBar](titlebar.md) control with a [NavigationView](navigationview.md) control, you should replace the navigation view's pane toggle button with the title bar's pane toggle button.

We recommend that you:

- Hide the pane toggle button in the `NavigationView` control. `<NavigationView IsPaneToggleButtonVisible="False">`
- Show the pane toggle button in the `TitleBar` control. `<TitleBar IsPaneToggleButtonVisible="True">`
- Handle the [TitleBar.PaneToggleRequested](titlebar_panetogglerequested.md) event to toggle the value for the [NavigationPane.IsPaneOpen](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.navigationview.ispaneopen) property.

## -see-also

[TitleBar.PaneToggleRequested](titlebar_panetogglerequested.md), [NavigationView.IsPaneOpen](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.navigationview.ispaneopen), [NavigationView.IsPaneToggleButtonVisible](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.navigationview.ispanetogglebuttonvisible)

## -examples

```xaml
<!-- MainWindow.xaml -->

<Grid>
    <Grid.RowDefinitions>
        <RowDefinition Height="Auto" />
        <RowDefinition Height="*" />
    </Grid.RowDefinitions>
    <TitleBar Title="My App"
              IsPaneToggleButtonVisible="True"
              PaneToggleRequested="TitleBar_PaneToggleRequested">
    </TitleBar>

    <NavigationView x:Name="RootNavigationView" Grid.Row="1"
                    IsPaneToggleButtonVisible="False">
        <Frame x:Name="RootFrame" />
    </NavigationView>
</Grid>
```

```csharp
// MainWindow.xaml.cs

private void TitleBar_PaneToggleRequested(TitleBar sender, object args)
{
    RootNavigationView.IsPaneOpen = !RootNavigationView.IsPaneOpen;
}
```
