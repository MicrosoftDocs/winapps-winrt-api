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

When a XamlIsland is created, it internally creates, manages, and exposes a [ContentIsland](../microsoft.ui.content/contentisland.md) object. This lets developers connect to the ContentIsland with their own [DesktopChildSiteBridge](../microsoft.ui.content/desktopchildsitebridge.md) and host XAML content on the XamlIsland.

:::image type="complex" source="images/XamlIsland-architecture.png" alt-text="Diagram showing the architecture of XamlIsland, illustrating how XamlIsland hosts XAML content via a ContentIsland and connects to DesktopChildSiteBridge for integration with desktop applications.":::
The diagram illustrates the architecture of XamlIsland. At the core, a XamlIsland object is shown hosting XAML content. This XamlIsland internally manages a ContentIsland, which acts as a bridge between the XAML UI and the host application. The ContentIsland is connected to a DesktopChildSiteBridge, which enables integration with desktop applications. The flow demonstrates how XAML UI elements are rendered within the XamlIsland, passed through the ContentIsland, and made accessible to the host application via the DesktopChildSiteBridge. The diagram visually represents the separation of responsibilities and the connection points between the XAML content and the desktop environment.
:::image-end:::

[WebView2](../microsoft.ui.xaml.controls/webview2.md) is not supported when hosting XAML content in a XamlIsland. You must use [DesktopWindowXamlSource](../microsoft.ui.xaml.hosting/desktopwindowxamlsource.md) instead.

## -see-also

## -examples
