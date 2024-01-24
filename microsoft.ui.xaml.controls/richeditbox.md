---
-api-id: T:Microsoft.UI.Xaml.Controls.RichEditBox
-api-type: winrt class
---

<!-- Class syntax.
public class RichEditBox : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IRichEditBox, Windows.UI.Xaml.Controls.IRichEditBox2, Windows.UI.Xaml.Controls.IRichEditBox3, Windows.UI.Xaml.Controls.IRichEditBox4, Windows.UI.Xaml.Controls.IRichEditBox5
-->

# Microsoft.UI.Xaml.Controls.RichEditBox

## -description

Represents a rich text editing control that supports formatted text, hyperlinks, and other rich content.

## -xaml-syntax

```xaml
<RichEditBox .../>

```

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Rich edit box](/windows/apps/design/controls/rich-edit-box).

RichEditBox is a control that lets a user enter formatted text such as bold, italic, and underlined. RichEditBox can also display Rich Text Format (.rtf) documents including hyperlinks and images (.jpg, .png, etc). This control is designed for advanced text editing scenarios. For simple plain text input, like on a form, consider using [TextBox](textbox.md).

You use the [Document](richeditbox_document.md) property of the RichEditBox to get its content. The content of a RichEditBox is a [Windows.UI.Text.ITextDocument](/uwp/api/windows.ui.text.itextdocument) object, which gives you access to the underlying [Text Object Model](/windows/desktop/Controls/text-object-model) APIs. See the [Windows.UI.Text](/uwp/api/windows.ui.text) namespace for APIs that you can use to work with the text document.

For more info and examples, see the [RichEditBox control guide](/windows/uwp/controls-and-patterns/rich-edit-box).

### Pen input

XAML text input boxes feature embedded support for pen input using [Windows Ink](/windows/apps/design/input/pen-and-stylus-interactions). When a user taps into a text input box using a Windows pen, the text box transforms to let the user write directly into it with a pen, rather than opening a separate input panel.

<img src="images/controls/handwritingview-inksuggestion1.gif" alt="Text box with ink and suggestions" />

For more info, see [Text input with the handwriting view](/windows/apps/design/controls/text-handwriting-view).

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

Resources that start with `TextControl` are shared by [TextBox](textbox.md), [PasswordBox](passwordbox.md), `RichEditBox`, and [AutoSuggestBox](autosuggestbox.md). Changes to these resources will affect all four controls.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Rich edit box](/windows/apps/design/controls/rich-edit-box).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the RichEditBox in action](winui3gallery:/item/RichEditBox)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)


This example shows how to use the [ITextDocument.SetText](/uwp/api/windows.ui.text.itextdocument.settext) method to programmatically add text to a RichEditBox.

```xaml
<RichEditBox x:Name="richEditBox" Width="500" Header="Notes"/>
```

```csharp
richEditBox.Document.SetText(Windows.UI.Text.TextSetOptions.None, "This is some sample text");
```

This example shows how to edit, load, and save a Rich Text Format (.rtf) file in a RichEditBox.

```xaml
 <RelativePanel Margin="20" HorizontalAlignment="Stretch">
     <RelativePanel.Resources>
         <Style TargetType="AppBarButton">
             <Setter Property="IsCompact" Value="True"/>
         </Style>
     </RelativePanel.Resources>
     <AppBarButton x:Name="openFileButton" Icon="OpenFile" 
                   Click="OpenButton_Click" ToolTipService.ToolTip="Open file"/>
     <AppBarButton Icon="Save" Click="SaveButton_Click" 
                   ToolTipService.ToolTip="Save file" 
                   RelativePanel.RightOf="openFileButton" Margin="8,0,0,0"/>

     <AppBarButton Icon="Bold" Click="BoldButton_Click" ToolTipService.ToolTip="Bold" 
                   RelativePanel.LeftOf="italicButton" Margin="0,0,8,0"/>
     <AppBarButton x:Name="italicButton" Icon="Italic" Click="ItalicButton_Click" 
                   ToolTipService.ToolTip="Italic" RelativePanel.LeftOf="underlineButton" Margin="0,0,8,0"/>
     <AppBarButton x:Name="underlineButton" Icon="Underline" Click="UnderlineButton_Click" 
                   ToolTipService.ToolTip="Underline" RelativePanel.AlignRightWithPanel="True"/>


     <RichEditBox x:Name="editor" Height="200" RelativePanel.Below="openFileButton" 
                  RelativePanel.AlignLeftWithPanel="True" RelativePanel.AlignRightWithPanel="True"/>
 </RelativePanel>
```

```csharp
private async void OpenButton_Click(object sender, RoutedEventArgs e)
{
    // Open a text file.
    Windows.Storage.Pickers.FileOpenPicker open =
        new Windows.Storage.Pickers.FileOpenPicker();
    open.SuggestedStartLocation =
        Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
    open.FileTypeFilter.Add(".rtf");

    Windows.Storage.StorageFile file = await open.PickSingleFileAsync();

    if (file != null)
    {
        try
        {
            Windows.Storage.Streams.IRandomAccessStream randAccStream =
        await file.OpenAsync(Windows.Storage.FileAccessMode.Read);

            // Load the file into the Document property of the RichEditBox.
            editor.Document.LoadFromStream(Windows.UI.Text.TextSetOptions.FormatRtf, randAccStream);
        }
        catch (Exception)
        {
            ContentDialog errorDialog = new ContentDialog()
            {
                Title = "File open error",
                Content = "Sorry, I couldn't open the file.",
                PrimaryButtonText = "Ok"
            };

            await errorDialog.ShowAsync();
        }
    }
}

private async void SaveButton_Click(object sender, RoutedEventArgs e)
{
    Windows.Storage.Pickers.FileSavePicker savePicker = new Windows.Storage.Pickers.FileSavePicker();
    savePicker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;

    // Dropdown of file types the user can save the file as
    savePicker.FileTypeChoices.Add("Rich Text", new List<string>() { ".rtf" });

    // Default file name if the user does not type one in or select a file to replace
    savePicker.SuggestedFileName = "New Document";

    Windows.Storage.StorageFile file = await savePicker.PickSaveFileAsync();
    if (file != null)
    {
        // Prevent updates to the remote version of the file until we 
        // finish making changes and call CompleteUpdatesAsync.
        Windows.Storage.CachedFileManager.DeferUpdates(file);
        // write to file
        Windows.Storage.Streams.IRandomAccessStream randAccStream =
            await file.OpenAsync(Windows.Storage.FileAccessMode.ReadWrite);

        editor.Document.SaveToStream(Windows.UI.Text.TextGetOptions.FormatRtf, randAccStream);

        // Let Windows know that we're finished changing the file so the 
        // other app can update the remote version of the file.
        Windows.Storage.Provider.FileUpdateStatus status = await Windows.Storage.CachedFileManager.CompleteUpdatesAsync(file);
        if (status != Windows.Storage.Provider.FileUpdateStatus.Complete)
        {
            Windows.UI.Popups.MessageDialog errorBox =
                new Windows.UI.Popups.MessageDialog("File " + file.Name + " couldn't be saved.");
            await errorBox.ShowAsync();
        }
    }
}

private void BoldButton_Click(object sender, RoutedEventArgs e)
{
    Windows.UI.Text.ITextSelection selectedText = editor.Document.Selection;
    if (selectedText != null)
    {
        Windows.UI.Text.ITextCharacterFormat charFormatting = selectedText.CharacterFormat;
        charFormatting.Bold = Windows.UI.Text.FormatEffect.Toggle;
        selectedText.CharacterFormat = charFormatting;
    }
}

private void ItalicButton_Click(object sender, RoutedEventArgs e)
{
    Windows.UI.Text.ITextSelection selectedText = editor.Document.Selection;
    if (selectedText != null)
    {
        Windows.UI.Text.ITextCharacterFormat charFormatting = selectedText.CharacterFormat;
        charFormatting.Italic = Windows.UI.Text.FormatEffect.Toggle;
        selectedText.CharacterFormat = charFormatting;
    }
}

private void UnderlineButton_Click(object sender, RoutedEventArgs e)
{
    Windows.UI.Text.ITextSelection selectedText = editor.Document.Selection;
    if (selectedText != null)
    {
        Windows.UI.Text.ITextCharacterFormat charFormatting = selectedText.CharacterFormat;
        if (charFormatting.Underline == Windows.UI.Text.UnderlineType.None)
        {
            charFormatting.Underline = Windows.UI.Text.UnderlineType.Single;
        }
        else {
            charFormatting.Underline = Windows.UI.Text.UnderlineType.None;
        }
        selectedText.CharacterFormat = charFormatting;
    }
}
```

## -see-also

[Control](control.md), [RichEditBox overview](/windows/apps/design/controls/rich-edit-box), [Touch keyboard text input sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/TouchKeyboardTextInput)
