---
-api-id: P:Microsoft.UI.Xaml.Documents.Hyperlink.NavigateUri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri NavigateUri { get;  set; }
-->

# Microsoft.UI.Xaml.Documents.Hyperlink.NavigateUri

## -description
Gets or sets the Uniform Resource Identifier (URI) to navigate to when the [Hyperlink](hyperlink.md) is activated.

## -xaml-syntax
```xaml
<Hyperlink NavigateUri="uriString"/>
```


## -xaml-values
<dl><dt>uriString</dt><dd>uriStringA URI represented in string form. This is usually an absolute URI and usually includes the scheme (for example http://). XAML can interpret relative URIs to be relative from the XAML file's location in the app, but this isn't a common usage for a Hyperlink. See Remarks.</dd>
</dl>
## -property-value
The Uniform Resource Identifier (URI) to navigate to when the [Hyperlink](hyperlink.md) is activated. The default is **null**.

## -remarks

By default, a [Hyperlink](hyperlink.md) appears as a text hyperlink. When a user clicks it, it opens the URI you specify in the NavigateUri property in the default browser. (More specifically, it launches in the app that's registered for the particular scheme/protocol as you specified in the NavigateUri value.) The default browser is a separate process from your app. The typical user experience is that a new browser app appears as a split pane alongside your app, and the browser gets focus.

You don't need to handle the [Click](hyperlink_click.md) event to cause the navigation when you specify a value for NavigateUri. The [Click](hyperlink_click.md) event is intended for navigation within the app, for example if you want a new app page to load, and for that scenario you don't need a NavigateUri value. There's also nothing you can do within the [Click](hyperlink_click.md) event handler to prevent the default browser from loading any valid target specified for NavigateUri; that action takes place automatically (asynchronously) when the hyperlink is activated and can't be canceled from within the [Click](hyperlink_click.md) event handler.

If your intent is that the [Hyperlink](hyperlink.md) should load a specified URI within a [WebView2](../microsoft.ui.xaml.controls/webview2.md) control that's also part of your app, then don't specify a value for NavigateUri. Handle the [Click](hyperlink_click.md) event instead, and call [WebView2.Source](../microsoft.ui.xaml.controls/webview2_source.md), specifying the URI to load.

You don't have to use **http:** or **https:** schemes. You can use schemes such as **ms-appx:**, **ms-appdata:**, or **ms-resources:**, if there's resource content at these locations that's appropriate to load in a browser. However, the **file:** scheme is specifically blocked. For more info, see [URI schemes](/previous-versions/windows/apps/jj655406(v=win.10)).

## -examples

## -see-also

[Click event](hyperlink_click.md)
