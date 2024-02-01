---
-api-id: T:Microsoft.UI.Xaml.Controls.ContentDialog
-api-type: winrt class
---

<!-- Class syntax.
public class ContentDialog : Windows.UI.Xaml.Controls.ContentControl, Windows.UI.Xaml.Controls.IContentDialog, Windows.UI.Xaml.Controls.IContentDialog2
-->

# Microsoft.UI.Xaml.Controls.ContentDialog

## -description
Represents a dialog box that can be customized to contain checkboxes, hyperlinks, buttons and any other XAML content.

## -xaml-syntax
```xaml
<ContentDialog .../>
-or-
<ContentDialog>
    singleObject
</ContentDialog>
-or-
<ContentDialog>stringContent</ContentDialog>
```


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Dialog controls](/windows/apps/design/controls/dialogs-and-flyouts/dialogs
).

Use a ContentDialog to request input from the user, or to show information in a modal dialog. You can add a ContentDialog to an app page using code or XAML, or you can create a custom dialog class that's derived from ContentDialog. Both ways are shown in the examples section of this topic.

### Title

Use the [Title](contentdialog_title.md) property to put a title on the dialog. To add a complex title element with more than simple text, you can use the [TitleTemplate](contentdialog_titletemplate.md) property.

### Command buttons

The ContentDialog has 3 built-in buttons that describe the actions that the user may take in response to the dialog's prompt. All dialogs should have a safe, non-destructive action. Dialogs may also optionally contain one or two specific "do it" actions in response to the prompt.  

Use the [PrimaryButtonText](contentdialog_primarybuttontext.md) and [SecondaryButtonText](contentdialog_secondarybuttontext.md) properties to display responses to the main question or action posed by the dialog.

Use the [CloseButtonText](contentdialog_closebuttontext.md) property to set the display text for the safe, non-destructive button. The dialog's close button is also invoked when the user performs a _Cancel_ action, like pressing the ESC key or pressing the system back button.

You may optionally choose to differentiate one of the three buttons as the dialog's default button. Use the [DefaultButton](contentdialog_defaultbutton.md) property to differentiate one of the buttons. This button will receive the Accent Button visual treatment, respond to the ENTER key automatically, and receive focus when the dialog is opened unless the dialog's content contains focusable elements.

### Show the dialog and use it's result

To show the dialog, call the [ShowAsync](contentdialog_showasync_606257163.md) method. Use the [ContentDialogResult](contentdialogresult.md) returned by this method to determine which of the buttons was clicked, if any. If the user presses ESC, the system back arrow, or Gamepad B, the result of this method will be `None`.

### Set the XamlRoot

When you show a ContentDialog, you need to manually set the [XamlRoot](../microsoft.ui.xaml/uielement_xamlroot.md) of the dialog to the root of the XAML host. To do so, set the ContentDialog's XamlRoot property to the same XamlRoot as an element already in the  XAML tree.

If the ContentDialog is shown from a [Page](page.md), you can set the ContentDialog's XamlRoot property to the XamlRoot of the Page (
`XamlRoot = this.XamlRoot`).

[Window](../microsoft.ui.xaml/window.md) doesn't have a XamlRoot property, so if the dialog is shown from a Window, set the dialog's XamlRoot property to that of the Window's root content element, as shown here.

```xaml
<Window
    ... >
    <Grid x:Name="rootPanel">
    
    </Grid>
</Window>
``````

```csharp
private async void DisplayNoWifiDialog()
{
    ContentDialog noWifiDialog = new ContentDialog
    {
        XamlRoot = rootPanel.XamlRoot,
        Title = "No wifi connection",
        Content = "Check your connection and try again.",
        CloseButtonText = "Ok"
    };

    ContentDialogResult result = await noWifiDialog.ShowAsync();
}
```

### Close the dialog

You may wish to do some work before the dialog closes (for example, to verify that the user entered data into form fields before submitting a request). You have two ways to do work before the dialog closes. You can handle the [PrimaryButtonClick](contentdialog_primarybuttonclick.md), [SecondaryButtonClick](contentdialog_secondarybuttonclick.md), or [CloseButtonClick](contentdialog_closebuttonclick.md) events to get the user's response when the user presses a button and verify the state of the dialog before it closes. You can also handle the [Closing](contentdialog_closing.md) event to do work before the dialog closes.

Only one ContentDialog can be shown at a time. To chain together more than one ContentDialog, handle the [Closing](contentdialog_closing.md) event of the first ContentDialog. In the [Closing](contentdialog_closing.md) event handler, call [ShowAsync](contentdialog_showasync_606257163.md) on the second dialog to show it.

> [!WARNING]
> There can only be one ContentDialog open per thread at a time. Attempting to open two ContentDialogs will throw an exception, even if they are attempting to open in separate app windows.

### Derived controls with WinUI styles

If you derive a custom control from an existing XAML control, it will not get the WinUI styles by default. To apply the WinUI styles:

- Create a new [Style](../microsoft.ui.xaml/style.md) with its [TargetType](../microsoft.ui.xaml/style_targettype.md) set to your custom control.
- Base the Style on the default style of the control you derived from.

One common scenario for this is to derive a new control from ContentDialog. This example shows how to create a new Style that applies `DefaultContentDialogStyle` to your custom dialog.

```xaml
<ContentDialog
    x:Class="ExampleApp.SignInContentDialog"
    ... >
    <ContentDialog.Resources>
        <Style TargetType="local:SignInContentDialog" 
               BasedOn="{StaticResource DefaultContentDialogStyle}"/>
    </ContentDialog.Resources> 
    <!-- CONTENT -->
</ContentDialog>
```

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Dialog controls](/windows/apps/design/controls/dialogs-and-flyouts/dialogs).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the ContentDialog in action](winui3gallery:/item/ContentDialog)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

This example shows how to create and show a simple ContentDialog in code.

> [!IMPORTANT]
> This example assumes the dialog is shown from a [Page](page.md). To show the dialog from a [Window](../microsoft.ui.xaml/window.md), see the **Set the XamlRoot** section of the Remarks.

```csharp
private async void DisplayNoWifiDialog()
{
    ContentDialog noWifiDialog = new ContentDialog()
    {
        XamlRoot = this.XamlRoot,
        Title = "No wifi connection",
        Content = "Check connection and try again.",
        CloseButtonText = "Ok"
    };

    await noWifiDialog.ShowAsync();
}
```

This example shows how to create a ContentDialog in the XAML of an app page. Even though the dialog is defined in the app page, it's not shown until you call [ShowAsync](contentdialog_showasync_606257163.md) in your code.

Here, the [IsPrimaryButtonEnabled](contentdialog_isprimarybuttonenabled.md) property is set to `false`. The primary button is enabled in code when the user checks the [CheckBox](checkbox.md) to confirm their age.

The [TitleTemplate](contentdialog_titletemplate.md) property is used to create a title that includes both a logo and text.

```xaml
<ContentDialog x:Name="termsOfUseContentDialog"
           PrimaryButtonText="Accept" IsPrimaryButtonEnabled="False"
           CloseButtonText="Cancel"
           Opened="TermsOfUseContentDialog_Opened">
    <ContentDialog.TitleTemplate>
        <DataTemplate>
            <StackPanel Orientation="Horizontal">
                <Image Source="ms-appx:///Assets/SmallLogo.png" Width="40" Height="40" Margin="10,0"/>
                <TextBlock Text="Terms of use"/>
            </StackPanel>
        </DataTemplate>
    </ContentDialog.TitleTemplate>
    <StackPanel>
        <TextBlock TextWrapping="WrapWholeWords">
        <Run>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor
             congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus
             malesuada libero, sit amet commodo magna eros quis urna.</Run><LineBreak/>
        <Run>Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.</Run><LineBreak/>
        <Run>Pellentesque habitant morbi tristique senectus et netus et malesuada fames
             ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.</Run><LineBreak/>
        <Run>Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc.
             Mauris eget neque at sem venenatis eleifend. Ut nonummy.</Run>
        </TextBlock>
        <CheckBox x:Name="ConfirmAgeCheckBox" Content="I am over 13 years of age."
              Checked="ConfirmAgeCheckBox_Checked" Unchecked="ConfirmAgeCheckBox_Unchecked"/>
    </StackPanel>
</ContentDialog>
```

```csharp
private async void ShowTermsOfUseContentDialogButton_Click(object sender, RoutedEventArgs e)
{
    termsOfUseContentDialog.XamlRoot = this.XamlRoot;
    ContentDialogResult result = await termsOfUseContentDialog.ShowAsync();
    if (result == ContentDialogResult.Primary)
    {
        // Terms of use were accepted.
    }
    else
    {
        // User pressed Cancel, ESC, or the back arrow.
        // Terms of use were not accepted.
    }
}

private void TermsOfUseContentDialog_Opened(ContentDialog sender, ContentDialogOpenedEventArgs args)
{
    // Ensure that the check box is unchecked each time the dialog opens.
    ConfirmAgeCheckBox.IsChecked = false;
}

private void ConfirmAgeCheckBox_Checked(object sender, RoutedEventArgs e)
{
    termsOfUseContentDialog.IsPrimaryButtonEnabled = true;
}

private void ConfirmAgeCheckBox_Unchecked(object sender, RoutedEventArgs e)
{
    termsOfUseContentDialog.IsPrimaryButtonEnabled = false;
}
```

This example shows how to create and use a more complex custom dialog (`SignInContentDialog`) derived from ContentDialog. Also see the [Derived controls with WinUI styles](#derived_controls_with_winui_styles) section of this article.

```xaml
<ContentDialog
    x:Class="ContentDialog_WinUI3.SignInContentDialog"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:ContentDialog_WinUI3"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d"
    Title="SIGN IN"
    PrimaryButtonText="Sign In"  
    CloseButtonText="Cancel"
    PrimaryButtonClick="ContentDialog_PrimaryButtonClick"
    CloseButtonClick="ContentDialog_CloseButtonClick">

    <ContentDialog.Resources>
        <Style TargetType="local:SignInContentDialog" BasedOn="{StaticResource DefaultContentDialogStyle}"/>
    </ContentDialog.Resources>

    <StackPanel VerticalAlignment="Stretch" HorizontalAlignment="Stretch">
        <TextBox Name="userNameTextBox" Header="User name"
                 TextChanged="UserNameTextBox_TextChanged"/>
        <PasswordBox Name="passwordTextBox" Header="Password" IsPasswordRevealButtonEnabled="True"
                     PasswordChanged="PasswordTextBox_PasswordChanged"/>
        <CheckBox Name="saveUserNameCheckBox" Content="Save user name"/>
        <InfoBar x:Name="errorInfoBar" Severity="Error" IsOpen="False" IsClosable="False"/>

        <!-- Content body -->
        <TextBlock Name="body" Style="{StaticResource BodyTextBlockStyle}" TextWrapping="Wrap">
            <TextBlock.Text>
                Lorem ipsum dolor sit amet, consectetur adipisicing elit,
                    sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
            </TextBlock.Text>
        </TextBlock>
    </StackPanel>
</ContentDialog>
```

```csharp
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Threading.Tasks;

namespace ContentDialog_WinUI3
{
    public enum SignInResult
    {
        SignInOK,
        SignInFail,
        SignInCancel,
        Nothing
    }

    public sealed partial class SignInContentDialog : ContentDialog
    {
        public SignInResult Result { get; private set; }

        public SignInContentDialog()
        {
            this.InitializeComponent();
            this.Opened += SignInContentDialog_Opened;
            this.Closing += SignInContentDialog_Closing;
        }

        private async void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            // Ensure the user name and password fields aren't empty. If a required
            // field is empty, set args.Cancel = true to keep the dialog open.
              if (string.IsNullOrEmpty(userNameTextBox.Text))
            {
                errorInfoBar.Message = "User name is required.";
                errorInfoBar.IsOpen = true;
            }
            else if (string.IsNullOrEmpty(passwordTextBox.Password))
            {
                errorInfoBar.Message = "Password is required.";
                errorInfoBar.IsOpen = true;
            }
            args.Cancel = errorInfoBar.IsOpen;

            // If you're performing async operations in the button click handler,
            // get a deferral before you await the operation. Then, complete the
            // deferral when the async operation is complete.
            if (args.Cancel == false) 
            {
                ContentDialogButtonClickDeferral deferral = args.GetDeferral();
                if (await SimulateAsyncSignInOperation())
                {
                    this.Result = SignInResult.SignInOK;
                }
                else
                {
                    this.Result = SignInResult.SignInFail;
                }
                deferral.Complete();
            }
        }

        private async Task<bool> SimulateAsyncSignInOperation()
        {
            // return true to simulate sign-in success.
            return true;
            // return false to simulate sign-in failure.
            /// return false;
        }

        private void ContentDialog_CloseButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            // User clicked Cancel, ESC, or the system back button.
            this.Result = SignInResult.SignInCancel;
        }

        void SignInContentDialog_Opened(ContentDialog sender, ContentDialogOpenedEventArgs args)
        {
            this.Result = SignInResult.Nothing;

            // If the user name is saved, get it and populate the user name field.
            Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            if (localSettings.Values.ContainsKey("userName"))
            {
                userNameTextBox.Text = localSettings.Values["userName"].ToString();
                saveUserNameCheckBox.IsChecked = true;
            }
        }

        void SignInContentDialog_Closing(ContentDialog sender, ContentDialogClosingEventArgs args)
        {
            // If sign in was successful, save or clear the user name based on the user choice.
            if (this.Result == SignInResult.SignInOK)
            {
                if (saveUserNameCheckBox.IsChecked == true)
                {
                    SaveUserName();
                }
                else
                {
                    ClearUserName();
                }
            }
        }

        private void SaveUserName()
        {
            Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["userName"] = userNameTextBox.Text;
        }

        private void ClearUserName()
        {
            Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;
            localSettings.Values["userName"] = null;
            userNameTextBox.Text = string.Empty;
        }

        private void UserNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Clear the error if the user name field isn't empty.
            if (!string.IsNullOrEmpty(userNameTextBox.Text))
            {
                errorInfoBar.Message = string.Empty;
                errorInfoBar.IsOpen = false;
            }
        }

        private void PasswordTextBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            // Clear the error if the password field isn't empty.
            if (!string.IsNullOrEmpty(passwordTextBox.Password))
            {
                errorInfoBar.Message = string.Empty;
                errorInfoBar.IsOpen = false;
            }
        }
    }
}
```

Here's code that shows the `SignInContentDialog` and uses its custom `SignInResult`.

```xaml
private async void ShowSignInDialogButton_Click(object sender, RoutedEventArgs e)
{
    SignInContentDialog signInDialog = new SignInContentDialog()
    {
        XamlRoot = rootPanel.XamlRoot
    };
    await signInDialog.ShowAsync();

    if (signInDialog.Result == SignInResult.SignInOK)
    {
        // Sign in was successful.
    }
    else if (signInDialog.Result == SignInResult.SignInFail)
    {
        // Sign in failed.
    }
    else if (signInDialog.Result == SignInResult.SignInCancel)
    {
        // Sign in was cancelled by the user. 
    }
}
```

## -see-also

[ContentControl](contentcontrol.md), [Dialogs and flyouts](/windows/apps/design/controls/dialogs-and-flyouts)
