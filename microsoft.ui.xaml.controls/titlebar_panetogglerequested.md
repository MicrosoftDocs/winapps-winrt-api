---
-api-id: E:Microsoft.UI.Xaml.Controls.TitleBar.PaneToggleRequested
-api-type: winrt event
---

# Microsoft.UI.Xaml.Controls.TitleBar.PaneToggleRequested

<!--
public event Windows.Foundation.TypedEventHandler<Microsoft.UI.Xaml.Controls.TitleBar,object> PaneToggleRequested;
-->

## -description

Occurs when the pane toggle button is invoked.

## -remarks

When you use the [TitleBar](titlebar.md) control with a [NavigationView](navigationview.md) control, you should replace the navigation view's pane toggle button with the title bar's pane toggle button.

We recommend that you:

- Hide the pane toggle button in the `NavigationView` control. `<NavigationView IsPaneToggleButtonVisible="False">`
- Show the pane toggle button in the `TitleBar`. `<TitleBar IsPaneToggleButtonVisible="True">`
- Handle this event to toggle the value for the [NavigationPane.IsPaneOpen](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.navigationview.ispaneopen) property.

There is no inherent connection between the `TitleBar`'s pane toggle button and the `NavigationView`. The `TitleBar` button simply raises this event to let you provide code to toggle the `NavigationView`'s pane.

## -see-also

[NavigationView.IsPaneOpen](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.navigationview.ispaneopen), [NavigationView.IsPaneToggleButtonVisible](/windows/windows-app-sdk/api/winrt/microsoft.ui.xaml.controls.navigationview.ispanetogglebuttonvisible), [TitleBar.IsPaneToggleButtonVisible](titlebar_ispanetogglebuttonvisible.md)

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
