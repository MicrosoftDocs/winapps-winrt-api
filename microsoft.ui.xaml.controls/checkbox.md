---
-api-id: T:Microsoft.UI.Xaml.Controls.CheckBox
-api-type: winrt class
---

<!-- Class syntax.
public class CheckBox : Windows.UI.Xaml.Controls.Primitives.ToggleButton, Windows.UI.Xaml.Controls.ICheckBox
-->

# Microsoft.UI.Xaml.Controls.CheckBox

## -description
Represents a control that a user can select (check) or clear (uncheck). A CheckBox can also report its value as indeterminate.

## -xaml-syntax
```xaml
<CheckBox .../>
-or-
<CheckBox>
  singleObject
</CheckBox>
-or-
<CheckBox>stringContent</CheckBox>
```


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Check boxes](/windows/apps/design/controls/checkbox).

CheckBox is a control that a user can select or clear.

<img alt="The 3 states of a check box" src="images/controls/CheckBox_DefaultStates.png" />

Use the CheckBox control to provide a list of options that a user can select, such as a list of settings to apply to an application. Both CheckBox and [RadioButton](radiobutton.md) controls allow the user to select from a list of options. CheckBox controls allow the user to select a combination of options. In contrast, [RadioButton](radiobutton.md) controls allow the user to select from mutually exclusive options.

The CheckBox control inherits from [ToggleButton](../microsoft.ui.xaml.controls.primitives/togglebutton.md) and can have three states: 

| State | Property | Value |
|---|---|---|
| checked | [IsChecked](../microsoft.ui.xaml.controls.primitives/togglebutton_ischecked.md) | **true** |
| unchecked | [IsChecked](../microsoft.ui.xaml.controls.primitives/togglebutton_ischecked.md) | **false** |
| indeterminate | [IsChecked](../microsoft.ui.xaml.controls.primitives/togglebutton_ischecked.md) | **null** |

For the CheckBox to report the indeterminate state, you must set the [IsThreeState](../microsoft.ui.xaml.controls.primitives/togglebutton_isthreestate.md) property to **true**.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

The resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [CheckBox_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/CheckBox_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Checkbox](/windows/apps/design/controls/checkbox).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the Checkbox in action](winui3gallery:/item/Checkbox).

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)

The following example shows two check box controls. The first check box demonstrates the checked and unchecked states. The second check box demonstrates the checked, unchecked, and indeterminate states. You can select the controls to change their appearance and see which state they are in.

[!code-xaml[1](../microsoft.ui.xaml.data/code/System.Windows.Controls.CheckBoxEx/csharp/Page.xaml#Snippet1)]

[!code-csharp[11](../microsoft.ui.xaml.data/code/System.Windows.Controls.CheckBoxEx/csharp/Page.xaml.cs#Snippet11)]

<img alt="The 3 states of a check box" src="images/CheckBox_3State.png" />

```xaml
<StackPanel>
    <CheckBox x:Name="OptionsAllCheckBox" Content="Select all" IsThreeState="True" 
              Checked="SelectAll_Checked" Unchecked="SelectAll_Unchecked" Indeterminate="SelectAll_Indeterminate"/>
    <CheckBox x:Name="Option1CheckBox" Content="Option 1" Margin="24,0,0,0" 
              Checked="Option_Checked" Unchecked="Option_Unchecked"/>
    <CheckBox x:Name="Option2CheckBox" Content="Option 2" Margin="24,0,0,0" 
              Checked="Option_Checked" Unchecked="Option_Unchecked" IsChecked="True"/>
    <CheckBox x:Name="Option3CheckBox" Content="Option 3" Margin="24,0,0,0"
              Checked="Option_Checked" Unchecked="Option_Unchecked"/>
</StackPanel>
```

```csharp
private void SelectAll_Checked(object sender, RoutedEventArgs e)
{
    Option1CheckBox.IsChecked = Option2CheckBox.IsChecked = Option3CheckBox.IsChecked = true;
}

private void SelectAll_Unchecked(object sender, RoutedEventArgs e)
{
    Option1CheckBox.IsChecked = Option2CheckBox.IsChecked = Option3CheckBox.IsChecked = false;
}

private void SelectAll_Indeterminate(object sender, RoutedEventArgs e)
{
    // If the SelectAll box is checked (all options are selected), 
    // clicking the box will change it to its indeterminate state.
    // Instead, we want to uncheck all the boxes,
    // so we do this programatically. The indeterminate state should
    // only be set programatically, not by the user.

    if (Option1CheckBox.IsChecked == true &&
        Option2CheckBox.IsChecked == true &&
        Option3CheckBox.IsChecked == true)
    {
        // This will cause SelectAll_Unchecked to be executed, so
        // we don't need to uncheck the other boxes here.
        OptionsAllCheckBox.IsChecked = false;
    }
}

private void SetCheckedState()
{
    // Controls are null the first time this is called, so we just 
    // need to perform a null check on any one of the controls.
    if (Option1CheckBox != null)
    {
        if (Option1CheckBox.IsChecked == true &&
            Option2CheckBox.IsChecked == true &&
            Option3CheckBox.IsChecked == true)
        {
            OptionsAllCheckBox.IsChecked = true;
        }
        else if (Option1CheckBox.IsChecked == false &&
            Option2CheckBox.IsChecked == false &&
            Option3CheckBox.IsChecked == false)
        {
            OptionsAllCheckBox.IsChecked = false;
        }
        else
        {
            // Set third state (indeterminate) by setting IsChecked to null.
            OptionsAllCheckBox.IsChecked = null;
        }
    }
}

private void Option_Checked(object sender, RoutedEventArgs e)
{
    SetCheckedState();
}

private void Option_Unchecked(object sender, RoutedEventArgs e)
{
    SetCheckedState();
} 
```



## -see-also
[Check boxes](/windows/apps/design/controls/checkbox), [RadioButton](radiobutton.md), [ToggleButton](../microsoft.ui.xaml.controls.primitives/togglebutton.md), [Controls list](/windows/apps/design/controls/)
