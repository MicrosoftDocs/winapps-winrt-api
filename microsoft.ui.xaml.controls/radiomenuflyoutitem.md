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

## -see-also

[Creating a menu](/windows/apps/design/controls/menus#create-a-menu-flyout-or-a-context-menu)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Menu flyout and menu bar](/windows/apps/design/controls/menus).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the MenuFlyout in action](winui3gallery:/item/MenuFlyout).

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
