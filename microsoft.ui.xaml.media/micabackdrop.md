---
-api-id: T:Microsoft.UI.Xaml.Media.MicaBackdrop
-api-type: winrt class
---

# Microsoft.UI.Xaml.Media.MicaBackdrop

<!--
public class MicaBackdrop : Microsoft.UI.Xaml.Media.SystemBackdrop
-->

## -description

Represents a system backdrop that applies Mica material to a supported XAML surface, such as a `Window`.

## -remarks

You can use `MicaBackdrop` to apply [Mica material](/windows/apps/design/style/mica) to an object that implements the [ICompositionSupportsSystemBackdrop](../microsoft.ui.composition/icompositionsupportssystembackdrop.md) interface, typically a XAML [Window](../microsoft.ui.xaml/window.md).

Mica isn't supported on all systems. Where it's not supported, a solid color is used instead of the Mica effect.

## -see-also

[Mica material](/windows/apps/design/style/mica), [MicaController](../microsoft.ui.composition.systembackdrops/micacontroller.md), [SystemBackdrop](systembackdrop.md), [Window.SystemBackdrop](../microsoft.ui.xaml/window_systembackdrop.md), [DesktopAcrylicBackdrop](desktopacrylicbackdrop.md)

## -examples

```xaml
<Window
    ... >

    <Window.SystemBackdrop>
        <MicaBackdrop Kind="BaseAlt"/>
    </Window.SystemBackdrop>

</Window>
```

```csharp
public MainWindow()
{
    this.InitializeComponent();

    SystemBackdrop = new MicaBackdrop() 
                        { Kind = MicaKind.BaseAlt };
}
```
