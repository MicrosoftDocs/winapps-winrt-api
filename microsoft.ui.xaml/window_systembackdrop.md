---
-api-id: P:Microsoft.UI.Xaml.Window.SystemBackdrop
-api-type: winrt property
---

# Microsoft.UI.Xaml.Window.SystemBackdrop

<!--
public Microsoft.UI.Xaml.Media.SystemBackdrop SystemBackdrop { get; set; }
-->

## -description

Gets or sets the system backdrop to apply to this `Window`. The backdrop is rendered behind the `Window` content.

## -property-value

The system backdrop to apply to this `Window`.

## -remarks

For more information about system backdrops, see [Materials in Windows 11](/windows/apps/design/signature-experiences/materials).

The backdrop is rendered behind the content specified in [Window.Content](window_content.md). If all the content is fully opaque, this backdrop will have no visible effect.

## -see-also

[MicaBackdrop](../microsoft.ui.xaml.media/micabackdrop.md), [MicaKind](../microsoft.ui.composition.systembackdrops/micakind.md), [DesktopAcrylicBackdrop](../microsoft.ui.xaml.media/desktopacrylicbackdrop.md), [Mica material](/windows/apps/design/style/mica), [Acrylic material](/windows/apps/design/style/acrylic)

## -examples

This example shows how to set the `SystemBackdrop` to use [Mica Alt](/windows/apps/design/style/mica#app-layering-with-mica-alt).

```xaml
<Window
    ...>
    <Window.SystemBackdrop>
        <MicaBackdrop Kind="BaseAlt"/>
    </Window.SystemBackdrop>

    <Grid RowDefinitions="*,*">
        <!-- This area has a transparent background, so the Mica
         backdrop will be mostly visible. For example, if there are
         buttons here, the backdrop will show up in the margins
         and gaps between the buttons. -->
        <Grid Background="Transparent"></Grid>
           
        <!-- This area has an opaque background,
         so the Mica backdrop won't be visible. -->
        <Grid Grid.Row="1" Background="Gray"></Grid>
    </Grid>
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
