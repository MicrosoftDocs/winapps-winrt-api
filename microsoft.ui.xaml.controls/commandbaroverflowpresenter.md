---
-api-id: T:Microsoft.UI.Xaml.Controls.CommandBarOverflowPresenter
-api-type: winrt class
---

<!-- Class syntax.
public class CommandBarOverflowPresenter : Windows.UI.Xaml.Controls.ItemsControl, Windows.UI.Xaml.Controls.ICommandBarOverflowPresenter
-->

# Microsoft.UI.Xaml.Controls.CommandBarOverflowPresenter

## -description
Displays the overflow content of a [CommandBar](commandbar.md).

## -xaml-syntax
```xaml

See Remarks

```


## -remarks
You don't typically declare object elements for CommandBarOverflowPresenter in XAML. There are no properties that a CommandBarOverflowPresenter can set in XAML syntax and there's no reason to declare a CommandBarOverflowPresenter as a resource.

The main purpose of the CommandBarOverflowPresenter class is to be the default internal presenter for the [SecondaryCommands](commandbar_secondarycommands.md) value of a [CommandBar](commandbar.md). You extend presentation behavior of the CommandBarOverflowPresenter by setting a value for the [CommandBarOverflowPresenterStyle](commandbar_commandbaroverflowpresenterstyle.md) property of the [CommandBar](commandbar.md). The [Style](../microsoft.ui.xaml/style.md) you declare that fills the [CommandBarOverflowPresenterStyle](commandbar_commandbaroverflowpresenterstyle.md) property must specify `TargetType="CommandBarOverflowPresenter"`. The properties that can be styled are the dependency properties of the base [ItemsControl](itemscontrol.md) class or [Control](control.md) class, such as [FontSize](control_fontsize.md) or [Padding](control_padding.md), or base element properties such as [FrameworkElement.Margin](../microsoft.ui.xaml/frameworkelement_margin.md) that the CommandBarOverflowPresenter class inherits.

CommandBarOverflowPresenter exists as a class and has a default constructor basically to satisfy XAML infrastructure support, when it's specified as the [TargetType](../microsoft.ui.xaml/style_targettype.md) of the [Style](../microsoft.ui.xaml/style.md) used for a [CommandBarOverflowPresenterStyle](commandbar_commandbaroverflowpresenterstyle.md) value.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -examples

## -see-also
[ItemsControl](itemscontrol.md), [IItemContainerMapping](iitemcontainermapping.md)
