---
-api-id: M:Microsoft.UI.Xaml.Window.SetTitleBar(Microsoft.UI.Xaml.UIElement)
-api-type: winrt method
---

# Microsoft.UI.Xaml.Window.SetTitleBar(Microsoft.UI.Xaml.UIElement)

<!--
public void SetTitleBar (Microsoft.UI.Xaml.UIElement titleBar);
-->

## -description

Enables title bar behavior on a XAML element when `ExtendsContentIntoTitleBar` is `true`.

## -parameters

### -param titleBar

The element to support title bar behavior.

## -remarks

Call this method to replace the system title bar with a custom title bar UI for your app. The specified element supports the same system interactions as the system title bar, including drag, double-click to resize, and right-click to show the system menu. As a result, pointer input (mouse, touch, pen, and so on) is no longer recognized by the element and its child elements.

The rectangular area occupied by the specified element acts as the title bar for pointer purposes, even if the element is blocked by another element, or the element is transparent.

If you want to place interactive elements in the title bar area, you can use [InputNonClientPointerSource](/windows/windows-app-sdk/api/winrt/microsoft.ui.input.inputnonclientpointersource) APIs. Refer to the [Titlebar](https://github.com/microsoft/WinUI-Gallery/blob/main/WinUIGallery/ControlPages/TitleBarPage.xaml.cs) page in the [WinUI Gallery](https://github.com/microsoft/WinUI-Gallery) sample for an example. 

## Extend content into title bar

To specify a custom title bar, you must set [ExtendsContentIntoTitleBar](window_extendscontentintotitlebar.md) to `true` to hide the default system title bar. If `ExtendsContentIntoTitleBar` is `false`, the call to `SetTitleBar` does not have any effect. Your custom title bar element is shown in the body of your app window as an ordinary UI element and does not get the title bar behaviors.

If you set [ExtendsContentIntoTitleBar](window_extendscontentintotitlebar.md) to `true` but do not call `SetTitleBar` (or call `SetTitlebar` with a `null` argument), a default custom title bar is provided. This default title bar is a direct replacement of the system title bar in position, width, and height. If you want a specialized title bar, you can call [SetTitleBar](window_settitlebar_1494775390.md) with a [`UIElement`](uielement.md) and get a title bar area on that `UIElement`'s position, width, and height. That `UIElement` can be hosted anywhere within the contents of the app, not just the non-client area.

## Title bar element

Only a single element can be specified as the title bar. If multiple elements are required, they can be specified as child elements of a single container (such as a [Grid](../microsoft.ui.xaml.controls/grid.md) or [StackPanel](../microsoft.ui.xaml.controls/stackpanel.md)). 

The custom title bar works best when it is not deep nested within the app. Deep nesting the [UIElement](uielement.md) within the XAML tree can cause unpredictable layout behaviors. The title bar will always be a of rectangular shape. In case of a non-rectangular `UIElement`, its rectangular bounding rectangle will be used for dimensions of the title bar.

## Colors
A custom title bar uses an [AppWindow title bar](/windows/windows-app-sdk/api/winrt/microsoft.ui.windowing.appwindowtitlebar) for its implementation. As a result, you can use AppWindowTitleBar theming APIs for colors like [`ButtonBackgroundColor`](/windows/windows-app-sdk/api/winrt/microsoft.ui.windowing.appwindowtitlebar.buttonbackgroundcolor), [`ButtonForegroundColor`](/windows/windows-app-sdk/api/winrt/microsoft.ui.windowing.appwindowtitlebar.buttonforegroundcolor), etc.

The resource based theming used in earlier versions (like `WindowCaptionBackground`) is deprecated and doesn't have any effect.

## -examples

This example shows how to extend the window's content area and replace the system title bar with a `Grid` that contains an icon and title text.

```xaml
<Window ... >
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="32"/>
            <RowDefinition/>
        </Grid.RowDefinitions>

        <Grid x:Name="AppTitleBar">
            <Image Source="Images/WindowIcon.png"
                   HorizontalAlignment="Left" 
                   Width="16" Height="16" 
                   Margin="8,0"/>
            <TextBlock x:Name="AppTitleTextBlock" Text="App title"
                       TextWrapping="NoWrap"
                       Style="{StaticResource CaptionTextBlockStyle}" 
                       VerticalAlignment="Center"
                       Margin="28,0,0,0"/>
        </Grid>

        <NavigationView Grid.Row="1">
            <!-- Page content -->
        </NavigationView>
    </Grid>
</Window>
```

```csharp
public MainWindow()
{
    this.InitializeComponent();

    ExtendsContentIntoTitleBar = true;
    SetTitleBar(AppTitleBar);  // skip call to this api to get a default custom title bar
}
```

## -see-also

[ExtendsContentIntoTitleBar](window_extendscontentintotitlebar.md), [IWindowNative](/windows/windows-app-sdk/api/win32/microsoft.ui.xaml.window/nn-microsoft-ui-xaml-window-iwindownative)
