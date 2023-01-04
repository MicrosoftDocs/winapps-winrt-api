---
-api-id: T:Microsoft.UI.Xaml.Controls.MenuFlyoutPresenter
-api-type: winrt class
---

<!-- Class syntax.
public class MenuFlyoutPresenter : Windows.UI.Xaml.Controls.ItemsControl, Windows.UI.Xaml.Controls.IMenuFlyoutPresenter, Windows.UI.Xaml.Controls.IMenuFlyoutPresenter2
-->

# Microsoft.UI.Xaml.Controls.MenuFlyoutPresenter

## -description
Displays the content of a [MenuFlyout](menuflyout.md) control.

## -remarks
You don't typically use a MenuFlyoutPresenter directly, either in XAML or code. Instead, you reference the MenuFlyoutPresenter type as the [TargetType](../microsoft.ui.xaml/style_targettype.md) of the style you use for the [MenuFlyout.MenuFlyoutPresenterStyle](menuflyout_menuflyoutpresenterstyle.md) property. Then, you use style [Setter](../microsoft.ui.xaml/setter.md) elements to set the various [Control](control.md) properties that influence the appearance of the [MenuFlyout](menuflyout.md) through this presenter. For example you can use a [Setter](../microsoft.ui.xaml/setter.md) to set the [Width](../microsoft.ui.xaml/frameworkelement_width.md) of the [MenuFlyout](menuflyout.md):
```xaml
<MenuFlyout x:Name="optionFlyout">
  <MenuFlyout.MenuFlyoutPresenterStyle>
    <Style TargetType="MenuFlyoutPresenter">
      <Setter Property="Width" Value="300"/>
    </Style>
  </MenuFlyout.MenuFlyoutPresenterStyle>
<!--menu items go here-->
</MenuFlyout>
```

The MenuFlyoutPresenter class is not a [ContentPresenter](contentpresenter.md) derived class, it's actually a control (derived from [ItemsControl](itemscontrol.md)) that plays a special role when creating the visual tree for a [MenuFlyout](menuflyout.md).

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [MenuFlyout_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/MenuFlyout_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

## -examples

## -see-also
[ItemsControl](itemscontrol.md), [IItemContainerMapping](iitemcontainermapping.md), [MenuFlyout](menuflyout.md)
