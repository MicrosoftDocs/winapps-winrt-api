---
-api-id: T:Microsoft.UI.Xaml.Controls.RadioButton
-api-type: winrt class
---

<!-- Class syntax.
public class RadioButton : Windows.UI.Xaml.Controls.Primitives.ToggleButton, Windows.UI.Xaml.Controls.IRadioButton
-->

# Microsoft.UI.Xaml.Controls.RadioButton

## -description
Represents a button that allows a user to select a single option from a group of options.

## -xaml-syntax
```xaml
<RadioButton .../>
-or-
<RadioButton ...>
  content
</RadioButton>
-or-
<RadioButton ...>stringContent</RadioButton>
```

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Radio buttons](/windows/apps/design/controls/radio-button).

Use RadioButton controls to limit a user's selection to a single choice within a set of related, but mutually exclusive, choices. You group RadioButton controls by putting them inside the same parent container or by setting the [GroupName](radiobutton_groupname.md) property on each RadioButton to the same value.

<img alt="Radio button controls" src="images/controls/RadioButton.png" />

A RadioButton has two states: selected or cleared. When a RadioButton is selected, its [IsChecked](../microsoft.ui.xaml.controls.primitives/togglebutton_ischecked.md) property is **true**. When a RadioButton is cleared, its [IsChecked](../microsoft.ui.xaml.controls.primitives/togglebutton_ischecked.md) property is **false**. A RadioButton can be cleared by clicking another RadioButton in the same group, but it cannot be cleared by clicking it again. However, a RadioButton can be cleared programmatically by setting its [IsChecked](../microsoft.ui.xaml.controls.primitives/togglebutton_ischecked.md) property to **false**.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Radio button](/windows/apps/design/controls/radio-button).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the RadioButton in action](winui3gallery:/item/RadioButton)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)


The following example shows three radio buttons. The first two radio buttons are grouped together. The remaining radio button is not grouped explicitly, which means that you can select the third radio button and either the first or second. When you select a radio button, a [TextBlock](textblock.md) displays the name of the group, if the radio button has an explicit group name, and the name of the radio button.

[!code-xaml[1](../microsoft.ui.xaml.data/code/System.Windows.Controls.RadioButtonEx/csharp/Page.xaml#Snippet1)]

[!code-csharp[11](../microsoft.ui.xaml.data/code/System.Windows.Controls.RadioButtonEx/csharp/Page.xaml.cs#Snippet11)]

## -see-also
[Radio buttons overview](/windows/uwp/controls-and-patterns/radio-button), [ToggleButton](../microsoft.ui.xaml.controls.primitives/togglebutton.md), [CheckBox](checkbox.md), [ToggleSwitch](toggleswitch.md), [Controls list](/windows/apps/design/controls/)
p://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)
