---
-api-id: T:Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem
-api-type: winrt class
---

# Microsoft.UI.Xaml.Controls.RadioMenuFlyoutItem

<!--
public class RadioMenuFlyoutItem : Windows.UI.Xaml.Controls.MenuFlyoutItem
-->

## -description

Represents a menu item that is mutually exclusive with other radio menu items in its group.

## -remarks

This control allows you to present users with menus containing multiple options, where a user would choose only one of these options at a given time.

RadioMenuFlyoutItem can be used inside [MenuBarItem](/uwp/api/windows.ui.xaml.controls.menubaritem), [MenuFlyout](/uwp/api/windows.ui.xaml.controls.menuflyout) and [MenuFlyoutSubItem](/uwp/api/windows.ui.xaml.controls.menuflyoutsubitem).

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -see-also

[Creating a menu](/windows/apps/design/controls/menus#create-a-menu-flyout-or-a-context-menu)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Menu flyout and menu bar](/windows/apps/design/controls/menus).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the MenuFlyout in action](winui3gallery:/item/MenuFlyout)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

This example shows how to create a three item radio menu flyout experience.

```Xaml
<Button Content="Options">
    <Button.Flyout>
        <MenuFlyout>
            <MenuFlyoutSubItem Text="View">
                <muxc:RadioMenuFlyoutItem Text="Small icons" GroupName="ViewGroup"/>
                <muxc:RadioMenuFlyoutItem Text="Medium icons" GroupName="ViewGroup" IsChecked="True"/>
                <muxc:RadioMenuFlyoutItem Text="Large icons" GroupName="ViewGroup"/>
            </MenuFlyoutSubItem>
        </MenuFlyout>
    </Button.Flyout>
</Button>
```
