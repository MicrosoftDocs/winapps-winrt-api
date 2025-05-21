---
-api-id: T:Microsoft.UI.Xaml.XamlIsland
-api-type: winrt class
---

# Microsoft.UI.Xaml.XamlIsland

<!--
public class XamlIsland : System.IDisposable
-->

## -description

Defines an object that enables an application to host fragments of XAML content.

## -remarks

When a **XamlIsland** is created, it internally creates, manages, and exposes a [**ContentIsland**](../microsoft.ui.content/contentisland.md) object. This lets developers connect to the **ContentIsland** with their own [**DesktopChildSiteBridge**](../microsoft.ui.content/desktopchildsitebridge.md) and host XAML content on the **XamlIsland**.

[WebView2](../microsoft.ui.xaml.controls/webview2.md) is not supported when hosting XAML content in a **XamlIsland**. You must use [DesktopWindowXamlSource](../microsoft.ui.xaml.hosting/desktopwindowxamlsource.md) instead.

## -see-also

## -examples
