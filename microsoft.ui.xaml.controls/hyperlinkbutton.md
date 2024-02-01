---
-api-id: T:Microsoft.UI.Xaml.Controls.HyperlinkButton
-api-type: winrt class
---

<!-- Class syntax.
public class HyperlinkButton : Windows.UI.Xaml.Controls.Primitives.ButtonBase, Windows.UI.Xaml.Controls.IHyperlinkButton
-->

# Microsoft.UI.Xaml.Controls.HyperlinkButton

## -description

Represents a button control that functions as a hyperlink.

## -xaml-syntax

```xaml
<HyperlinkButton .../>
-or-
<HyperlinkButton>stringContent</HyperlinkButton>
-or-
<HyperlinkButton>
    singleObject
</HyperlinkButton>
```

## -remarks

HyperlinkButton is a button that appears as hyperlink text when the content is set to a string value.

Here's a Hyperlink button shown first in its resting state, then in its pointer-over state.

<img alt="A Hyperlink button in its default resting state, showing blue text." src="images/controls/HyperlinkButton.png" />
<img alt="A Hyperlink button in pointer over state, showing blue text on a gray background." src="images/controls/hyperlink-button-hover.png" />

### Hyperlink and HyperlinkButton

There are two ways that you can add a hyperlink to a XAML app. [Hyperlink](../microsoft.ui.xaml.documents/hyperlink.md) and [HyperlinkButton](hyperlinkbutton.md) have the similar purpose of enabling a user to launch a specific URI using a separate browser app.
+ Use an inline [Hyperlink](../microsoft.ui.xaml.documents/hyperlink.md) text element inside of a text control. A [Hyperlink](../microsoft.ui.xaml.documents/hyperlink.md) element flows with other text elements and you can use it in any [InlineCollection](../microsoft.ui.xaml.documents/inlinecollection.md). For more info, see [Hyperlink](../microsoft.ui.xaml.documents/hyperlink.md).
+ Use a [HyperlinkButton](hyperlinkbutton.md) control anywhere in the app. A [HyperlinkButton](hyperlinkbutton.md) is a specialized [Button](button.md) control that you can use anywhere that you would use a [Button](button.md).

### Navigate to a URI

To use the hyperlink to navigate to a Uniform Resource Identifier (URI), set the [NavigateUri](hyperlinkbutton_navigateuri.md) property. When a user clicks or taps the HyperlinkButton, the specified URI opens in the default browser. The default browser runs in a separate process from your app.

> [!TIP]
> You don't have to use **http:** or **https:** schemes. You can use schemes such as **ms-appx:**, **ms-appdata:**, or **ms-resources:**, if there's resource content at these locations that's appropriate to load in a browser. However, the **file:** scheme is specifically blocked. For more info, see [URI schemes](/windows/uwp/app-resources/uri-schemes).

When a user clicks the HyperlinkButton, the value of the [NavigateUri](hyperlinkbutton_navigateuri.md) property is passed to a system handler for Uniform Resource Identifier (URI) types and schemes. The system then launches the app that is registered for the scheme of the URI provided for [NavigateUri](hyperlinkbutton_navigateuri.md).

If you don't want the HyperlinkButton to load content in a default Web browser (and don't want a browser to appear), then don't set a value for [NavigateUri](hyperlinkbutton_navigateuri.md). Instead, handle the [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) event, and write code that does what you want.

### Handle the Click event

Use the [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) event for actions other than launching a URI in a browser, such as navigation within the app. For example, if you want to load a new app page rather than opening a browser, call a [Frame.Navigate](frame_navigate_1557370995.md) method within your [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) event handler to navigate to the new app page. If you want an external, absolute URI to load within a [WebView2](webview2.md) control that also exists in your app, set the [WebView2.Source](webview2_source.md) property to the URI to load as part of your [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) handler logic.

You don't typically handle the [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) event as well as specifying a [NavigateUri](hyperlinkbutton_navigateuri.md) value, as these represent two different ways of using the [Hyperlink](../microsoft.ui.xaml.documents/hyperlink.md) element. If your intent is to open the URI in the default browser, and you have specified a value for [NavigateUri](hyperlinkbutton_navigateuri.md), don't handle the [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) event. Conversely, if you handle the [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) event, don't specify a [NavigateUri](hyperlinkbutton_navigateuri.md).

There's nothing you can do within the [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) event handler to prevent the default browser from loading any valid target specified for [NavigateUri](hyperlinkbutton_navigateuri.md); that action takes place automatically (asynchronously) when the hyperlink is activated and can't be canceled from within the [Click](../microsoft.ui.xaml.controls.primitives/buttonbase_click.md) event handler.

### Control style and template

You can modify the default [Style](../microsoft.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is installed with the Windows App SDK NuGet package. By default, this location is `\Users\<username>\.nuget\packages\microsoft.windowsappsdk\<version>\lib\uap10.0\Microsoft.UI\Themes\generic.xaml`. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Hyperlinks](/windows/apps/design/controls/hyperlinks).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the HyperlinkButton in action](winui3gallery:/item/HyperlinkButton)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).

Here's a HyperlinkButton as declared in XAML. It declares a string value for [Content](contentcontrol_content.md) and also a [NavigateUri](hyperlinkbutton_navigateuri.md) value.

[!code-xaml[BasicHyperlinkButtonXAML](../microsoft.ui.xaml.controls/code/BasicControlSnippets/CS/MainPage.xaml#SnippetBasicHyperlinkButtonXAML)]

## -see-also
[ButtonBase](../microsoft.ui.xaml.controls.primitives/buttonbase.md), [Hyperlinks overview](/windows/apps/design/controls/hyperlinks)
