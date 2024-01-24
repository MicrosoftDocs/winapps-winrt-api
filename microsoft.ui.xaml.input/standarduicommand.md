---
-api-id: T:Microsoft.UI.Xaml.Input.StandardUICommand
-api-type: winrt class
---

<!-- Class syntax.
public class StandardUICommand : UICommand, UICommand
-->

# Microsoft.UI.Xaml.Input.StandardUICommand

## -description

Derives from [XamlUICommand](xamluicommand.md), adding a set of standard platform commands with pre-defined properties.

## -remarks

[XamlUICommand](xamluicommand.md) implements the `ICommand` interface ([Microsoft.UI.Xaml.Input.ICommand](icommand.md) for C++ or [System.Windows.Input.ICommand](/dotnet/api/system.windows.input.icommand?view=dotnet-uwp-10.0&preserve-view=true) for C#), adding various UI properties, methods, and events.

The platform provides the following set of commands.

| Command | Icon | Keyboard shortcut | Label | Description |
| ------- | ---- | ----------------- | ----- | ----------- |
| Cut |  |  |  |  |  |
| Copy |  |  |  |  |  |
| Paste |  |  |  |  |  |
| Select All |  |  |  |  |  |
| Delete |  |  |  |  |  |
| Share |  |  |  |  |  |
| Save |  |  |  |  |  |
| Open |  |  |  |  |  |
| Close |  |  |  |  |  |
| Pause |  |  |  |  |  |
| Play |  |  |  |  |  |
| Stop |  |  |  |  |  |
| Forward |  |  |  |  |  |
| Backward |  |  |  |  |  |
| Undo |  |  |  |  |  |
| Redo |  |  |  |  |  |

## -see-also

[XamlUICommand](xamluicommand.md), [Commanding in Windows apps using StandardUICommand, XamlUICommand, and ICommand](/windows/apps/design/controls/commanding)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Commanding basics](/windows/uwp/layout/commanding-basics).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see the StandardUICommand in action](winui3gallery:/item/StandardUICommand)

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery).
