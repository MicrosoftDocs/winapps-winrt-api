---
-api-id: T:Microsoft.UI.Xaml.Media.DesktopAcrylicBackdrop
-api-type: winrt class
---

# Microsoft.UI.Xaml.Media.DesktopAcrylicBackdrop

<!--
public class DesktopAcrylicBackdrop : Microsoft.UI.Xaml.Media.SystemBackdrop
-->

## -description

Represents a system backdrop that applies Acrylic material to a supported XAML surface, such as a `Window`.

## -remarks

You can use `DesktopAcrylicBackdrop` to apply [Acrylic material](/windows/apps/design/style/acrylic) to an object that implements the [ICompositionSupportsSystemBackdrop](../microsoft.ui.composition/icompositionsupportssystembackdrop.md) interface, typically a XAML [Window](../microsoft.ui.xaml/window.md).

## -see-also

[Acrylic material](/windows/apps/design/style/acrylic), [DesktopAcrylicController](../microsoft.ui.composition.systembackdrops/desktopacryliccontroller.md), [SystemBackdrop](systembackdrop.md), [Window.SystemBackdrop](../microsoft.ui.xaml/window_systembackdrop.md), [MicaBackdrop](micabackdrop.md)

## -examples

```xaml
<Window
    ... >

    <Window.SystemBackdrop>
        <DesktopAcrylicBackdrop/>
    </Window.SystemBackdrop>

</Window>
```

```csharp
public MainWindow()
{
    this.InitializeComponent();

    SystemBackdrop = new DesktopAcrylicBackdrop();
}
```
